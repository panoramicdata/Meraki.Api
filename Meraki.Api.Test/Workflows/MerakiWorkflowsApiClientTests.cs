using Meraki.Api.Workflows;
using Microsoft.Extensions.Logging.Abstractions;
using System.Net;
using System.Net.Http.Headers;

namespace Meraki.Api.Test.Workflows;

public class MerakiWorkflowsApiClientTests
{
	[Fact]
	public void Contract_CoversEveryPublishedOperation()
	{
		var operations = typeof(IMerakiWorkflowsApiClient).GetMethods();

		_ = operations.Should().HaveCount(156);
		_ = operations.Select(operation => operation.Name).Should().OnlyHaveUniqueItems();
		_ = operations.Should().OnlyContain(operation =>
			typeof(Task).IsAssignableFrom(operation.ReturnType),
			"every generated API operation must remain asynchronous");
		_ = operations.Should().OnlyContain(operation =>
			operation.GetParameters().Count(parameter =>
				parameter.Name == "organizationId" && parameter.ParameterType == typeof(string)) == 1,
			"every Workflows route is scoped to exactly one Meraki organization");
		_ = operations.Should().OnlyContain(operation =>
			operation.GetParameters().Last().ParameterType == typeof(CancellationToken),
			"every operation must support cooperative cancellation");
		_ = operations.Should().Contain(method => method.Name == "GetAllWorkflowsQueryParamsV1Async");
		_ = operations.Should().Contain(method => method.Name == "StartWorkflowRequestV1Dot1Async");
		_ = operations.Should().Contain(method => method.Name == "TemplateWorkflowCreateRequestAsync");
		_ = operations.Should().Contain(method => method.Name == "ImportFromJSONReqAsync");
	}

	[Fact]
	public async Task ListWorkflows_UsesOrganizationScopedV1RouteAndDeserializesResponse()
	{
		var handler = new CaptureHandler(
			HttpStatusCode.OK,
			"[{\"id\":\"wf-1\",\"title\":\"Daily backup\",\"unique_name\":\"daily_backup\"}]");
		using var httpClient = new HttpClient(handler)
		{
			BaseAddress = new Uri("https://api.meraki.com/api/automate/organizations/")
		};
		var client = new MerakiWorkflowsApiClient(httpClient);

		var workflows = await client.GetAllWorkflowsQueryParamsV1Async(
			"123456",
			is_atomic: false,
			categories: "Operations",
			TestContext.Current.CancellationToken);

		_ = handler.RequestUri.Should().Be(
			new Uri("https://api.meraki.com/api/automate/organizations/123456/v1/workflows?is_atomic=false&categories=Operations"));
		_ = handler.Method.Should().Be(HttpMethod.Get);
		_ = workflows.Should().ContainSingle();
		_ = workflows.Single().Id.Should().Be("wf-1");
		_ = workflows.Single().Title.Should().Be("Daily backup");
		_ = workflows.Single().Unique_name.Should().Be("daily_backup");
	}

	[Fact]
	public async Task StartWorkflow_UsesV11MultipartContract()
	{
		var handler = new CaptureHandler(HttpStatusCode.OK, "[]");
		using var httpClient = new HttpClient(handler)
		{
			BaseAddress = new Uri("https://api.meraki.com/api/automate/organizations/")
		};
		var client = new MerakiWorkflowsApiClient(httpClient);
		await using var file = new MemoryStream([1, 2, 3]);

		_ = await client.StartWorkflowRequestV1Dot1Async(
			"123456",
			workflow_id: "wf-1",
			sync: true,
			file_name: new FileParameter(file, "input.txt", "text/plain"),
			request_body: "{\"input_variables\":[]}",
			cancellationToken: TestContext.Current.CancellationToken);

		_ = handler.RequestUri.Should().Be(
			new Uri("https://api.meraki.com/api/automate/organizations/123456/v1.1/workflows/start?workflow_id=wf-1&sync=true"));
		_ = handler.Method.Should().Be(HttpMethod.Post);
		_ = handler.ContentType.Should().StartWith("multipart/form-data;");
		_ = handler.RequestBody.Should().Contain("name=file_name");
		_ = handler.RequestBody.Should().Contain("filename=input.txt");
		_ = handler.RequestBody.Should().Contain("name=request_body");
		_ = handler.RequestBody.Should().Contain("input_variables");
	}

