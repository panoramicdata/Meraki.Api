using System.Net;

namespace Meraki.Api.Test.Networks.Webhooks;

public class WebHookTests(ITestOutputHelper testOutputHelper) : MerakiClientTest(testOutputHelper)
{
	[Fact]
	public async Task WebhookHttpServers_Crud_Succeeds()
	{
		var network = await CreateTestNetworkAsync();
		_ = network.Should().NotBeNull();

		try
		{
			var httpServer = await CreateAndVerifyHttpServerAsync(network.Id);
			await UpdateAndVerifyHttpServerAsync(network.Id, httpServer);
			await DeleteAndVerifyHttpServerAsync(network.Id, httpServer.Id);
		}
		finally
		{
			// Delete the network
			await RemoveNetworkAsync(network.Id);
		}

		await AssertNetworkIsGoneAsync(network.Id);
	}

	/// <summary>
	/// The server this test creates. The URL must be a valid https one, because Meraki resolves it
	/// before accepting the request.
	/// </summary>
	private static WebhookHttpServer TestHttpServerRequest
		=> new()
		{
			Name = "Test Webhook HTTP Server",
			SharedSecret = "testsharedsecret",
			Url = "https://webhook.site",
		};

	/// <summary>
	/// Creates a webhook HTTP server, then checks it is listed and reads back as created.
	/// </summary>
	private async Task<WebhookHttpServer> CreateAndVerifyHttpServerAsync(string networkId)
	{
		var testWebhookHttpServerRequest = TestHttpServerRequest;

		var testWebhookHttpServer = await TestMerakiClient
			.Networks
			.Webhooks
			.HttpServers
			.CreateNetworkWebhooksHttpServerAsync(
				networkId,
				testWebhookHttpServerRequest,
				cancellationToken: CancellationToken);
		_ = testWebhookHttpServer.Should().NotBeNull();

		// Request all WebhookHttpServers and check it's there
		var testWebhookHttpServers = await TestMerakiClient
			.Networks
			.Webhooks
			.HttpServers
			.GetNetworkWebhooksHttpServersAsync(
				networkId,
				cancellationToken: CancellationToken);
		_ = testWebhookHttpServers.Should().Contain(server => server.Name == testWebhookHttpServerRequest.Name);

		await AssertHttpServerReadsBackAsync(networkId, testWebhookHttpServer, testWebhookHttpServerRequest);

		return testWebhookHttpServer;
	}

	private async Task AssertHttpServerReadsBackAsync(
		string networkId,
		WebhookHttpServer created,
		WebhookHttpServer request)
	{
		var expectedWebhookHttpServer = new WebhookHttpServer
		{
			// Don't set SharedSecret in the comparison object because it won't come back
			Name = request.Name,
			NetworkId = networkId,
			// The new WebhookHttpSever Id is only returned after creation so we have to get it from there
			Id = created.Id,
			Url = request.Url,
		};

		var retrievedTestWebhookHttpServer = await TestMerakiClient
			.Networks
			.Webhooks
			.HttpServers
			.GetNetworkWebhooksHttpServerAsync(
				networkId,
				created.Id,
				cancellationToken: CancellationToken);

		_ = retrievedTestWebhookHttpServer.Should()
			.NotBeNull()
			.And
			.BeEquivalentTo(
				expectedWebhookHttpServer,
				// Exclude the payload template because we didn't set it
				options => options.Excluding(n => n.PayloadTemplate)
			);
	}

