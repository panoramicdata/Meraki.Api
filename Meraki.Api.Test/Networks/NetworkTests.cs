using Newtonsoft.Json;
using System.Net;

namespace Meraki.Api.Test.Networks;

public class NetworkTests(ITestOutputHelper testOutputHelper) : MerakiClientTest(testOutputHelper)
{
	[Fact]
	public async Task Network_Crud_Succeeds()
	{
		//Create, modify and delete a test network
		var testNetworkName = "Basic CRUD Test Network";

		//Create the test network
		var network = await CreateTestNetworkAsync();

		//Make sure we've got something back
		_ = network.Should().NotBeNull();

		// TODO Get a list of all networks to check it's there

		try
		{
			// Check the network can be retrieved and that its values are those we set earlier
			// Get the network details using the network id
			var retrievedNetwork = await TestMerakiClient
				.Networks
				.GetNetworkAsync(
					network.Id,
					cancellationToken: CancellationToken);

			// Create a comparison network object using the data we sent at create
			var expectedNetwork = new Network
			{
				OrganizationId = Configuration.TestOrganizationId,
				Name = network.Name,
				Notes = network.Notes,
				TimeZone = network.TimeZone,
				ProductTypes = network.ProductTypes,
				Tags = network.Tags,
				Id = network.Id,
				IsBoundToConfigTemplate = false
			};
			// Make sure the two networks are the same (exclude the Url field, we can't set it and it's different with each pull down)
			_ = retrievedNetwork.Should()
				.NotBeNull()
				.And
				.BeEquivalentTo(
					expectedNetwork,
					options => options.Excluding(n => n.Url)
				);

			//Set the alternate name we're going to use to modify the network
			var testAlternateNetworkName = "Altered Basic CRUD Test Network";

			// Change the network Name
			var networkUpdated = await TestMerakiClient
				.Networks
				.UpdateNetworkAsync(
					network.Id,
					new NetworkUpdateRequest
					{
						Name = testAlternateNetworkName,
					},
					cancellationToken: CancellationToken);

			// Check that the name has changed in the return data and that the remaining settings stay the same
			// Change the expected name to the alternate name
			expectedNetwork.Name = testAlternateNetworkName;
			// Check that the expected network data now matches what we got back from the update request
			_ = networkUpdated.Should()
				.NotBeNull()
				.And
				.BeEquivalentTo(
					expectedNetwork,
					options => options.Excluding(n => n.Url)
				);

			// Then we pull the network once more to make sure the pulled data matches the response from the update
			var reretrievedNetwork = await TestMerakiClient
				.Networks
				.GetNetworkAsync(
					network.Id,
					cancellationToken: CancellationToken);
			_ = reretrievedNetwork.Should()
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
			await RemoveNetworkAsync(network.Id);
		}

		// Make sure that the network is gone
		var exception = await Assert.ThrowsAsync<ApiException>(
			() => TestMerakiClient
				.Networks
				.GetNetworkAsync(
					network.Id,
					cancellationToken: CancellationToken));
		_ = exception.StatusCode.Should().Be(HttpStatusCode.NotFound);

	}

	[Fact]
	public async Task GetNetworkClientsAll_Succeeds()
	{
		TestMerakiClient.Statistics.Reset();
		var networks = await TestMerakiClient
			.Organizations
			.Networks
			.GetOrganizationNetworksAllAsync(
				Configuration.TestOrganizationId,
				cancellationToken: CancellationToken
			);
		var network = networks[0];
		var clients = await TestMerakiClient
			.Networks
			.Clients
			.GetNetworkClientsAllAsync(
				network.Id,
				cancellationToken: CancellationToken);
		_ = clients.Should().NotBeNull();
	}

	[Fact]
	public void Deserialize_ShouldFail_WhenZoneIdIsTooLarge()
	{
		// Arrange: JSON with an extremely large number for zoneId
		var json = """
			{
			  "startTs": "2025-03-10T08:00:00Z",
			    "endTs": "2025-03-10T10:00:00Z",
			    "zoneId": 999999999999999999999999999,
			    "entrances": 120,
			    "averageCount": 15.7
			}
			""";

		// Act & Assert: Expect a JsonSerializationException due to number overflow
		var cameraOverview = JsonConvert.DeserializeObject<CameraOverview>(json);
	}
}