	[Fact]
	public async Task MinimalWorkflowLifecycle_ImportsValidatesExecutesReadsAndDeletes()
	{
		var handler = CreateLifecycleHandler();
		using var httpClient = new HttpClient(handler)
		{
			BaseAddress = new Uri("https://api.meraki.com/api/automate/organizations/")
		};
		var client = new MerakiWorkflowsApiClient(httpClient);
		var cancellationToken = TestContext.Current.CancellationToken;
		const string workflowUniqueName = "definition_workflow_000000000000000000000000000";
		var created = await client.ImportFromJSONReqAsync(
			CreateMinimalWorkflowExport(workflowUniqueName),
			"123456",
			workflow_unique_name: workflowUniqueName,
			create_new: true,
			overwrite: false,
			skip_all_runtime_users: true,
			skip_all_module_targets: true,
			cancellationToken: cancellationToken);
		var fetched = await client.GetWorkflowByIdAsync("123456", created.Id!, cancellationToken);
		var validation = await client.ValidateWorkflowParamsAsync("123456", created.Id!, cancellationToken);
		var started = await client.StartWorkflowRequestAsync(
			"123456",
			workflow_id: created.Id,
			sync: true,
			body: new StartWorklfowPostRequestPayload(),
			cancellationToken: cancellationToken);
		var instance = await client.GetWFInstanceByIdAsync(
			"123456",
			started.Single().Id!,
			detailed: true,
			cancellationToken);
		await client.DeleteWFInstanceByIdAsync("123456", instance.Id!, cancellationToken);
		var deleted = await client.DeleteWorkflowByIdAsync("123456", created.Id!, cancellationToken);

		_ = created.Id.Should().Be("wf-1");
		_ = fetched.Name.Should().Be("meraki_api_test");
		_ = validation.Workflow_valid.Should().BeTrue();
		_ = validation.Invalid_action_ids.Should().BeEmpty();
		_ = validation.Total_actions.Should().Be(1);
		_ = validation.Total_valid.Should().Be(1);
		_ = started.Should().ContainSingle();
		_ = started.Single().Definition_id.Should().Be("wf-1");
		_ = instance.Status!.State.Should().Be("success");
		_ = deleted.Should().BeNull("Cisco documents a successful workflow deletion as either 202 or 204");

		AssertLifecycleRequests(handler, workflowUniqueName);
	}

	/// <summary>
	/// The seven responses the lifecycle above consumes, in the order it makes the calls.
	/// </summary>
	private static QueueHandler CreateLifecycleHandler()
		=> new QueueHandler()
			.Enqueue(HttpStatusCode.OK, """
				{"id":"wf-1","name":"meraki_api_test","title":"Minimal test workflow","properties":{}}
				""")
			.Enqueue(HttpStatusCode.OK, """
				{"id":"wf-1","name":"meraki_api_test","title":"Minimal test workflow","properties":{},"actions":[{"id":"action-1","type":"logic.completed"}]}
				""")
			.Enqueue(HttpStatusCode.OK, """
				{"workflow_valid":true,"invalid_action_ids":[],"total_actions":1,"total_valid":1,"total_variables":0}
				""")
			.Enqueue(HttpStatusCode.OK, """
				[{"id":"instance-1","definition_id":"wf-1","status":{"state":"success"}}]
				""")
			.Enqueue(HttpStatusCode.OK, """
				{"id":"instance-1","definition_id":"wf-1","status":{"state":"success"}}
				""")
			.Enqueue(HttpStatusCode.Accepted)
			.Enqueue(HttpStatusCode.NoContent);

