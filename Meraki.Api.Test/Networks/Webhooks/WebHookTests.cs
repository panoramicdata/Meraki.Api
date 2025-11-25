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
			// Set up Webhook Http Server create request
			var testWebhookHttpServerRequest = new WebhookHttpServer
			{
				Name = "Test Webhook HTTP Server",
				SharedSecret = "testsharedsecret",
				// This must be a valid https URL, it is test resolved before creation
				Url = "https://webhook.site",
			};

			// Create the webhook http server
			var testWebhookHttpServer = await TestMerakiClient
				.Networks
				.Webhooks
				.HttpServers
				.CreateNetworkWebhooksHttpServerAsync(
					network.Id,
					testWebhookHttpServerRequest,
					cancellationToken: CancellationToken);
			_ = testWebhookHttpServer.Should().NotBeNull();

			// Request all WebhookHttpServers and check it's there
			var testWebhookHttpServers = await TestMerakiClient
				.Networks
				.Webhooks
				.HttpServers
				.GetNetworkWebhooksHttpServersAsync(
					network.Id,
					cancellationToken: CancellationToken);
			_ = testWebhookHttpServers.Should().Contain(testWebhookHttpServer => testWebhookHttpServer.Name == testWebhookHttpServerRequest.Name);

			// Create a comparison WebhookHttpSever object
			var expectedWebhookHttpServer = new WebhookHttpServer
			{
				// Don't set SharedSecret in the comparison object because it won't come back
				Name = testWebhookHttpServerRequest.Name,
				NetworkId = network.Id,
				// The new WebhookHttpSever Id is only returned after creation so we have to get it from there
				Id = testWebhookHttpServer.Id,
				Url = testWebhookHttpServerRequest.Url,
			};

			// Get and check the details
			var retrievedTestWebhookHttpServer = await TestMerakiClient
				.Networks
				.Webhooks
				.HttpServers
				.GetNetworkWebhooksHttpServerAsync(
					network.Id,
					testWebhookHttpServer.Id,
					cancellationToken: CancellationToken);
			_ = retrievedTestWebhookHttpServer.Should().NotBeNull();
			_ = retrievedTestWebhookHttpServer.Should()
				.NotBeNull()
				.And
				.BeEquivalentTo(
					expectedWebhookHttpServer,
					// Exclude the payload template because we didn't set it
					options => options.Excluding(n => n.PayloadTemplate)
				);

			// update the webhook http server
			var updateWebhookHttpServerRequest = new WebhookHttpServer
			{
				// Only providing the item we want to change
				Name = "Test Webhook HTTP Server - Updated",
			};
			var updatedTestWebhookHttpServer = await TestMerakiClient
				.Networks
				.Webhooks
				.HttpServers
				.UpdateNetworkWebhooksHttpServerAsync(
					network.Id,
					testWebhookHttpServer.Id,
					updateWebhookHttpServerRequest,
					cancellationToken: CancellationToken);

			_ = updatedTestWebhookHttpServer.Should().NotBeNull();

			// Get and recheck the details
			expectedWebhookHttpServer.Name = "Test Webhook HTTP Server - Updated";
			_ = updatedTestWebhookHttpServer.Should()
				.BeEquivalentTo(
					expectedWebhookHttpServer,
					options => options.Excluding(n => n.PayloadTemplate)
					);

			// Delete the webhook http server
			await TestMerakiClient
				.Networks
				.Webhooks
				.HttpServers
				.DeleteNetworkWebhooksHttpServerAsync(
					network.Id,
					testWebhookHttpServer.Id,
					cancellationToken: CancellationToken);

			// Check the webhook http server is gone
			var webhookhttpserverGetAct = () => TestMerakiClient
				.Networks
				.Webhooks
				.HttpServers
				.GetNetworkWebhooksHttpServerAsync(
					network.Id,
					testWebhookHttpServer.Id,
					cancellationToken: CancellationToken);

			_ = await webhookhttpserverGetAct
				.Should()
				.ThrowExactlyAsync<ApiException>()
				.Where(ex => ex.StatusCode == HttpStatusCode.NotFound);

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

	[Fact]
	public async Task NetworkWebhookPayloadTemplates_Crud_Succeeds()
	{
		var network = await CreateTestNetworkAsync();
		_ = network.Should().NotBeNull();

		try
		{
			// Remove any existing payload templates
			var existingPayloadTemplates = await TestMerakiClient
				.Networks
				.Webhooks
				.PayloadTemplates
				.GetNetworkWebhooksPayloadTemplatesAsync(
					network.Id,
					cancellationToken: CancellationToken);

			const string testPayloadTemplateNamePrefix = "Test Payload Template";

			var oldTemplates = existingPayloadTemplates
				.Where(t => t.Name.StartsWith(testPayloadTemplateNamePrefix, StringComparison.Ordinal))
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

			// Create a payload template
			var testPayloadTemplateName = $"{testPayloadTemplateNamePrefix} {DateTime.UtcNow:yyyy-MM-dd HH:mm:ss}";
			var testCreateWebhookPayloadTemplateRequest = new PayloadTemplate
			{
				Name = testPayloadTemplateName,
				Body = """
				{"event_type":"{{alertTypeId}}","client_payload":{"text":"{{alertData}}"}}
				""",
				Headers = [],
			};

			var testCreateWebhookPayloadTemplate = await TestMerakiClient
				.Networks
				.Webhooks
				.PayloadTemplates
				.CreateNetworkWebhooksPayloadTemplateAsync(
					network.Id,
					testCreateWebhookPayloadTemplateRequest,
					cancellationToken: CancellationToken
				);

			_ = testCreateWebhookPayloadTemplate.Should().NotBeNull();

			// Retrieve all payload templates
			var retrieveWebhookPayloadTemplates = await TestMerakiClient
				.Networks
				.Webhooks
				.PayloadTemplates
				.GetNetworkWebhooksPayloadTemplatesAsync(
					network.Id,
					cancellationToken: CancellationToken);

			_ = retrieveWebhookPayloadTemplates.Should().NotBeNull();

			// Our new payload template should be in there
			_ = retrieveWebhookPayloadTemplates
				.Should()
				.Contain(payloadTemplate => payloadTemplate.Name == testCreateWebhookPayloadTemplateRequest.Name);

			// Create an http webhook server that uses the template
			var testWebhookHttpServerRequest = new WebhookHttpServer
			{
				Name = "Test Webhook HTTP Server",
				SharedSecret = "testsharedsecret",
				// This must be a valid https URL, it is test resolved before creation
				Url = "https://webhook.site",
				PayloadTemplate = new()
				{
					Id = testCreateWebhookPayloadTemplate.PayloadTemplateId!,
					Name = testPayloadTemplateName,
				}
			};
			var testWebhookHttpServer = await TestMerakiClient
				.Networks
				.Webhooks
				.HttpServers
				.CreateNetworkWebhooksHttpServerAsync(
					network.Id,
					testWebhookHttpServerRequest,
					cancellationToken: CancellationToken);
			_ = testWebhookHttpServer.Should().NotBeNull();

			// Create an alternate name for the template
			var testPayloadAlternateName = testPayloadTemplateName + " Updated";

			// Modify the payload template
			var payloadTemplateUpdated = await TestMerakiClient
				.Networks
				.Webhooks
				.PayloadTemplates
				.UpdateNetworkWebhooksPayloadTemplateAsync
				(
					network.Id,
					testCreateWebhookPayloadTemplate.PayloadTemplateId!,
					new PayloadTemplate
					{
						Name = testPayloadAlternateName,
					},
					cancellationToken: CancellationToken
				);

			// Modify the name in our original request then compare it against what we get back
			testCreateWebhookPayloadTemplateRequest.Name = payloadTemplateUpdated.Name;
			_ = payloadTemplateUpdated.Should()
				.BeEquivalentTo(
					testCreateWebhookPayloadTemplateRequest,
					options => options
						.Excluding(p => p.PayloadTemplateId)
						.Excluding(p => p.Type)
						.Excluding(p => p.Headers)
						.Excluding(p => p.Sharing)
						);

			// Delete the http webhook server and double check it's gone
			await TestMerakiClient
				.Networks
				.Webhooks
				.HttpServers
				.DeleteNetworkWebhooksHttpServerAsync(
					network.Id,
					testWebhookHttpServer.Id,
					cancellationToken: CancellationToken);

			var webhookServerGetAct = () => TestMerakiClient
				.Networks
				.Webhooks
				.HttpServers
				.GetNetworkWebhooksHttpServerAsync(
					network.Id,
					testWebhookHttpServer.Id,
					cancellationToken: CancellationToken);

			_ = await webhookServerGetAct
				.Should()
				.ThrowExactlyAsync<ApiException>()
				.Where(ex => ex.StatusCode == HttpStatusCode.NotFound);

			// Delete the payload template
			await TestMerakiClient
				.Networks
				.Webhooks
				.PayloadTemplates
				.DeleteNetworkWebhooksPayloadTemplateAsync(
					network.Id,
					testCreateWebhookPayloadTemplate.PayloadTemplateId!,
					cancellationToken: CancellationToken);

			// Check that the payload template is gone
			var payloadTemplateGetAct = () => TestMerakiClient
				.Networks
				.Webhooks
				.PayloadTemplates
				.GetNetworkWebhooksPayloadTemplateAsync(
					network.Id,
					testCreateWebhookPayloadTemplate.PayloadTemplateId!,
					cancellationToken: CancellationToken);

			_ = await payloadTemplateGetAct
				.Should()
				.ThrowExactlyAsync<ApiException>()
				.Where(ex => ex.StatusCode == HttpStatusCode.NotFound);
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

	[Fact]
	public async Task OrganizationWebhookPayloadTemplates_Crud_Succeeds()
	{
		try
		{
			// Remove any existing payload templates
			var existingPayloadTemplates = await TestMerakiClient
				.Organizations
				.Webhooks
				.PayloadTemplates
				.GetOrganizationWebhooksPayloadTemplatesAsync(
					Configuration.TestOrganizationId,
					cancellationToken: CancellationToken);

			const string testPayloadTemplateNamePrefix = "Test Payload Template";

			var oldTemplates = existingPayloadTemplates
				.Where(t => t.Name.StartsWith(testPayloadTemplateNamePrefix, StringComparison.Ordinal))
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

			// Create a payload template
			var testPayloadTemplateName = $"{testPayloadTemplateNamePrefix} {DateTime.UtcNow:yyyy-MM-dd HH:mm:ss}";
			var testCreateWebhookPayloadTemplateRequest = new PayloadTemplate
			{
				Name = testPayloadTemplateName,
				Body = """
				{"event_type":"{{alertTypeId}}","client_payload":{"text":"{{alertData}}"}}
				""",
				Headers = [],
			};

			var testCreateWebhookPayloadTemplate = await TestMerakiClient
				.Organizations
				.Webhooks
				.PayloadTemplates
				.CreateOrganizationWebhooksPayloadTemplatesAsync(
					Configuration.TestOrganizationId,
					testCreateWebhookPayloadTemplateRequest,
					cancellationToken: CancellationToken
				);

			_ = testCreateWebhookPayloadTemplate.Should().NotBeNull();

			// Retrieve all payload templates
			var retrieveWebhookPayloadTemplates = await TestMerakiClient
				.Organizations
				.Webhooks
				.PayloadTemplates
				.GetOrganizationWebhooksPayloadTemplatesAsync(
					Configuration.TestOrganizationId,
					cancellationToken: CancellationToken);

			_ = retrieveWebhookPayloadTemplates.Should().NotBeNull();

			// Our new payload template should be in there
			_ = retrieveWebhookPayloadTemplates
				.Should()
				.Contain(payloadTemplate => payloadTemplate.Name == testCreateWebhookPayloadTemplateRequest.Name);

			// Create an http webhook server that uses the template
			var testWebhookHttpServerRequest = new WebhookHttpServer
			{
				Name = "Test Webhook HTTP Server",
				SharedSecret = "testsharedsecret",
				// This must be a valid https URL, it is test resolved before creation
				Url = "https://webhook.site",
				PayloadTemplate = new()
				{
					Id = testCreateWebhookPayloadTemplate.PayloadTemplateId!,
					Name = testPayloadTemplateName,
				}
			};
			var testWebhookHttpServer = await TestMerakiClient
				.Organizations
				.Webhooks
				.HttpServers
				.CreateOrganizationWebhooksHttpServerAsync(
					Configuration.TestOrganizationId,
					testWebhookHttpServerRequest,
					cancellationToken: CancellationToken);
			_ = testWebhookHttpServer.Should().NotBeNull();

			// Create an alternate name for the template
			var testPayloadAlternateName = testPayloadTemplateName + " Updated";

			// Modify the payload template
			var payloadTemplateUpdated = await TestMerakiClient
				.Organizations
				.Webhooks
				.PayloadTemplates
				.UpdateOrganizationWebhooksPayloadTemplateAsync
				(
					Configuration.TestOrganizationId,
					testCreateWebhookPayloadTemplate.PayloadTemplateId!,
					new PayloadTemplate
					{
						Name = testPayloadAlternateName,
					},
					cancellationToken: CancellationToken
				);

			// Modify the name in our original request then compare it against what we get back
			testCreateWebhookPayloadTemplateRequest.Name = payloadTemplateUpdated.Name;
			_ = payloadTemplateUpdated.Should()
				.BeEquivalentTo(
					testCreateWebhookPayloadTemplateRequest,
					options => options
						.Excluding(p => p.PayloadTemplateId)
						.Excluding(p => p.Type)
						.Excluding(p => p.Headers)
						.Excluding(p => p.Sharing)
						);

			// Delete the http webhook server and double check it's gone
			await TestMerakiClient
				.Organizations
				.Webhooks
				.HttpServers
				.DeleteOrganizationWebhooksHttpServerAsync(
					Configuration.TestOrganizationId,
					testWebhookHttpServer.Id,
					cancellationToken: CancellationToken
				);

			var webhookServerGetAct = () => TestMerakiClient
				.Organizations
				.Webhooks
				.HttpServers
				.GetOrganizationWebhooksHttpServerAsync(
					Configuration.TestOrganizationId,
					testWebhookHttpServer.Id,
					cancellationToken: CancellationToken);

			_ = await webhookServerGetAct
				.Should()
				.ThrowExactlyAsync<ApiException>()
				.Where(ex => ex.StatusCode == HttpStatusCode.NotFound);

			// Delete the payload template
			await TestMerakiClient
				.Organizations
				.Webhooks
				.PayloadTemplates
				.DeleteOrganizationWebhooksPayloadTemplateAsync(
					Configuration.TestOrganizationId,
					testCreateWebhookPayloadTemplate.PayloadTemplateId!,
					cancellationToken: CancellationToken
				);

			// Check that the payload template is gone
			var payloadTemplateGetAct = () => TestMerakiClient
				.Organizations
				.Webhooks
				.PayloadTemplates
				.GetOrganizationWebhooksPayloadTemplateAsync(
					Configuration.TestOrganizationId,
					testCreateWebhookPayloadTemplate.PayloadTemplateId!,
					cancellationToken: CancellationToken);

			_ = await payloadTemplateGetAct
				.Should()
				.ThrowExactlyAsync<ApiException>()
				.Where(ex => ex.StatusCode == HttpStatusCode.NotFound);
		}
		catch (Exception e)
		{
			TestOutputHelper.WriteLine($"OrganizationWebhookPayloadTemplates_Crud_Succeeds failed: {e.Message}");
			throw;
		}
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
