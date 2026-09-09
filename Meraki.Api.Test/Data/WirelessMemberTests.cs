using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Test.Data;

/// <summary>
/// Regression tests for Wireless response members the v1.74.0 OpenAPI spec documents that the
/// models lacked. Each payload has the shape the spec documents, and is deserialized with the
/// settings <see cref="JsonMissingMemberHandling.ThrowOnError"/> uses so an unmapped field fails
/// the test rather than being dropped.
/// </summary>
public class WirelessMemberTests
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

	// GET /networks/{networkId}/wireless/ssids/{number}
	[Fact]
	public void Deserialize_Ssid_MapsCampusGatewayAndWlanIdentifier()
	{
		var ssid = Deserialize<Ssid>("""
			{ "number": 0, "name": "Corp", "enabled": true, "campusGateway": { "cluster": { "id": "1" } }, "wlanIdentifier": 3 }
			""");

		_ = ssid.CampusGateway!.Cluster!.Id.Should().Be("1");
		_ = ssid.WlanIdentifier.Should().Be(3);
	}

	// POST /networks/{networkId}/wireless/rfProfiles - "dot11be", previously mapped as "be".
	[Fact]
	public void Deserialize_WirelessRfProfile_MapsDot11be()
	{
		var profile = Deserialize<WirelessRfProfile>("""
			{ "id": "1", "networkId": "N_1", "name": "Default", "dot11be": { "enabled": true, "mode": "per SSID group", "ssids": { "groups": { "1": { "enabled": true }, "2": { "enabled": false } } } } }
			""");

		_ = profile.Dot11be!.Enabled.Should().BeTrue();
		_ = profile.Dot11be.Ssids!.Groups["2"].Enabled.Should().BeFalse();
	}

	// GET /networks/{networkId}/wireless/electronicShelfLabel
	[Fact]
	public void Deserialize_ElectronicShelfLabelSettingsNetwork_MapsSepioo()
	{
		var settings = Deserialize<ElectronicShelfLabelSettingsNetwork>("""
			{ "enabled": true, "hostname": "esl.example.invalid", "mode": "high frequency", "sepioo": { "hostname": "sepioo.example.invalid" } }
			""");

		_ = settings.Sepioo!.Hostname.Should().Be("sepioo.example.invalid");
	}

	// GET /networks/{networkId}/wireless/airMarshal
	[Fact]
	public void Deserialize_AirMarshal_MapsEncryptionManufacturersAndTypes()
	{
		var entry = Deserialize<AirMarshal>("""
			{ "ssid": "Rogue", "bssids": [], "channels": [ 6 ], "firstSeen": 1700000000, "lastSeen": 1700000600, "wiredMacs": [], "wiredVlans": [], "wiredLastSeen": 0, "encryption": "WPA", "manufacturers": [ "Example Inc" ], "types": [ "rogue" ] }
			""");

		_ = entry.Encryption.Should().Be("WPA");
		_ = entry.Manufacturers.Should().ContainSingle();
		_ = entry.Types.Should().ContainSingle().Which.Should().Be("rogue");
	}

	// wifi0[] from GET /networks/{networkId}/networkHealth/channelUtilization - the API's current names.
	[Fact]
	public void Deserialize_Wifi_MapsCurrentChannelUtilizationNames()
	{
		var wifi = Deserialize<Wifi>("""
			{ "startTime": "2026-09-09T10:00:00Z", "endTime": "2026-09-09T10:10:00Z", "utilizationTotal": 40.5, "utilization80211": 30.25, "utilizationNon80211": 10.25 }
			""");

		_ = wifi.UtilizationTotalPercent.Should().Be(40.5);
		_ = wifi.Utilization80211.Should().Be(30.25);
		_ = wifi.EndTimeUtc.Should().Be(new DateTime(2026, 9, 9, 10, 10, 0, DateTimeKind.Utc));
	}

	// GET /organizations/{organizationId}/wirelessController/devices/interfaces/l2/usage/history/byInterval
	// - "meta" was mapped as "name".
	[Fact]
	public void Deserialize_L2UsageHistoryByIntervalResponse_MapsMeta()
	{
		var response = Deserialize<OrganizationWirelessControllerDevicesInterfacesL2UsageHistoryByIntervalGetResponse>("""
			{ "items": [], "meta": { "counts": { "items": { "total": 0, "remaining": 0 } } } }
			""");

		_ = response.Meta.Should().NotBeNull();
		_ = response.Items.Should().BeEmpty();
	}

	// Scalars added across the area.
	[Fact]
	public void Deserialize_WirelessScalars_Bind()
	{
		_ = Deserialize<Gre>("""{ "key": 5, "clientIsolation": true }""").ClientIsolation.Should().BeTrue();
		_ = Deserialize<NaiRealm>("""{ "format": "0", "realm": "example.invalid", "name": "Example", "methods": [] }""").Name.Should().Be("Example");
		_ = Deserialize<FailedConnection>("""{ "ssidNumber": 1, "vlan": 10, "clientMac": "00:11:22:33:44:55", "serial": "Q2XX-ABCD-1234", "failureStep": "auth", "type": "802.1X auth fail", "ts": "2026-09-09T10:00:00Z", "radio": 1 }""").Radio.Should().Be(1);
		_ = Deserialize<ConnectivityEvents>("""{ "occurredAt": "2026-09-09T10:00:00Z", "ssidNumber": 2 }""").SsidNumber.Should().Be(2);
		_ = Deserialize<SsidsStatusesByDeviceItemBasicServiceSetRadio>("""{ "band": "5", "channel": 36, "channelWidth": "80", "power": 20, "isBroadcasting": true, "index": "1" }""").Index.Should().Be("1");
	}
}