	/// <summary>
	/// Asserts the exact requests the lifecycle put on the wire, and the bodies that carry content.
	/// </summary>
	private static void AssertLifecycleRequests(QueueHandler handler, string workflowUniqueName)
	{
		_ = handler.Requests.Select(request => (request.Method, request.Uri.PathAndQuery)).Should().Equal(
			(HttpMethod.Post, $"/api/automate/organizations/123456/exchange/v1/workflows/import?workflow_unique_name={workflowUniqueName}&create_new=true&overwrite=false&skip_all_runtime_users=true&skip_all_module_targets=true"),
			(HttpMethod.Get, "/api/automate/organizations/123456/v1/workflows/wf-1"),
			(HttpMethod.Post, "/api/automate/organizations/123456/v1/workflows/wf-1/validate"),
			(HttpMethod.Post, "/api/automate/organizations/123456/v1/workflows/start?workflow_id=wf-1&sync=true"),
			(HttpMethod.Get, "/api/automate/organizations/123456/v1/instances/instance-1?detailed=true"),
			(HttpMethod.Delete, "/api/automate/organizations/123456/v1/instances/instance-1"),
			(HttpMethod.Delete, "/api/automate/organizations/123456/v1/workflows/wf-1"));
		_ = handler.Requests[0].Body.Should().Contain("\"unique_name\":\"definition_workflow_000000000000000000000000000\"");
		_ = handler.Requests[0].Body.Should().Contain("\"type\":\"generic.workflow\"");
		_ = handler.Requests[0].Body.Should().Contain("\"type\":\"logic.completed\"");
		_ = handler.Requests[0].Body.Should().Contain("\"completion_type\":\"succeeded\"");
		_ = handler.Requests[3].Body.Should().Be("{}");
	}

	private static ImportExport_WFExportObjects CreateMinimalWorkflowExport(string workflowUniqueName)
		=> new()
		{
			Workflow = new ImportExport_WorkflowDefExport
			{
				Actions =
				[
					new ImportExport_ActionDefExport
					{
						Base_type = "activity",
						Name = "Completed",
						Object_type = "definition_activity",
						Properties = new Dictionary<string, object>
						{
							["completion_type"] = "succeeded",
							["continue_on_failure"] = false,
							["display_name"] = "Completed - Success",
							["result_message"] = "Minimal workflow completed successfully.",
							["skip_execution"] = false
						},
						Title = "Completed - Success",
						Type = "logic.completed",
						Unique_name = "definition_activity_000000000000000000000000000",
						Version = "1.0.0"
					}
				],
				Base_type = "workflow",
				Name = "meraki_api_test",
				Object_type = "definition_workflow",
				Properties = new Dictionary<string, object>
				{
					["atomic"] = new Dictionary<string, object> { ["is_atomic"] = false },
					["delete_workflow_instance"] = false,
					["display_name"] = "Minimal test workflow",
					["runtime_user"] = new Dictionary<string, object>
					{
						["override_target_runtime_user"] = false,
						["specify_on_workflow_start"] = false,
						["target_default"] = true
					},
					["target"] = new Dictionary<string, object> { ["specify_on_workflow_start"] = false }
				},
				Title = "Minimal test workflow",
				Type = "generic.workflow",
				Unique_name = workflowUniqueName,
				Variables = [],
				Version = "1.0.0"
			}
		};

	[Fact]
	public async Task ApiError_PreservesStatusBodyAndHeaders()
	{
		var handler = new QueueHandler().Enqueue(
			HttpStatusCode.Forbidden,
			"{\"error\":\"forbidden\",\"message\":\"Full organization access is required.\"}",
			("X-Request-Id", "request-123"));
		using var httpClient = new HttpClient(handler)
		{
			BaseAddress = new Uri("https://api.meraki.com/api/automate/organizations/")
		};
		var client = new MerakiWorkflowsApiClient(httpClient);

		var act = async () => await client.GetWorkflowByIdAsync(
			"123456",
			"wf-1",
			TestContext.Current.CancellationToken);

		var exception = await act.Should().ThrowAsync<MerakiWorkflowsApiException>();
		_ = exception.Which.StatusCode.Should().Be(403);
		_ = exception.Which.Response.Should().Contain("Full organization access is required.");
		var requestIdHeader = exception.Which.Headers.Single(
			header => header.Key.Equals("X-Request-Id", StringComparison.OrdinalIgnoreCase));
		_ = requestIdHeader.Value.Should().ContainSingle().Which.Should().Be("request-123");
	}

