using Divergic.Logging.Xunit;
using Meraki.Api.Data;
using Meraki.Api.Extensions;
using Newtonsoft.Json;
using System.Net;
using Xunit.Abstractions;

namespace Meraki.Api.NewTest;

public class NetworkTests
{
	private readonly ICacheLogger _logger;

	public NetworkTests(ITestOutputHelper testOutputHelper)
	{
		_logger = testOutputHelper.BuildLogger();
	}

	[Fact]
	public async Task GetNetworks_Succeeds()
	{
		// Load the config
		var testConfig = JsonConvert.DeserializeObject<TestConfig>(
			await File.ReadAllTextAsync("../../../appsettings.json")
			);
		if (testConfig is null)
		{
			throw new InvalidDataException("API Config Data is empty");
		}
		var merakiClientOptions = new MerakiClientOptions
		{
			ApiKey = testConfig.ApiKey,
			ApiNode = testConfig.ApiNode
		};
		var merakiClient = new MerakiClient(merakiClientOptions);
		var networks = await merakiClient.Organizations.Networks.GetOrganizationNetworksAllAsync(testConfig.OrganizationId);
		Assert.True(networks.Any());
	}

	[Fact]
	public async Task BasicCrud_Succeeds()
	{
		// Load the config
		var testConfig = JsonConvert.DeserializeObject<TestConfig>(
			await File.ReadAllTextAsync("../../../appsettings.json")
			);
		if (testConfig is null)
		{
			throw new InvalidDataException("API Config Data is empty");
		}
		var merakiClientOptions = new MerakiClientOptions
		{
			ApiKey = testConfig.ApiKey,
			ApiNode = testConfig.ApiNode
		};
		var merakiClient = new MerakiClient(merakiClientOptions, _logger);

		//Set the test network name
		string testNetworkName = "Basic CRUD Test Network";
		string testAlternateNetworkName = "Altered Basic CRUD Test Network";

		// Check the network is not present
		var networks = await merakiClient.Organizations.Networks.GetOrganizationNetworksAllAsync(testConfig.OrganizationId);
		if (networks.Any(network => network.Name == testNetworkName))
		{
			throw new InvalidOperationException("Test network already exists in test organisation");
		}

		// Create the new network settings
		var createNetworkRequest = new NetworkCreationRequest
		{
			Name = testNetworkName,
			Notes = "Test notes for unit test network.",
			TimeZone = "Europe/London",
			ProductTypes = new() { ProductType.Appliance, ProductType.Camera, ProductType.CellularGateway, ProductType.Environmental,
			 ProductType.Switch, ProductType.SystemsManager, ProductType.Wireless },
			Tags = new() { "Test Tag 1", "Test Tag 2", "Test Tag 3" }
		};

		//Create a valid network
		var network = await merakiClient.Organizations.Networks.CreateOrganizationNetworkAsync
			(
				testConfig.OrganizationId,
				createNetworkRequest
			);
		try
		{
			// Check the network can be retrieved and that its values are those set
			var retrievedNetwork = await merakiClient.Networks.GetNetworkAsync(network.Id);
			if (retrievedNetwork.Name != testNetworkName)
			{
				throw new InvalidDataException("Network name not retrieved correctly.");
			}

			// Change the network Name
			var networkUpdated = await merakiClient.Networks.UpdateNetworkAsync
				(
				network.Id,
				new NetworkUpdateRequest
				{
					Name = testAlternateNetworkName,
				}
				);
			//Check that the name has changed in the returned network and 
			Assert.Equal(testAlternateNetworkName, networkUpdated.Name);
			Assert.Equal(retrievedNetwork.Notes, networkUpdated.Notes);
			Assert.Equal(retrievedNetwork.TimeZone, networkUpdated.TimeZone);
			Assert.Equal(retrievedNetwork.ProductTypes, networkUpdated.ProductTypes);
			Assert.Equal(retrievedNetwork.Tags, networkUpdated.Tags);

			// Retrieve the network again and check the Name has changed
			var reretrievedNetwork = await merakiClient.Networks.GetNetworkAsync(network.Id);

			if (reretrievedNetwork.Name == testNetworkName)
			{
				throw new InvalidOperationException("Network name did not change");
			}
			else if (reretrievedNetwork.Name != testAlternateNetworkName)
			{
				throw new InvalidOperationException($"Network name update failed - Network name is {reretrievedNetwork.Name}");
			}
		}
		finally
		{
			// Delete the network
			await merakiClient.Networks.DeleteNetworkAsync(network.Id);
		}

		// Check the network is not present
		var exception = await Assert.ThrowsAsync<Refit.ApiException>(() => merakiClient.Networks.GetNetworkAsync(network.Id));
		Assert.Equal(HttpStatusCode.NotFound, exception.StatusCode);

	}
}