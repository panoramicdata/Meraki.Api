using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Test.Data;

/// <summary>
/// Regression tests for Switch, Camera, Sensor and Cellular Gateway response members the v1.74.0
/// OpenAPI spec documents that the models lacked. Each payload has the shape the spec documents, and
/// is deserialized with the settings <see cref="JsonMissingMemberHandling.ThrowOnError"/> uses so an
/// unmapped field fails the test rather than being dropped.
/// </summary>
public class SwitchCameraSensorCellularMemberTests
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

	// GET /devices/{serial}/switch/ports/{portId} and the config template equivalent
	[Fact]
	public void Deserialize_SwitchPorts_MapStpPortFastTrunkAndDot3azEnabled()
	{
		_ = Deserialize<SwitchPort>("""{ "portId": "1", "name": "Uplink", "stpPortFastTrunk": true }""").StpPortFastTrunk.Should().BeTrue();

		var templatePort = Deserialize<ConfigTemplateSwitchProfilePort>("""{ "portId": "1", "name": "Uplink", "stpPortFastTrunk": false, "dot3az": { "enabled": true } }""");

		_ = templatePort.StpPortFastTrunk.Should().BeFalse();
		_ = templatePort.Dot3az!.Enabled.Should().BeTrue();
	}

	// GET /networks/{networkId}/switch/dhcp/v4/servers/seen - source.ipv4 is {address}, not a string.
	[Fact]
	public void Deserialize_DhcpV4ServersSeenSourceIpv4_MapsAddress()
	{
		var ipv4 = Deserialize<NetworksSwitchDhcpV4ServersSeenLastPacketSourceIpv4>("""{ "address": "10.0.0.1" }""");

		_ = ipv4.Address.Should().Be("10.0.0.1");
	}

	// Switch scalars.
	[Fact]
	public void Deserialize_SwitchScalars_Bind()
	{
		_ = Deserialize<AlternateManagementInterface>("""{ "enabled": true, "vlanId": 100, "protocols": [], "switches": [], "useOobMgmt": true }""").UseOobMgmt.Should().BeTrue();
		_ = Deserialize<ConfigOverrides>("""{ "type": "access", "allowedVlans": "all", "vlan": 10, "voiceVlan": 20 }""").VoiceVlan.Should().Be(20);
		_ = Deserialize<StackDevice>("""{ "serial": "Q2XX-ABCD-1234", "name": "sw1", "productType": "switch" }""").ProductType.Should().Be("switch");
	}

	// appliedOrgWide[] from POST /organizations/{organizationId}/camera/roles
	[Fact]
	public void Deserialize_CameraRoleAppliedOrgWide_MapsPermissionFields()
	{
		var applied = Deserialize<CameraRoleAppliedOrgWide>("""{ "tag": "cameras", "permissionScopeId": "1", "permissionScope": "Camera viewer", "permissionLevel": "view" }""");

		_ = applied.PermissionLevel.Should().Be("view");
		_ = applied.PermissionScope.Should().Be("Camera viewer");
		_ = applied.Tag.Should().Be("cameras");
	}

	// GET /devices/{serial}/camera/analytics/live - zones are keyed by zone ID, and ZoneData.Person
	// previously had no [DataMember] so was ignored inside a [DataContract] class.
	[Fact]
	public void Deserialize_CameraLive_MapsZonesByIdWithPersonCount()
	{
		var live = Deserialize<CameraLive>("""{ "ts": "2026-09-09T10:00:00Z", "zones": { "0": { "person": 2 }, "1234": { "person": 0 } } }""");

		_ = live.Zones.Should().HaveCount(2);
		_ = live.Zones["0"].Person.Should().Be(2);
	}

	// GET /organizations/{organizationId}/sensor/readings/latest - the newer air-quality metrics.
	[Fact]
	public void Deserialize_SensorReadingLatestReading_MapsNo2O3Pm10()
	{
		var reading = Deserialize<SensorReadingLatestReading>("""{ "ts": "2026-09-09T10:00:00Z", "metric": "pm10", "no2": { "concentration": 12 }, "o3": { "concentration": 30 }, "pm10": { "concentration": 8 } }""");

		_ = reading.Pm10!.Concentration.Should().Be(8);
		_ = reading.No2!.Concentration.Should().Be(12);
	}

	// GET /organizations/{organizationId}/cellularGateway/esims/serviceProviders/accounts - Items was a
	// list of a wrapper type, so no account ever bound.
	[Fact]
	public void Deserialize_EsimsServiceProvidersAccounts_MapsAccounts()
	{
		var accounts = Deserialize<EsimsServiceProvidersAccounts>("""
			{ "items": [ { "accountId": "1", "lastUpdatedAt": "2026-09-09T10:00:00Z", "title": "Example", "username": "user", "serviceProvider": { "name": "Example Mobile", "logo": { "url": "https://example.invalid/logo.png" } } } ], "meta": { "counts": { "items": { "total": 1, "remaining": 0 } } } }
			""");

		_ = accounts.Items.Should().ContainSingle().Which.AccountId.Should().Be("1");
		_ = accounts.Meta.Counts!.Items.Total.Should().Be(1);
	}

	// GET /organizations/{organizationId}/cellularGateway/esims/serviceProviders - logo is {url}.
	[Fact]
	public void Deserialize_EsimsServiceProvidersItemLogo_MapsUrl()
	{
		_ = Deserialize<EsimsServiceProvidersItemLogo>("""{ "url": "https://example.invalid/logo.png" }""").Url.Should().Be("https://example.invalid/logo.png");
		_ = Deserialize<NetworkCellularGatewayEsimsInventoryItemDevice>("""{ "model": "MG41", "name": "mg1", "serial": "Q2XX-ABCD-1234", "url": "https://example.invalid", "status": "online" }""").Status.Should().Be("online");
	}
}
