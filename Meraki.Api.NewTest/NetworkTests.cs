using Divergic.Logging.Xunit;
using FluentAssertions;
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
		networks.Should().NotBeNullOrEmpty();
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
		networks.Should().NotBeNull();
		networks.Should().NotContain(network => network.Name == testNetworkName, "because the test network should not be present to begin the test");

		// Create the new network settings
		var createNetworkRequest = new NetworkCreationRequest
		{
			Name = testNetworkName,
			Notes = "Test notes for unit test network.",
			TimeZone = "Europe/London",
			ProductTypes = new() {
				ProductType.Appliance,
				ProductType.Camera,
				ProductType.CellularGateway,
				ProductType.Switch,
				ProductType.Wireless },
			Tags = new() { "TestTag1", "TestTag2", "TestTag3" }
		};

		//Create a valid network
		var network = await merakiClient.Organizations.Networks.CreateOrganizationNetworkAsync
			(
				testConfig.OrganizationId,
				createNetworkRequest
			);
		network.Should().NotBeNull();

		try
		{
			// Check the network can be retrieved and that its values are those set
			var retrievedNetwork = await merakiClient.Networks.GetNetworkAsync(network.Id);
			var expectedNetwork = new Network()
			{
				OrganizationId = testConfig.OrganizationId,
				Name = createNetworkRequest.Name,
				Notes = createNetworkRequest.Notes,
				TimeZone = createNetworkRequest.TimeZone,
				ProductTypes = createNetworkRequest.ProductTypes,
				Tags = createNetworkRequest.Tags,
				Id = network.Id,
				IsBoundToConfigTemplate = false
			};
			retrievedNetwork.Should()
				.NotBeNull()
				.And
				.BeEquivalentTo(
					expectedNetwork,
					options => options.Excluding(n => n.Url)
				);

			// Change the network Name
			var networkUpdated = await merakiClient.Networks.UpdateNetworkAsync
				(
				network.Id,
				new NetworkUpdateRequest
				{
					Name = testAlternateNetworkName,
				}
				);

			//Check that the name has changed in the returned network and ...?
			expectedNetwork.Name = testAlternateNetworkName;
			networkUpdated.Should()
				.NotBeNull()
				.And
				.BeEquivalentTo(
					expectedNetwork,
					options => options.Excluding(n => n.Url)
				);

			// Retrieve the network again and check the Name has changed
			var reretrievedNetwork = await merakiClient.Networks.GetNetworkAsync(network.Id);
			reretrievedNetwork.Should()
				.NotBeNull()
				.And
				.BeEquivalentTo(
					networkUpdated,
					options => options.Excluding(n => n.Url)
				);
		}
		finally
		{
			// Delete the network
			await merakiClient.Networks.DeleteNetworkAsync(network.Id);
		}

		// Check the network is not present

		var exception = await Assert.ThrowsAsync<Refit.ApiException>(() => merakiClient.Networks.GetNetworkAsync(network.Id));
		exception.StatusCode.Should().Be(HttpStatusCode.NotFound);

	}
}