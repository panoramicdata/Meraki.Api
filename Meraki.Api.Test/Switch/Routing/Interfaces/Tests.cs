using System.Net;

namespace Meraki.Api.Test.Switch.Routing.Interfaces;

public class Tests(ITestOutputHelper testOutputHelper) : MerakiClientTest(testOutputHelper)
{
	// RFC 5737 / RFC 3849 documentation ranges, so the fixtures cannot collide with real addressing.
	private const string DocumentationGateway = "192.0.2.1";
	private const string DocumentationInterfaceIp = "192.0.2.2";
	private const string DocumentationSubnet = "192.0.2.0/24";
	private const string DocumentationIpv6Address = "2001:db8:1::1";
	private const string DocumentationIpv6Prefix = "2001:db8:1::/48";
	private const string DocumentationIpv6Gateway = "2001:db8:1::2";

	[Fact]
	public async Task SwitchRoutingInterface_Crud_Succeeds()
	{
		var createdInterface = await CreateInterfaceAsync();

		try
		{
			await AssertInterfaceIsListedAsync(createdInterface);
			await UpdateInterfaceAsync(createdInterface.InterfaceId);
		}
		finally
		{
			await DeleteInterfaceAsync(createdInterface.InterfaceId);
		}

		await AssertInterfaceIsGoneAsync(createdInterface.InterfaceId);
	}

	private async Task<RoutingInterface> CreateInterfaceAsync()
	{
		// InterfaceIp is required for a create, and Subnet and DefaultGateway are required for InterfaceIp to be accepted.
		var request = new RoutingInterfaceCreateRequest
		{
			Name = "Test Routing Interface",
			VlanId = 12,
			DefaultGateway = DocumentationGateway,
			InterfaceIp = DocumentationInterfaceIp,
			Subnet = DocumentationSubnet
		};

		var created = await TestMerakiClient
			.Switch
			.Routing
			.Interfaces
			.CreateDeviceSwitchRoutingInterfaceAsync(
				Configuration.TestSwitchSerial,
				request,
				cancellationToken: CancellationToken);
		_ = created.Should().NotBeNull();

		return created;
	}

	private async Task AssertInterfaceIsListedAsync(RoutingInterface createdInterface)
	{
		var interfaces = await TestMerakiClient
			.Switch
			.Routing
			.Interfaces
			.GetDeviceSwitchRoutingInterfacesAsync(
				Configuration.TestSwitchSerial,
				cancellationToken: CancellationToken);
		_ = interfaces.Should().Contain(routingInterface => routingInterface.Name == createdInterface.Name);
	}

	// TODO - Ipv6 settings are accepted without error on both update and create requests but not stored or retrievable, need to find out why.
	// TODO - OSPF settings are returned when they have not been set even though they default to null. Check this is Meraki and not us doing this.
	// TODO - DefaultGateway was added to PUT in v1.16, but requesting a change to it gives an error from the API.
	//        Consider removing DefaultGateway, InterfaceIp, Subnet and VlanId from the update model.
	private async Task UpdateInterfaceAsync(string interfaceId)
	{
		var request = new RoutingInterfaceUpdateRequest
		{
			Name = "Test Routing Interface Renamed",
			Ipv6 = new RoutingInterfaceIpv6
			{
				AssignmentMode = AssignmentMode.Static,
				Address = DocumentationIpv6Address,
				Prefix = DocumentationIpv6Prefix,
				Gateway = DocumentationIpv6Gateway
			}
		};

		_ = await TestMerakiClient
			.Switch
			.Routing
			.Interfaces
			.UpdateDeviceSwitchRoutingInterfaceAsync(
				Configuration.TestSwitchSerial,
				interfaceId,
				request,
				cancellationToken: CancellationToken);

		var reloaded = await TestMerakiClient
			.Switch
			.Routing
			.Interfaces
			.GetDeviceSwitchRoutingInterfaceAsync(
				Configuration.TestSwitchSerial,
				interfaceId,
				cancellationToken: CancellationToken);
		_ = reloaded.Name.Should().Be(request.Name);
	}

	private Task DeleteInterfaceAsync(string interfaceId)
		=> TestMerakiClient
			.Switch
			.Routing
			.Interfaces
			.DeleteDeviceSwitchRoutingInterfaceAsync(
				Configuration.TestSwitchSerial,
				interfaceId,
				cancellationToken: CancellationToken);

	private async Task AssertInterfaceIsGoneAsync(string interfaceId)
		=> _ = await ((Func<Task<RoutingInterface>>?)(() => TestMerakiClient
			.Switch
			.Routing
			.Interfaces
			.GetDeviceSwitchRoutingInterfaceAsync(
				Configuration.TestSwitchSerial,
				interfaceId,
				cancellationToken: CancellationToken)))
			.Should()
			.ThrowExactlyAsync<ApiException>()
			.Where(ex => ex.StatusCode == HttpStatusCode.NotFound);
}