	/// <summary>
	/// Renames the server, and checks the change came back on the updated object.
	/// </summary>
	private async Task UpdateAndVerifyHttpServerAsync(string networkId, WebhookHttpServer httpServer)
	{
		const string updatedName = "Test Webhook HTTP Server - Updated";

		// Only provide the item we want to change
		var updateWebhookHttpServerRequest = new WebhookHttpServer
		{
			Name = updatedName,
		};
		var updatedTestWebhookHttpServer = await TestMerakiClient
			.Networks
			.Webhooks
			.HttpServers
			.UpdateNetworkWebhooksHttpServerAsync(
				networkId,
				httpServer.Id,
				updateWebhookHttpServerRequest,
				cancellationToken: CancellationToken);

		_ = updatedTestWebhookHttpServer.Should().NotBeNull();
		_ = updatedTestWebhookHttpServer.Name.Should().Be(updatedName);
		_ = updatedTestWebhookHttpServer.Id.Should().Be(httpServer.Id);
		_ = updatedTestWebhookHttpServer.NetworkId.Should().Be(networkId);
		_ = updatedTestWebhookHttpServer.Url.Should().Be(httpServer.Url);
	}

	private async Task DeleteAndVerifyHttpServerAsync(string networkId, string httpServerId)
	{
		await TestMerakiClient
			.Networks
			.Webhooks
			.HttpServers
			.DeleteNetworkWebhooksHttpServerAsync(
				networkId,
				httpServerId,
				cancellationToken: CancellationToken);

		await AssertNotFoundAsync(() => TestMerakiClient
			.Networks
			.Webhooks
			.HttpServers
			.GetNetworkWebhooksHttpServerAsync(
				networkId,
				httpServerId,
				cancellationToken: CancellationToken));
	}

	private Task AssertNetworkIsGoneAsync(string networkId)
		=> AssertNotFoundAsync(() => TestMerakiClient
			.Networks
			.GetNetworkAsync(
				networkId,
				cancellationToken: CancellationToken));

	/// <summary>
	/// Asserts that the call fails with a 404, which is how these tests confirm a deletion.
	/// </summary>
	private static async Task AssertNotFoundAsync<T>(Func<Task<T>> act)
		=> _ = await act
			.Should()
			.ThrowExactlyAsync<ApiException>()
			.Where(ex => ex.StatusCode == HttpStatusCode.NotFound);

	[Fact]
	public async Task NetworkWebhookPayloadTemplates_Crud_Succeeds()
	{
		var network = await CreateTestNetworkAsync();
		_ = network.Should().NotBeNull();

		try
		{
			await RemoveExistingNetworkPayloadTemplatesAsync(network.Id);

			// The request object is carried through, because the update assertion compares the
			// updated template against what was originally asked for.
			var request = CreateTestPayloadTemplateRequest();
			var template = await CreateAndVerifyNetworkPayloadTemplateAsync(network.Id, request);
			var httpServer = await CreateHttpServerUsingTemplateAsync(network.Id, template.PayloadTemplateId!, request.Name);
			await UpdateAndVerifyNetworkPayloadTemplateAsync(network.Id, template.PayloadTemplateId!, request);

			await DeleteAndVerifyHttpServerAsync(network.Id, httpServer.Id);
			await DeleteAndVerifyNetworkPayloadTemplateAsync(network.Id, template.PayloadTemplateId!);
		}
		finally
		{
			// Delete the network
			await RemoveNetworkAsync(network.Id);
		}

		await AssertNetworkIsGoneAsync(network.Id);
	}

	/// <summary>
	/// Clears any templates a previous run left behind, so the create below starts from a known state.
	/// </summary>
	private async Task RemoveExistingNetworkPayloadTemplatesAsync(string networkId)
	{
		var existingPayloadTemplates = await TestMerakiClient
			.Networks
			.Webhooks
			.PayloadTemplates
			.GetNetworkWebhooksPayloadTemplatesAsync(
				networkId,
				cancellationToken: CancellationToken);

		var oldTemplates = existingPayloadTemplates
			.Where(t => t.Name.StartsWith(TestPayloadTemplateNamePrefix, StringComparison.Ordinal))
			.ToList();

		foreach (var oldTemplate in oldTemplates)
		{
			await TestMerakiClient
				.Networks
				.Webhooks
				.PayloadTemplates
				.DeleteNetworkWebhooksPayloadTemplateAsync(
					Configuration.TestOrganizationId,
					oldTemplate.PayloadTemplateId!,
					cancellationToken: CancellationToken
				);
		}
	}

