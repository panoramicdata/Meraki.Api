using Meraki.Api.Extensions;
using Newtonsoft.Json;

namespace Meraki.Api.NewTest;

public class NetworkTests
{
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
		var merakiClient = new MerakiClient(merakiClientOptions);

		// Check the network is not present

		// Create a valid network

		// Check the network can be retrieved and that its values are those set

		// Change the network Name

		// Retrieve the network again and check the Name has changed

		// Delete the network

		// Check the network is not present
	}
}