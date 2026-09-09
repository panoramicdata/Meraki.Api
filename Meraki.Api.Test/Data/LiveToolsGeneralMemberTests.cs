using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Test.Data;

/// <summary>
/// Regression tests for Live Tools and general response members the v1.74.0 OpenAPI spec documents
/// that the models lacked. Each payload has the shape the spec documents, and is deserialized with
/// the settings <see cref="JsonMissingMemberHandling.ThrowOnError"/> uses so an unmapped field fails
/// the test rather than being dropped.
/// </summary>
public class LiveToolsGeneralMemberTests
{
	private static readonly JsonSerializerSettings ThrowOnMissingMember = new()
	{
		NullValueHandling = NullValueHandling.Ignore,
		MissingMemberHandling = MissingMemberHandling.Error,
		Converters = [new StringEnumConverter()]
	};

	private static T Deserialize<T>(string json)
	{
		var result = JsonConvert.DeserializeObject<T>(json, ThrowOnMissingMember);
		_ = result.Should().NotBeNull();
		return result!;
	}

	// GET /networks/{networkId}/clients/{clientId} - cdp is a list of two-element lists.
	[Fact]
	public void Deserialize_Client_MapsCdp()
	{
		var client = Deserialize<Meraki.Api.Data.Client>("""{ "id": "k74272e", "mac": "00:11:22:33:44:55", "cdp": [ [ "Device ID", "sw1" ], [ "Port ID", "Gi1/0/1" ] ] }""");

		_ = client.Cdp.Should().HaveCount(2);
		_ = client.Cdp![1][1].Should().Be("Gi1/0/1");
	}

	// POST /networks/{networkId}/clients/provision
	[Fact]
	public void Deserialize_ClientProvision_MapsClientIdAndMessage()
	{
		var provision = Deserialize<ClientProvision>("""{ "mac": "00:11:22:33:44:55", "name": "Laptop", "clientId": "k74272e", "message": "Blocked by policy" }""");

		_ = provision.ClientId.Should().Be("k74272e");
		_ = provision.Message.Should().Be("Blocked by policy");
	}

	// GET /devices/{serial}/livetools/multicastRouting/{multicastRoutingId}
	[Fact]
	public void Deserialize_MulticastRoutingInterfaceAndRoute_MapVrfFields()
	{
		var iface = Deserialize<DeviceLiveToolsMulticastRoutingGetResponseInterface>("""{ "name": "Vlan10", "ip": "10.0.10.1", "subnet": "10.0.10.0/24", "flags": [], "neighbors": [], "ipVersion": "4", "vrf": "Default", "vrfType": "default" }""");
		var route = Deserialize<DeviceLiveToolsMulticastRoutingGetResponseRoute>("""{ "group": "239.1.1.1", "incomingInterfaceName": "Vlan10", "rendezvousPoint": "10.0.0.1", "source": "10.0.10.5", "flags": [], "outgoingInterfaceNames": [], "ipVersion": "4", "vrf": "Default" }""");

		_ = iface.VrfType.Should().Be("default");
		_ = route.Vrf.Should().Be("Default");
	}

	// GET /devices/{serial}/lossAndLatencyHistory - the API's current names alongside the legacy ones.
	[Fact]
	public void Deserialize_LossAndLatencyHistory_MapsCurrentTimeNames()
	{
		var sample = Deserialize<LossAndLatencyHistory>("""{ "startTime": "2026-09-09T10:00:00Z", "endTime": "2026-09-09T10:01:00Z", "lossPercent": 0.5, "latencyMs": 12.5, "goodput": 1000, "jitter": 1.5 }""");

		_ = sample.StartTimeUtc.Should().Be(new DateTime(2026, 9, 9, 10, 0, 0, DateTimeKind.Utc));
	}

	// Remaining scalars across the area.
	[Fact]
	public void Deserialize_LiveToolsAndGeneralScalars_Bind()
	{
		_ = Deserialize<DeviceClient>("""{ "id": "k74272e", "mac": "00:11:22:33:44:55", "adaptivePolicyGroup": "Employees", "switchport": "1" }""").Switchport.Should().Be("1");
		_ = Deserialize<DeviceLiveToolsMacTableGetResponseRequest>("""{ "serial": "Q2XX-ABCD-1234", "mac": "00:11:22:a0:b1:c2" }""").Mac.Should().Be("00:11:22:a0:b1:c2");
		_ = Deserialize<Events>("""{ "occurredAt": "2026-09-09T10:00:00Z", "networkId": "N_1", "type": "association", "description": "802.11 association", "clientMac": "00:11:22:33:44:55" }""").ClientMac.Should().Be("00:11:22:33:44:55");
		_ = Deserialize<LiveToolsArpTableResultTableEntry>("""{ "vlanId": 10, "ip": "10.0.10.5", "lastUpdatedAt": "2026-09-09T10:00:00Z", "mac": "00:11:22:33:44:55", "interface": "Vlan10" }""").Interface.Should().Be("Vlan10");
		_ = Deserialize<LiveToolsThroughputTestCreateResponse>("""{ "throughputTestId": "1" }""").ThroughputTestId.Should().Be("1");
		_ = Deserialize<SubclassApplicationUsage>("""{ "application": "Google", "received": 1024, "sent": 512 }""").Received.Should().Be(1024);
		_ = Deserialize<SubclassUsageHistory>("""{ "ts": "2026-09-09", "received": 10.5, "sent": 2 }""").Received.Should().Be(10.5);
	}
}