	[Fact]
	public async Task DeleteWorkflow_AcceptsDocumented202ResponseBody()
	{
		var handler = new QueueHandler().Enqueue(
			HttpStatusCode.Accepted,
			"""{"id":"wf-accepted","name":"deleted_workflow","properties":{}}""");
		using var httpClient = new HttpClient(handler)
		{
			BaseAddress = new Uri("https://api.meraki.com/api/automate/organizations/")
		};
		var client = new MerakiWorkflowsApiClient(httpClient);

		var deleted = await client.DeleteWorkflowByIdAsync(
			"123456",
			"wf-accepted",
			TestContext.Current.CancellationToken);

		_ = deleted.Should().NotBeNull();
		_ = deleted!.Id.Should().Be("wf-accepted");
		_ = handler.Requests.Should().ContainSingle();
		_ = handler.Requests.Single().Method.Should().Be(HttpMethod.Delete);
		_ = handler.Requests.Single().Uri.PathAndQuery.Should().Be(
			"/api/automate/organizations/123456/v1/workflows/wf-accepted");
	}

	private static WorkflowDefinitionPostRequest MinimalRetryTestWorkflow
		=> new()
		{
			Name = "minimal_retry_test",
			Type = "generic.workflow",
			Properties = new Dictionary<string, object>
			{
				["display_name"] = "Minimal retry test"
			}
		};

	[Fact]
	public async Task RateLimitExceeded_RetriesThroughTheMerakiClientBackOffTransport()
	{
		var options = new MerakiClientOptions
		{
			ApiKey = "test-api-key",
			UserAgent = "Meraki.Api.Test/1.0",
			MaxAttemptCount = 3,
			MaxBackOffDelaySeconds = 0
		};
		var handler = new QueueHandler()
			.Enqueue(
				HttpStatusCode.TooManyRequests,
				"{\"error\":\"rate_limit_exceeded\",\"message\":\"Rate limit exceeded\"}",
				("Retry-After", "0"))
			.Enqueue(
				HttpStatusCode.Created,
				"{\"id\":\"wf-after-retry\",\"name\":\"minimal_retry_test\",\"properties\":{}}");
		using var owningClient = new MerakiClient(options);
		using var transport = new AuthenticatedBackingOffHttpClientHandler(
			options,
			owningClient,
			NullLogger.Instance,
			handler);
		using var httpClient = new HttpClient(transport)
		{
			BaseAddress = new Uri("https://api.meraki.com/api/automate/organizations/")
		};
		var client = new MerakiWorkflowsApiClient(httpClient);

		var created = await client.WorkflowCreateRequestAsync(
			MinimalRetryTestWorkflow,
			"123456",
			TestContext.Current.CancellationToken);

		_ = created.Id.Should().Be("wf-after-retry");
		_ = handler.Requests.Should().HaveCount(2);
		_ = handler.Requests.Should().OnlyContain(request =>
			request.Method == HttpMethod.Post
			&& request.Uri.PathAndQuery == "/api/automate/organizations/123456/v1/workflows"
			&& request.Authorization == "Bearer test-api-key"
			&& request.Body!.Contains("\"name\":\"minimal_retry_test\"", StringComparison.Ordinal));
		_ = transport.Statistics.StatusCodeCounts.Should().ContainKey(429)
			.WhoseValue.Count.Should().Be(1);
		_ = transport.Statistics.StatusCodeCounts.Should().ContainKey(201)
			.WhoseValue.Count.Should().Be(1);
	}

	[Fact]
	public void MerakiClient_WiresWorkflowsClient()
	{
		using var client = new MerakiClient(new MerakiClientOptions
		{
			ApiKey = "test-api-key",
			UserAgent = "Meraki.Api.Test/1.0"
		});

		_ = client.Workflows.Should().NotBeNull();
		_ = client.Workflows.Should().BeOfType<MerakiWorkflowsApiClient>();
	}

	[Fact]
	public async Task ReadOnlyClient_RejectsWorkflowMutationBeforeSendingIt()
	{
		using var client = new MerakiClient(new MerakiClientOptions
		{
			ApiKey = "test-api-key",
			UserAgent = "Meraki.Api.Test/1.0",
			ReadOnly = true
		});

		var act = async () => await client.Workflows.WorkflowCreateRequestAsync(
			new WorkflowDefinitionPostRequest
			{
				Name = "must_not_be_sent",
				Properties = new Dictionary<string, object>()
			},
			"123456",
			TestContext.Current.CancellationToken);

		_ = await act.Should().ThrowAsync<InvalidOperationException>();
		_ = client.LastRequestUri.Should().BeEmpty("the read-only guard runs before any network request");
	}

