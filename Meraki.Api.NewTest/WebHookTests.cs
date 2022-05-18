using FluentAssertions;
using Meraki.Api.Data;
using Meraki.Api.Extensions;
using System.Net;
using Xunit.Abstractions;

namespace Meraki.Api.NewTest;

public class WebHookTests : MerakiClientUnitTest
{
	public WebHookTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
	{
	}

	[Fact]
	public async Task WebHookHttpServersCrud_Succeeds()
	{
		// Create a test network object
		var createNetworkRequest = GetValidNetworkCreationRequest();
		// Make sure it doesn't already exist
		var networks = await TestMerakiClient.Organizations.Networks.GetOrganizationNetworksAllAsync(TestOrganizationId);
		networks.Should().NotBeNull();
		networks.Should().NotContain(network => network.Name == createNetworkRequest.Name, "because the test network should not be present to begin the test");
		//Create the test network
		var network = await CreateValidNetworkAsync();
		network.Should().NotBeNull();

		try
		{
			// Set up Webhook Http Server create request
			var testWebHookHttpServerRequest = new WebhookHttpServer()
			{
				Name = "Test Webhook HTTP Server",
				SharedSecret = "testsharedsecret",
				// This must be a valid https URL, it is test resolved before creation
				Url = "https://webhook.site",
			};

			// Create the webhook http server
			var testWebHookHttpServer = await TestMerakiClient.Networks.WebHooks.HttpServers.CreateNetworkWebhooksHttpServerAsync(network.Id, testWebHookHttpServerRequest);
			testWebHookHttpServer.Should().NotBeNull();

			// Request all WebHookHttpServers and check it's there
			var testWebHookHttpServers = await TestMerakiClient.Networks.WebHooks.HttpServers.GetNetworkWebhooksHttpServersAsync(network.Id);
			testWebHookHttpServers.Should().Contain(testWebHookHttpServer => testWebHookHttpServer.Name == testWebHookHttpServerRequest.Name);

			// Create a comparior WebHookHttpSever object
			var expectedWebHookHttpServer = new WebhookHttpServer()
			{
				// Don't set SharedSecret in the comparitor object because it won't come back
				Name = testWebHookHttpServerRequest.Name,
				NetworkId = network.Id,
				// The new WebHookHttpSever Id is only returned after creation so we have to get it from there
				Id = testWebHookHttpServer.Id,
				Url = testWebHookHttpServerRequest.Url,
			};

			// Get and check the details
			var retrievedTestWebHookHttpServer = await TestMerakiClient.Networks.WebHooks.HttpServers.GetNetworkWebhooksHttpServerAsync(network.Id, testWebHookHttpServer.Id);
			retrievedTestWebHookHttpServer.Should().NotBeNull();
			retrievedTestWebHookHttpServer.Should()
				.NotBeNull()
				.And
				.BeEquivalentTo(
					expectedWebHookHttpServer,
					// Exclude the payload template because we didn't set it
					options => options.Excluding(n => n.PayloadTemplate)
				);

			// update the webhook http server
			var updateWebHookHttpServerRequest = new WebhookHttpServer()
			{
				// Only providing the item we want to change
				Name = "Test Webhook HTTP Server - Updated",
			};
			var updatedTestWebHookHttpServer = await TestMerakiClient.Networks.WebHooks.HttpServers.UpdateNetworkWebhooksHttpServerAsync(network.Id, testWebHookHttpServer.Id, updateWebHookHttpServerRequest);
			updatedTestWebHookHttpServer.Should().NotBeNull();

			// Get and recheck the details
			expectedWebHookHttpServer.Name = "Test Webhook HTTP Server - Updated";
			updatedTestWebHookHttpServer.Should()
				.BeEquivalentTo(
					expectedWebHookHttpServer,
					options => options.Excluding(n => n.PayloadTemplate)
					);

			// Delete the webhook http server
			await TestMerakiClient.Networks.WebHooks.HttpServers.DeleteNetworkWebhooksHttpServerAsync(network.Id, testWebHookHttpServer.Id);

			// Check the webhook http server is gone
			var webhookhttpserverexception = await Assert.ThrowsAsync<Refit.ApiException>(() => TestMerakiClient.Networks.WebHooks.HttpServers.GetNetworkWebhooksHttpServerAsync(network.Id, testWebHookHttpServer.Id));
			webhookhttpserverexception.StatusCode.Should().Be(HttpStatusCode.NotFound);

		}
		finally
		{
			// Delete the network
			await TestMerakiClient.Networks.DeleteNetworkAsync(network.Id);
		}

		// Make sure that the network is gone
		var exception = await Assert.ThrowsAsync<Refit.ApiException>(() => TestMerakiClient.Networks.GetNetworkAsync(network.Id));
		exception.StatusCode.Should().Be(HttpStatusCode.NotFound);

	}
	[Fact]
	public async Task WebHookPayloadTemplatesCrud_Succeeds()
	{
		// Create a test network object
		var createNetworkRequest = GetValidNetworkCreationRequest();
		// Make sure it doesn't already exist
		var networks = await TestMerakiClient.Organizations.Networks.GetOrganizationNetworksAllAsync(TestOrganizationId);
		networks.Should().NotBeNull();
		networks.Should().NotContain(network => network.Name == createNetworkRequest.Name, "because the test network should not be present to begin the test");
		//Create the test network
		var network = await CreateValidNetworkAsync();
		network.Should().NotBeNull();

		try
		{
			//Create a payload template
			var testCreateWebhookPayloadTemplateRequest = new PayloadTemplate()
			{
				Name = "Test Payload Template",
				Body = "{\"event_type\":\"{{alertTypeId}}\",\"client_payload\":{\"text\":\"{{alertData}}\"}}",
				// TODO Find out headers format and how files should be used
				//Headers = new()
				//{
				//	{"Content-Type","application/json" },
				//}
			};
			//Crete the payload template
			var testCreateWebhookPayloadTemplate = await TestMerakiClient
				.Networks
				.WebHooks
				.PayloadTemplates
				.CreateNetworkWebhooksPayloadTemplateAsync(network.Id, testCreateWebhookPayloadTemplateRequest);
			testCreateWebhookPayloadTemplate.Should().NotBeNull();

			//Retrieve all payload templates
			var retrieveWebhookPayloadTemplates = await TestMerakiClient.Networks.WebHooks.PayloadTemplates.GetNetworkWebhooksPayloadTemplatesAsync(network.Id);
			retrieveWebhookPayloadTemplates.Should().NotBeNull();

			//Our new payload template should be in there
			retrieveWebhookPayloadTemplates.Should().Contain(payloadTemplate => payloadTemplate.Name == testCreateWebhookPayloadTemplateRequest.Name);

			//Create an http webhook server that uses the template
			var testWebHookHttpServerRequest = new WebhookHttpServer()
			{
				Name = "Test Webhook HTTP Server",
				SharedSecret = "testsharedsecret",
				// This must be a valid https URL, it is test resolved before creation
				Url = "https://webhook.site",
				PayloadTemplate = new()
				{
					PayloadTemplateId = testCreateWebhookPayloadTemplate.PayloadTemplateId,
					Name = testCreateWebhookPayloadTemplateRequest.Name,
				}
			};
			var testWebHookHttpServer = await TestMerakiClient.Networks.WebHooks.HttpServers.CreateNetworkWebhooksHttpServerAsync(network.Id, testWebHookHttpServerRequest);
			testWebHookHttpServer.Should().NotBeNull();

			// Create an alternate name for the template
			var testPayloadAlternateName = "Test Payload Template Updated";

			//Modify the the payload template
			var payloadTemplateUpdated = await TestMerakiClient.Networks.WebHooks.PayloadTemplates.UpdateNetworkWebhooksPayloadTemplateAsync
				(
				network.Id,
				testCreateWebhookPayloadTemplate.PayloadTemplateId!,
				new PayloadTemplate
				{
					Name = testPayloadAlternateName,
				}
				);

			// Modify the name in our original request then compare it against what we get back
			testCreateWebhookPayloadTemplateRequest.Name = payloadTemplateUpdated.Name;
			payloadTemplateUpdated.Should()
				.BeEquivalentTo(
					testCreateWebhookPayloadTemplateRequest,
					options => options.Excluding(p => p.PayloadTemplateId).Excluding(p => p.Type).Excluding(p => p.Headers));

			//Delete the http webhook server and double check it's gone
			await TestMerakiClient.Networks.WebHooks.HttpServers.DeleteNetworkWebhooksHttpServerAsync(network.Id, testWebHookHttpServer.Id);
			var webhookhttpserverexception = await Assert.ThrowsAsync<Refit.ApiException>(() => TestMerakiClient.Networks.WebHooks.HttpServers.GetNetworkWebhooksHttpServerAsync(network.Id, testWebHookHttpServer.Id));
			webhookhttpserverexception.StatusCode.Should().Be(HttpStatusCode.NotFound);

			//Delete the payload template
			await TestMerakiClient
				.Networks
				.WebHooks
				.PayloadTemplates
				.DeleteNetworkWebhooksPayloadTemplateAsync(network.Id, testCreateWebhookPayloadTemplate.PayloadTemplateId!);

			//Check that the payload template is gone
			var webhookpayloadtemplateexception = await Assert.ThrowsAsync<Refit.ApiException>(() => TestMerakiClient
			.Networks
			.WebHooks
			.PayloadTemplates
			.DeleteNetworkWebhooksPayloadTemplateAsync(network.Id, testCreateWebhookPayloadTemplate.PayloadTemplateId!));
			webhookhttpserverexception.StatusCode.Should().Be(HttpStatusCode.NotFound);
		}
		finally
		{
			// Delete the network
			await TestMerakiClient.Networks.DeleteNetworkAsync(network.Id);
		}

		// Make sure that the network is gone
		var exception = await Assert.ThrowsAsync<Refit.ApiException>(() => TestMerakiClient.Networks.GetNetworkAsync(network.Id));
		exception.StatusCode.Should().Be(HttpStatusCode.NotFound);

	}
}