	private async Task<PayloadTemplate> CreateAndVerifyNetworkPayloadTemplateAsync(string networkId, PayloadTemplate request)
	{
		var created = await TestMerakiClient
			.Networks
			.Webhooks
			.PayloadTemplates
			.CreateNetworkWebhooksPayloadTemplateAsync(
				networkId,
				request,
				cancellationToken: CancellationToken
			);

		_ = created.Should().NotBeNull();

		// Our new payload template should be among all of them
		var retrieved = await TestMerakiClient
			.Networks
			.Webhooks
			.PayloadTemplates
			.GetNetworkWebhooksPayloadTemplatesAsync(
				networkId,
				cancellationToken: CancellationToken);

		_ = retrieved.Should().NotBeNull();
		_ = retrieved
			.Should()
			.Contain(payloadTemplate => payloadTemplate.Name == request.Name);

		return created;
	}

	private async Task<WebhookHttpServer> CreateHttpServerUsingTemplateAsync(
		string networkId,
		string payloadTemplateId,
		string payloadTemplateName)
	{
		var request = TestHttpServerRequest;
		request.PayloadTemplate = new()
		{
			Id = payloadTemplateId,
			Name = payloadTemplateName,
		};

		var httpServer = await TestMerakiClient
			.Networks
			.Webhooks
			.HttpServers
			.CreateNetworkWebhooksHttpServerAsync(
				networkId,
				request,
				cancellationToken: CancellationToken);
		_ = httpServer.Should().NotBeNull();

		return httpServer;
	}

	private async Task UpdateAndVerifyNetworkPayloadTemplateAsync(
		string networkId,
		string payloadTemplateId,
		PayloadTemplate request)
	{
		var updated = await TestMerakiClient
			.Networks
			.Webhooks
			.PayloadTemplates
			.UpdateNetworkWebhooksPayloadTemplateAsync
			(
				networkId,
				payloadTemplateId,
				new PayloadTemplate
				{
					Name = request.Name + " Updated",
				},
				cancellationToken: CancellationToken
			);

		// Modify the name in our original request then compare it against what we get back
		request.Name = updated.Name;
		_ = updated.Should()
			.BeEquivalentTo(
				request,
				options => options
					.Excluding(p => p.PayloadTemplateId)
					.Excluding(p => p.Type)
					.Excluding(p => p.Headers)
					.Excluding(p => p.Sharing)
					);
	}

	private async Task DeleteAndVerifyNetworkPayloadTemplateAsync(string networkId, string payloadTemplateId)
	{
		await TestMerakiClient
			.Networks
			.Webhooks
			.PayloadTemplates
			.DeleteNetworkWebhooksPayloadTemplateAsync(
				networkId,
				payloadTemplateId,
				cancellationToken: CancellationToken);

		await AssertNotFoundAsync(() => TestMerakiClient
			.Networks
			.Webhooks
			.PayloadTemplates
			.GetNetworkWebhooksPayloadTemplateAsync(
				networkId,
				payloadTemplateId,
				cancellationToken: CancellationToken));
	}

	private const string TestPayloadTemplateNamePrefix = "Test Payload Template";

	/// <summary>
	/// A uniquely named template, so concurrent or repeated runs do not collide.
	/// </summary>
	private static PayloadTemplate CreateTestPayloadTemplateRequest()
		=> new()
		{
			Name = $"{TestPayloadTemplateNamePrefix} {DateTime.UtcNow:yyyy-MM-dd HH:mm:ss}",
			Body = """
			{"event_type":"{{alertTypeId}}","client_payload":{"text":"{{alertData}}"}}
			""",
			Headers = [],
		};