	[Fact]
	public void ApiKey_UsesBearerAuthenticationForWorkflows()
	{
		using var request = new HttpRequestMessage(
			HttpMethod.Get,
			"https://api.meraki.com/api/automate/organizations/123456/v1/workflows");

		AuthenticatedBackingOffHttpClientHandler.ApplyAuthentication(
			request,
			new MerakiClientOptions { ApiKey = "test-api-key" });

		_ = request.Headers.Authorization.Should().BeEquivalentTo(
			new AuthenticationHeaderValue("Bearer", "test-api-key"));
		_ = request.Headers.Contains("X-Cisco-Meraki-API-Key").Should().BeFalse();
	}

	[Fact]
	public void ApiKey_KeepsDashboardAuthenticationUnchanged()
	{
		using var request = new HttpRequestMessage(
			HttpMethod.Get,
			"https://api.meraki.com/api/v1/organizations");

		AuthenticatedBackingOffHttpClientHandler.ApplyAuthentication(
			request,
			new MerakiClientOptions { ApiKey = "test-api-key" });

		_ = request.Headers.Authorization.Should().BeNull();
		_ = request.Headers.GetValues("X-Cisco-Meraki-API-Key").Should().ContainSingle()
			.Which.Should().Be("test-api-key");
	}

	[Fact]
	public void AccessToken_RemainsBearerAuthenticationForWorkflows()
	{
		using var request = new HttpRequestMessage(
			HttpMethod.Get,
			"https://api.meraki.com/api/automate/organizations/123456/v1/workflows");

		AuthenticatedBackingOffHttpClientHandler.ApplyAuthentication(
			request,
			new MerakiClientOptions { AccessToken = "oauth-token" });

		_ = request.Headers.Authorization.Should().BeEquivalentTo(
			new AuthenticationHeaderValue("Bearer", "oauth-token"));
	}

	private sealed class CaptureHandler(HttpStatusCode statusCode, string responseBody) : HttpMessageHandler
	{
		public Uri? RequestUri { get; private set; }

		public HttpMethod? Method { get; private set; }

		public string? ContentType { get; private set; }

		public string? RequestBody { get; private set; }

		protected override async Task<HttpResponseMessage> SendAsync(
			HttpRequestMessage request,
			CancellationToken cancellationToken)
		{
			RequestUri = request.RequestUri;
			Method = request.Method;
			ContentType = request.Content?.Headers.ContentType?.ToString();
			RequestBody = request.Content is null
				? null
				: await request.Content.ReadAsStringAsync(cancellationToken);

			return new HttpResponseMessage(statusCode)
			{
				Content = new StringContent(responseBody, System.Text.Encoding.UTF8, "application/json")
			};
		}
	}

	private sealed class QueueHandler : HttpMessageHandler
	{
		private readonly Queue<Func<HttpResponseMessage>> _responses = new();

		public List<CapturedRequest> Requests { get; } = [];

		public QueueHandler Enqueue(
			HttpStatusCode statusCode,
			string responseBody = "",
			params (string Name, string Value)[] headers)
		{
			_responses.Enqueue(() =>
			{
				var response = new HttpResponseMessage(statusCode)
				{
					Content = new StringContent(responseBody, System.Text.Encoding.UTF8, "application/json")
				};
				foreach (var (name, value) in headers)
				{
					_ = response.Headers.TryAddWithoutValidation(name, value);
				}

				return response;
			});
			return this;
		}

		protected override async Task<HttpResponseMessage> SendAsync(
			HttpRequestMessage request,
			CancellationToken cancellationToken)
		{
			if (_responses.Count == 0)
			{
				throw new InvalidOperationException("No queued HTTP response is available.");
			}

			Requests.Add(new CapturedRequest(
				request.Method,
				request.RequestUri!,
				request.Headers.Authorization?.ToString(),
				request.Content is null
					? null
					: await request.Content.ReadAsStringAsync(cancellationToken)));
			return _responses.Dequeue()();
		}
	}

	private sealed record CapturedRequest(HttpMethod Method, Uri Uri, string? Authorization, string? Body);
}
