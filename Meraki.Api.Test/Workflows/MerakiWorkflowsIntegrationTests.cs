using Meraki.Api.Workflows;
using System.Numerics;
using System.Security.Cryptography;

namespace Meraki.Api.Test.Workflows;

/// <summary>
/// Destructive, opt-in tests against the real Cisco Workflows service.
/// </summary>
public sealed class MerakiWorkflowsIntegrationTests(ITestOutputHelper testOutputHelper)
	: MerakiClientTest(testOutputHelper)
{
	public override async ValueTask InitializeAsync()
	{
		await base.InitializeAsync();

		// Exercise the same production 429 retry/back-off policy as every other MerakiClient API surface.
		// Do not reduce MaxAttemptCount here: Cisco Workflows can return rate_limit_exceeded for
		// longer than two attempts while a newly enabled organization is being provisioned.
		Configuration.MerakiClientOptions.ReadOnly = false;
	}

	[Fact(Explicit = true)]
	public async Task MinimalWorkflow_CanBeCreatedValidatedExecutedInspectedAndDeleted()
	{
		var organizationId = Configuration.TestOrganizationId;
		var workflowName = $"meraki_api_test_{Guid.NewGuid():N}"[..32];
		var workflowUniqueName = $"definition_workflow_{CreateKsuid()}";
		const string workflowTitle = "Meraki.Api minimal integration test";
		string? workflowId = null;
		var workflowInstanceIds = new HashSet<string>(StringComparer.Ordinal);
		var cleanupFailures = new List<Exception>();

		try
		{
			var created = await TestMerakiClient.Workflows.ImportFromJSONReqAsync(
				CreateMinimalWorkflowExport(workflowName, workflowTitle, workflowUniqueName),
				organizationId,
				workflow_unique_name: workflowUniqueName,
				create_new: true,
				overwrite: false,
				skip_all_runtime_users: true,
				skip_all_module_targets: true,
				cancellationToken: CancellationToken);
			workflowId = created.Id;

			_ = workflowId.Should().NotBeNullOrWhiteSpace();
			_ = created.Name.Should().EndWith(workflowName, "create_new imports may receive Cisco's Copy(n)- prefix");

			var fetched = await TestMerakiClient.Workflows.GetWorkflowByIdAsync(
				organizationId,
				workflowId!,
				CancellationToken);
			_ = fetched.Id.Should().Be(workflowId);
			_ = fetched.Name.Should().EndWith(workflowName);

			var validation = await TestMerakiClient.Workflows.ValidateWorkflowParamsAsync(
				organizationId,
				workflowId!,
				CancellationToken);
			_ = validation.Workflow_valid.Should().BeTrue();
			_ = validation.Invalid_action_ids.Should().BeNullOrEmpty();
			_ = validation.Total_actions.Should().BeGreaterThanOrEqualTo(1);
			_ = validation.Total_valid.Should().Be(validation.Total_actions);

			var executions = await TestMerakiClient.Workflows.StartWorkflowRequestAsync(
				organizationId,
				workflow_id: workflowId,
				sync: true,
				body: new StartWorklfowPostRequestPayload(),
				cancellationToken: CancellationToken);
			foreach (var executionId in executions
				.Select(execution => execution.Id)
				.OfType<string>()
				.Where(id => !string.IsNullOrWhiteSpace(id)))
			{
				_ = workflowInstanceIds.Add(executionId);
			}
			_ = executions.Should().ContainSingle();

			var execution = executions.Single();
			_ = execution.Id.Should().NotBeNullOrWhiteSpace();
			_ = execution.Definition_id.Should().Be(workflowId);
			_ = execution.Status.Should().NotBeNull();
			_ = execution.Status!.State.Should().BeEquivalentTo("success");

			var instance = await TestMerakiClient.Workflows.GetWFInstanceByIdAsync(
				organizationId,
				execution.Id!,
				detailed: true,
				CancellationToken);
			_ = instance.Id.Should().Be(execution.Id);
			_ = instance.Definition_id.Should().Be(workflowId);
			_ = instance.Status.Should().NotBeNull();
			_ = instance.Status!.State.Should().BeEquivalentTo("success");
		}
		finally
		{
			foreach (var instanceId in workflowInstanceIds)
			{
				await TryCleanupAsync(
					$"workflow instance {instanceId}",
					() => TestMerakiClient.Workflows.DeleteWFInstanceByIdAsync(
						organizationId,
						instanceId,
						CancellationToken),
					cleanupFailures);
			}

			if (workflowId is not null)
			{
				await TryCleanupAsync(
					$"workflow {workflowId}",
					async () => _ = await TestMerakiClient.Workflows.DeleteWorkflowByIdAsync(
						organizationId,
						workflowId,
						CancellationToken),
					cleanupFailures);
			}
		}

		_ = cleanupFailures.Should().BeEmpty("the integration test must not leave temporary workflows or runs behind");
	}

	private static ImportExport_WFExportObjects CreateMinimalWorkflowExport(
		string workflowName,
		string workflowTitle,
		string workflowUniqueName)
		=> new()
		{
			Workflow = new ImportExport_WorkflowDefExport
			{
				Actions =
				[
					new ImportExport_ActionDefExport
					{
						Base_type = "activity",
						Description = "End the minimal workflow successfully.",
						Name = "Completed",
						Object_type = "definition_activity",
						Properties = new Dictionary<string, object>
						{
							["completion_type"] = "succeeded",
							["continue_on_failure"] = false,
							["description"] = "End the minimal workflow successfully.",
							["display_name"] = "Completed - Success",
							["result_message"] = "Meraki.Api minimal workflow completed successfully.",
							["skip_execution"] = false
						},
						Title = "Completed - Success",
						Type = "logic.completed",
						Unique_name = $"definition_activity_{CreateKsuid()}",
						Version = "1.0.0"
					}
				],
				Base_type = "workflow",
				Description = "Temporary side-effect-free workflow. Created and deleted by the Meraki.Api integration suite.",
				Name = workflowName,
				Object_type = "definition_workflow",
				Properties = new Dictionary<string, object>
				{
					["atomic"] = new Dictionary<string, object>
					{
						["is_atomic"] = false
					},
					["delete_workflow_instance"] = false,
					["description"] = "Temporary side-effect-free workflow. Created and deleted by the Meraki.Api integration suite.",
					["display_name"] = workflowTitle,
					["runtime_user"] = new Dictionary<string, object>
					{
						["override_target_runtime_user"] = false,
						["specify_on_workflow_start"] = false,
						["target_default"] = true
					},
					["target"] = new Dictionary<string, object>
					{
						["specify_on_workflow_start"] = false
					}
				},
				Title = workflowTitle,
				Type = "generic.workflow",
				Unique_name = workflowUniqueName,
				Variables = [],
				Version = "1.0.0"
			}
		};

	private static string CreateKsuid()
	{
		const string alphabet = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
		const long epoch = 1_400_000_000;
		Span<byte> bytes = stackalloc byte[20];
		var timestamp = checked((uint)(DateTimeOffset.UtcNow.ToUnixTimeSeconds() - epoch));
		System.Buffers.Binary.BinaryPrimitives.WriteUInt32BigEndian(bytes, timestamp);
		RandomNumberGenerator.Fill(bytes[4..]);

		var value = new BigInteger(bytes, isUnsigned: true, isBigEndian: true);
		Span<char> encoded = stackalloc char[27];
		for (var index = encoded.Length - 1; index >= 0; index--)
		{
			value = BigInteger.DivRem(value, alphabet.Length, out var remainder);
			encoded[index] = alphabet[(int)remainder];
		}

		return new string(encoded);
	}

	private async Task TryCleanupAsync(
		string resource,
		Func<Task> cleanup,
		List<Exception> failures)
	{
		try
		{
			await cleanup();
		}
		catch (MerakiWorkflowsApiException exception) when (exception.StatusCode == 404)
		{
			TestOutputHelper.WriteLine($"Cleanup skipped because {resource} no longer exists.");
		}
		catch (Exception exception)
		{
			failures.Add(exception);
			TestOutputHelper.WriteLine($"Cleanup failed for {resource}: {exception}");
		}
	}
}
