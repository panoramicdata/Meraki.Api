using System.Net;

namespace Meraki.Api.Test.Switch.Routing.Interfaces;

public class Tests(ITestOutputHelper testOutputHelper) : MerakiClientTest(testOutputHelper)
{
	[Fact]
	public async Task SwitchRoutingInterface_Crud_Succeeds()
	{
		// Create a routing interface on our test switch

		// Set up the routing interface object to be created
		// InterfaceIp is required for a create, Subnet and DefaultGateway are required for InterfaceIp to be accepted
		var createSwitchRoutingInterfaceRequest = new RoutingInterfaceCreateRequest
		{
			Name = "Test Routing Interface",
			VlanId = 12,
			DefaultGateway = "192.168.1.1",
			InterfaceIp = "192.168.1.2",
			Subnet = "192.168.1.0/24"
		};

		var createSwitchRoutingInterface = await TestMerakiClient
			.Switch
			.Routing
			.Interfaces
			.CreateDeviceSwitchRoutingInterfaceAsync(
				Configuration.TestSwitchSerial,
				createSwitchRoutingInterfaceRequest,
				cancellationToken: CancellationToken);
		_ = createSwitchRoutingInterface.Should().NotBeNull();

		// Get all routing interfaces from the switch and see that it's there
		var getSwitchRoutingInterfaces = await TestMerakiClient
			.Switch
			.Routing
			.Interfaces
			.GetDeviceSwitchRoutingInterfacesAsync(
				Configuration.TestSwitchSerial,
				cancellationToken: CancellationToken);
		_ = getSwitchRoutingInterfaces.Should().Contain(getSwitchRoutingInterfaces => getSwitchRoutingInterfaces.Name == createSwitchRoutingInterface.Name);

		// Make a change to the interface
		// TODO - Ipv6 settings are accepted without error on both update and create requests but not stored or retrievable, need to find out why.
		// TODO - OSPF settings are returned when they have not been set even though they default to null. Check this is Meraki and not us doing this.

		var updateSwitchRoutingInterfaceRequest = new RoutingInterfaceUpdateRequest
		{
			Name = "Test Routing Interface Renamed",
			// VlanId = 12,
			// TODO - DefaultGateway added to PUT in v1.16. Required for creation and trying change gives an error from the API. Consider removing from the update model?
			// DefaultGateway = "192.168.1.1",
			// InterfaceIp = "192.168.1.2",
			// Subnet = "192.168.1.0/24",
			// Create some Ipv6 settings
			Ipv6 = new RoutingInterfaceIpv6
			{
				AssignmentMode = AssignmentMode.Static,
				Address = "1:2:3:4::1",
				Prefix = "1:2:3:4::/48",
				Gateway = "1:2:3:4::2"
			}
		};
		var updatedSwitchRoutingInterface = await TestMerakiClient
			.Switch
			.Routing
			.Interfaces
			.UpdateDeviceSwitchRoutingInterfaceAsync(
				Configuration.TestSwitchSerial,
				createSwitchRoutingInterface.InterfaceId,
				updateSwitchRoutingInterfaceRequest,
				cancellationToken: CancellationToken);

		// Get the routing interface and compare
		var testSwitchRoutingInterface = await TestMerakiClient
			.Switch
			.Routing
			.Interfaces
			.GetDeviceSwitchRoutingInterfaceAsync(
				Configuration.TestSwitchSerial,
				createSwitchRoutingInterface.InterfaceId,
				cancellationToken: CancellationToken);
		_ = testSwitchRoutingInterface.Name.Should().Be(updateSwitchRoutingInterfaceRequest.Name);

		// Delete the routing interface
		await TestMerakiClient
			.Switch
			.Routing
			.Interfaces
			.DeleteDeviceSwitchRoutingInterfaceAsync(
				Configuration.TestSwitchSerial,
				createSwitchRoutingInterface.InterfaceId,
				cancellationToken: CancellationToken);

		// Check that the interface no longer exists

		_ = await ((Func<Task<RoutingInterface>>?)(() => TestMerakiClient
			.Switch
			.Routing
			.Interfaces
			.GetDeviceSwitchRoutingInterfaceAsync(
				Configuration.TestSwitchSerial,
				createSwitchRoutingInterface.InterfaceId,
				cancellationToken: CancellationToken)))
			.Should()
			.ThrowExactlyAsync<ApiException>()
			.Where(ex => ex.StatusCode == HttpStatusCode.NotFound);
	}
}