	[Fact]
	public async Task OrganizationWebhookPayloadTemplates_Crud_Succeeds()
	{
		try
		{
			await RemoveExistingOrganizationPayloadTemplatesAsync();

			// The request object is carried through, because the update assertion compares the
			// updated template against what was originally asked for.
			var request = CreateTestPayloadTemplateRequest();
			var template = await CreateAndVerifyOrganizationPayloadTemplateAsync(request);
			var httpServer = await CreateOrganizationHttpServerUsingTemplateAsync(template.PayloadTemplateId!, request.Name);
			await UpdateAndVerifyOrganizationPayloadTemplateAsync(template.PayloadTemplateId!, request);

			await DeleteAndVerifyOrganizationHttpServerAsync(httpServer.Id);
			await DeleteAndVerifyOrganizationPayloadTemplateAsync(template.PayloadTemplateId!);
		}
		catch (Exception e)
		{
			TestOutputHelper.WriteLine($"OrganizationWebhookPayloadTemplates_Crud_Succeeds failed: {e.Message}");
			throw;
		}
	}

	/// <summary>
	/// Clears any templates a previous run left behind, so the create below starts from a known state.
	/// </summary>
	private async Task RemoveExistingOrganizationPayloadTemplatesAsync()
	{
		var existingPayloadTemplates = await TestMerakiClient
			.Organizations
			.Webhooks
			.PayloadTemplates
			.GetOrganizationWebhooksPayloadTemplatesAsync(
				Configuration.TestOrganizationId,
				cancellationToken: CancellationToken);

		var oldTemplates = existingPayloadTemplates
			.Where(t => t.Name.StartsWith(TestPayloadTemplateNamePrefix, StringComparison.Ordinal))
			.ToList();

		foreach (var oldTemplate in oldTemplates)
		{
			await TestMerakiClient
				.Organizations
				.Webhooks
				.PayloadTemplates
				.DeleteOrganizationWebhooksPayloadTemplateAsync(
					Configuration.TestOrganizationId,
					oldTemplate.PayloadTemplateId!,
					cancellationToken: CancellationToken
				);
		}
	}

	private async Task<PayloadTemplate> CreateAndVerifyOrganizationPayloadTemplateAsync(PayloadTemplate request)
	{
		var created = await TestMerakiClient
			.Organizations
			.Webhooks
			.PayloadTemplates
			.CreateOrganizationWebhooksPayloadTemplatesAsync(
				Configuration.TestOrganizationId,
				request,
				cancellationToken: CancellationToken
			);

		_ = created.Should().NotBeNull();

		// Our new payload template should be among all of them
		var retrieved = await TestMerakiClient
			.Organizations
			.Webhooks
			.PayloadTemplates
			.GetOrganizationWebhooksPayloadTemplatesAsync(
				Configuration.TestOrganizationId,
				cancellationToken: CancellationToken);

		_ = retrieved.Should().NotBeNull();
		_ = retrieved
			.Should()
			.Contain(payloadTemplate => payloadTemplate.Name == request.Name);

		return created;
	}

	private async Task<WebhookHttpServer> CreateOrganizationHttpServerUsingTemplateAsync(
		string payloadTemplateId,
		string payloadTemplateName)
	{
		var request = TestHttpServerRequest;
		request.PayloadTemplate = new()
		{
			Id = payloadTemplateId,
			Name = payloadTemplateName,
		};

		var httpServer = await TestMerakiClient
			.Organizations
			.Webhooks
			.HttpServers
			.CreateOrganizationWebhooksHttpServerAsync(
				Configuration.TestOrganizationId,
				request,
				cancellationToken: CancellationToken);
		_ = httpServer.Should().NotBeNull();

		return httpServer;
	}

