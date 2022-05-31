using FluentAssertions;
using Meraki.Api.Data;
using System.Net;
using Xunit.Abstractions;

namespace Meraki.Api.NewTest;
[Collection("API Collection")]
public class SwitchRoutingInterfaceTests : MerakiClientUnitTest
{
	public SwitchRoutingInterfaceTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
	{
	}

	[Fact]
	public async Task BasicCrud_Succeeds()
	{

		// Create a routing interface on our test switch

		// Set up the routing interface object to be created
		// InterfaceIp is required for a create, Subnet and DefaultGateway are required for InterfaceIp to be accepted
		var createSwitchRoutingInterfaceRequest = new RoutingInterfaceCreateRequest()
		{
			Name = "Test Routing Interface",
			VlanId = 12,
			DefaultGateway = "192.168.1.1",
			InterfaceIp = "192.168.1.2",
			Subnet = "192.168.1.0/24"
		};

		var createSwitchRoutingInterface = await TestMerakiClient.Switch.Routing.Interfaces.CreateDeviceSwitchRoutingInterfaceAsync(TestSwitchSerial, createSwitchRoutingInterfaceRequest);
		createSwitchRoutingInterface.Should().NotBeNull();
		
		// Get all routing interfaces from the switch and see that it's there
		var getSwitchRoutingInterfaces = await TestMerakiClient.Switch.Routing.Interfaces.GetDeviceSwitchRoutingInterfacesAsync(TestSwitchSerial);
		getSwitchRoutingInterfaces.Should().Contain(getSwitchRoutingInterfaces => getSwitchRoutingInterfaces.Name == createSwitchRoutingInterface.Name);

		// Make a change to the interface
		// TODO - Ipv6 settings are accepted without error on both update and create requests but not stored or retrievable, need to find out why.
		// TODO - OSPF settings are returned when they have not been set even though they default to null. Check this is Meraki and not us doing this.

		var updateSwitchRoutingInterfaceRequest = new RoutingInterfaceUpdateRequest()
		{
			Name = "Test Routing Interface Renamed",
			// VlanId = 12,
			// TODO - DefaultGateway added to PUT in v1.16. Required for creation and trying change gives an error from the API. Consider removing from the update model?
			// DefaultGateway = "192.168.1.1",
			// InterfaceIp = "192.168.1.2",
			// Subnet = "192.168.1.0/24",
			// Create some Ipv6 settings
			Ipv6 = new RoutingInterfaceIpv6()
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
			.UpdateDeviceSwitchRoutingInterfaceAsync(TestSwitchSerial, createSwitchRoutingInterface.InterfaceId, updateSwitchRoutingInterfaceRequest);
		/*
		updatedSwitchRoutingInterface.Should().NotBeNull();
		updatedSwitchRoutingInterface.Name.Should().Be(updateSwitchRoutingInterfaceRequest.Name);
		updatedSwitchRoutingInterface.Ipv6.Should().NotBeNull();
		updatedSwitchRoutingInterface.Ipv6!.AssignmentMode.Should().Be(updateSwitchRoutingInterfaceRequest.Ipv6.AssignmentMode);
		updatedSwitchRoutingInterface.Ipv6!.Address.Should().Be(updateSwitchRoutingInterfaceRequest.Ipv6.Address);
		updatedSwitchRoutingInterface.Ipv6!.Prefix.Should().Be(updateSwitchRoutingInterfaceRequest.Ipv6.Prefix);
		updatedSwitchRoutingInterface.Ipv6!.Gateway.Should().Be(updateSwitchRoutingInterfaceRequest.Ipv6.Gateway);
		*/
		// Get the routing interface and compare
		var testSwitchRoutingInterface = await TestMerakiClient.Switch.Routing.Interfaces.GetDeviceSwitchRoutingInterfaceAsync(TestSwitchSerial, createSwitchRoutingInterface.InterfaceId);
		testSwitchRoutingInterface.Name.Should().Be(updateSwitchRoutingInterfaceRequest.Name);

		// Delete the routing interface
		await TestMerakiClient.Switch.Routing.Interfaces.DeleteDeviceSwitchRoutingInterfaceAsync(TestSwitchSerial, createSwitchRoutingInterface.InterfaceId);

		// Check that the interface no longer exists
		var exception = await Assert.ThrowsAsync<Refit.ApiException>(() => TestMerakiClient.Switch.Routing.Interfaces.GetDeviceSwitchRoutingInterfaceAsync(TestSwitchSerial, createSwitchRoutingInterface.InterfaceId));
		exception.StatusCode.Should().Be(HttpStatusCode.NotFound);

	}
}