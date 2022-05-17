using FluentAssertions;
using Meraki.Api.Data;
using Meraki.Api.Extensions;
using System.Net;
using Xunit.Abstractions;

namespace Meraki.Api.NewTest;

public class NetworkTests : MerakiClientUnitTest
{
	public NetworkTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
	{
	}

	[Fact]
	public async Task GetNetworks_Succeeds()
	{
		var networks = await TestMerakiClient.Organizations.Networks.GetOrganizationNetworksAllAsync(TestOrganizationId);
		networks.Should().NotBeNullOrEmpty();
	}

	[Fact]
	public async Task BasicCrud_Succeeds()
	{
		// Load the config


		//Set the test network name
		string testNetworkName = "Basic CRUD Test Network";
		string testAlternateNetworkName = "Altered Basic CRUD Test Network";

		// Check the network is not present
		var networks = await TestMerakiClient.Organizations.Networks.GetOrganizationNetworksAllAsync(TestOrganizationId);
		networks.Should().NotBeNull();
		networks.Should().NotContain(network => network.Name == testNetworkName, "because the test network should not be present to begin the test");

		// Create the new network settings


		//Create a valid network
		var createNetworkRequest = GetValidNetworkCreationRequest();
		var network = await CreateValidNetworkAsync();
		network.Should().NotBeNull();

		try
		{
			// Check the network can be retrieved and that its values are those set
			var retrievedNetwork = await TestMerakiClient.Networks.GetNetworkAsync(network.Id);
			var expectedNetwork = new Network()
			{
				OrganizationId = TestOrganizationId,
				Name = createNetworkRequest.Name,
				Notes = createNetworkRequest.Notes,
				TimeZone = createNetworkRequest.TimeZone!,
				ProductTypes = createNetworkRequest.ProductTypes,
				Tags = createNetworkRequest.Tags!,
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
			var networkUpdated = await TestMerakiClient.Networks.UpdateNetworkAsync
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
			var reretrievedNetwork = await TestMerakiClient.Networks.GetNetworkAsync(network.Id);
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
			await TestMerakiClient.Networks.DeleteNetworkAsync(network.Id);
		}

		// Check the network is not present

		var exception = await Assert.ThrowsAsync<Refit.ApiException>(() => TestMerakiClient.Networks.GetNetworkAsync(network.Id));
		exception.StatusCode.Should().Be(HttpStatusCode.NotFound);

	}
}