	private async Task UpdateAndVerifyOrganizationPayloadTemplateAsync(string payloadTemplateId, PayloadTemplate request)
	{
		var updated = await TestMerakiClient
			.Organizations
			.Webhooks
			.PayloadTemplates
			.UpdateOrganizationWebhooksPayloadTemplateAsync
			(
				Configuration.TestOrganizationId,
				payloadTemplateId,
				new PayloadTemplate
				{
					Name = request.Name + " Updated",
				},
				cancellationToken: CancellationToken
			);

		// Modify the name in our original request then compare it against what we get back
		request.Name = updated.Name;
		_ = updated.Should()
			.BeEquivalentTo(
				request,
				options => options
					.Excluding(p => p.PayloadTemplateId)
					.Excluding(p => p.Type)
					.Excluding(p => p.Headers)
					.Excluding(p => p.Sharing)
					);
	}

	private async Task DeleteAndVerifyOrganizationHttpServerAsync(string httpServerId)
	{
		await TestMerakiClient
			.Organizations
			.Webhooks
			.HttpServers
			.DeleteOrganizationWebhooksHttpServerAsync(
				Configuration.TestOrganizationId,
				httpServerId,
				cancellationToken: CancellationToken
			);

		await AssertNotFoundAsync(() => TestMerakiClient
			.Organizations
			.Webhooks
			.HttpServers
			.GetOrganizationWebhooksHttpServerAsync(
				Configuration.TestOrganizationId,
				httpServerId,
				cancellationToken: CancellationToken));
	}

	private async Task DeleteAndVerifyOrganizationPayloadTemplateAsync(string payloadTemplateId)
	{
		await TestMerakiClient
			.Organizations
			.Webhooks
			.PayloadTemplates
			.DeleteOrganizationWebhooksPayloadTemplateAsync(
				Configuration.TestOrganizationId,
				payloadTemplateId,
				cancellationToken: CancellationToken
			);

		await AssertNotFoundAsync(() => TestMerakiClient
			.Organizations
			.Webhooks
			.PayloadTemplates
			.GetOrganizationWebhooksPayloadTemplateAsync(
				Configuration.TestOrganizationId,
				payloadTemplateId,
				cancellationToken: CancellationToken));
	}

	[Fact]
	public async Task WebhookTest_Cr_Succeeds()
	{
		var network = await CreateTestNetworkAsync();
		_ = network.Should().NotBeNull();

		try
		{
			//Create a Webhook Test Object
			var testCreateWebhookTestRequest = new WebhookTestRequest
			{
				Url = "https://www.google.com",
				SharedSecret = "testsharedsecret",
				// Using a built-in template for this test
				PayloadTemplateId = "wpt_00001",
				AlertTypeId = "motion_alert"
			};

			// Create the webhook test
			var testCreateWebhookTest = await TestMerakiClient
				.Networks
				.Webhooks
				.WebhookTests
				.CreateNetworkWebhooksWebhookTestAsync(
					network.Id,
					testCreateWebhookTestRequest,
					cancellationToken: CancellationToken);

			_ = testCreateWebhookTestRequest.Should().NotBeNull();

			// Check that we have an id
			_ = testCreateWebhookTest.Status.Should().Be("enqueued");

			// Retrieve the status of the enqueued test
			var testGetNetworkWebhookTest = await TestMerakiClient
				.Networks
				.Webhooks
				.WebhookTests
				.GetNetworkWebhooksWebhookTestAsync(
					network.Id,
					testCreateWebhookTest.Id,
					cancellationToken: CancellationToken);

			_ = testGetNetworkWebhookTest.Should().NotBeNull();

			// TODO Check the status is not null or empty
			_ = testGetNetworkWebhookTest.Status.Should().Be("enqueued");

		}
		finally
		{
			// Delete the network
			await RemoveNetworkAsync(network.Id);
		}

		// Make sure that the network is gone
		var networkGetAct = () => TestMerakiClient
			.Networks
			.GetNetworkAsync(
				network.Id,
				cancellationToken: CancellationToken);

		_ = await networkGetAct
			.Should()
			.ThrowExactlyAsync<ApiException>()
			.Where(ex => ex.StatusCode == HttpStatusCode.NotFound);

	}
}
