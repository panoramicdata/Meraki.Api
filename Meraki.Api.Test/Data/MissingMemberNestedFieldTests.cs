using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Test.Data;

/// <summary>
/// Regression tests for the nested response objects that live organizations were observed to return
/// with no matching model property. Each payload keeps the shape of a real Dashboard API response
/// with identifying values replaced, and each test deserializes it with the same settings
/// <see cref="JsonMissingMemberHandling.ThrowOnError"/> uses, so an unmapped field fails the test
/// rather than being silently dropped.
/// </summary>
public class MissingMemberNestedFieldTests
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

	// twoFourGhzSettings from GET /networks/{networkId}/wireless/rfProfiles
	[Fact]
	public void Deserialize_TwoPointFourGhzSettings_MapsDot11ax()
	{
		const string json = """
			{
				"maxPower": 30,
				"minPower": 5,
				"minBitrate": 11,
				"rxsop": null,
				"validAutoChannels": [ 1, 6, 11 ],
				"axEnabled": true,
				"dot11ax": {
					"enabled": true
				}
			}
			""";

		var settings = Deserialize<TwoPointFourGhzSettings>(json);

		_ = settings.Dot11ax.Should().NotBeNull();
		_ = settings.Dot11ax!.Enabled.Should().BeTrue();
	}

	// fiveGhzSettings from GET /networks/{networkId}/wireless/rfProfiles
	[Fact]
	public void Deserialize_FiveGhzSettings_MapsDot11ax()
	{
		const string json = """
			{
				"maxPower": 30,
				"minPower": 8,
				"minBitrate": 12,
				"rxsop": null,
				"validAutoChannels": [ 36, 40, 44, 48, 149, 153, 157, 161 ],
				"channelWidth": "auto",
				"dot11ax": {
					"enabled": true
				}
			}
			""";

		var settings = Deserialize<FiveGhzSettings>(json);

		_ = settings.Dot11ax.Should().NotBeNull();
		_ = settings.Dot11ax!.Enabled.Should().BeTrue();
	}

	// GET /devices/{serial}/switch/ports
	[Fact]
	public void Deserialize_SwitchPort_MapsPerpetualPoeAndFastPoe()
	{
		const string json = """
			{
				"portId": "1",
				"name": "Access Port",
				"tags": [],
				"enabled": true,
				"poeEnabled": true,
				"perpetualPoe": {
					"enabled": false
				},
				"fastPoe": {
					"enabled": false
				},
				"type": "trunk",
				"vlan": 1,
				"voiceVlan": null,
				"allowedVlans": "all",
				"activeVlans": "1-4094",
				"isolationEnabled": false,
				"rstpEnabled": true,
				"stpGuard": "disabled",
				"linkNegotiation": "Auto negotiate",
				"portScheduleId": null,
				"schedule": null,
				"udld": "Alert only",
				"linkNegotiationCapabilities": [
					"Auto negotiate",
					"1 Gigabit full duplex (auto)"
				],
				"accessPolicyType": "Open",
				"daiTrusted": false,
				"profile": {
					"enabled": false,
					"id": "",
					"iname": null
				},
				"module": {
					"model": null
				},
				"mirror": {
					"mode": "Not mirroring traffic"
				}
			}
			""";

		var port = Deserialize<SwitchPort>(json);

		_ = port.PerpetualPoe.Should().NotBeNull();
		_ = port.PerpetualPoe!.Enabled.Should().BeFalse();
		_ = port.FastPoe.Should().NotBeNull();
		_ = port.FastPoe!.Enabled.Should().BeFalse();
	}

	// radiusServers from GET /networks/{networkId}/appliance/ssids
	[Fact]
	public void Deserialize_NetworkApplianceSsidRadiusServer_MapsRadsec()
	{
		const string json = """
			{
				"host": "192.0.2.10",
				"port": 2654,
				"id": "1234567890123456789",
				"openRoamingCertificateId": null,
				"caCertificate": null,
				"radsec": {
					"enabled": false,
					"tlsIdleTimeout": 900
				}
			}
			""";

		var radiusServer = Deserialize<NetworkApplianceSsidRadiusServer>(json);

		_ = radiusServer.Radsec.Should().NotBeNull();
		_ = radiusServer.Radsec!.Enabled.Should().BeFalse();
		_ = radiusServer.Radsec.TlsIdleTimeout.Should().Be(900);
	}

	// GET /organizations/{organizationId}/admins
	[Fact]
	public void Deserialize_Admin_MapsOtherOrganizationAccounts()
	{
		const string json = """
			{
				"id": "1234567890123456789",
				"name": "Example Administrator",
				"email": "admin@example.com",
				"authenticationMethod": "Email",
				"orgAccess": "full",
				"accountStatus": "ok",
				"otherOrganizationAccounts": {
					"lockout": {
						"isLocked": false
					}
				},
				"twoFactorAuthEnabled": false,
				"hasApiKey": true,
				"lastActive": "2026-09-04T10:23:23Z",
				"networks": [],
				"tags": []
			}
			""";

		var admin = Deserialize<Admin>(json);

		_ = admin.OtherOrganizationAccounts.Should().NotBeNull();
		_ = admin.OtherOrganizationAccounts!.Lockout.Should().NotBeNull();
		_ = admin.OtherOrganizationAccounts.Lockout!.IsLocked.Should().BeFalse();
	}

	// GET /networks/{networkId}/appliance/vpn/bgp - the whole observed response, including the
	// PriorityRoute scalar mapped alongside these two nested objects.
	[Fact]
	public void Deserialize_VpnBgp_MapsIpv6AndTunnelDownTermination()
	{
		const string json = """
			{
				"enabled": false,
				"ibgpHoldTimer": 240,
				"asNumber": 64512,
				"routerId": null,
				"priorityRoute": "Auto VPN",
				"ipv6": {
					"singlePeering": {
						"enabled": false
					}
				},
				"tunnelDownTermination": {
					"enabled": null
				},
				"neighbors": []
			}
			""";

		var bgp = Deserialize<VpnBgp>(json);

		_ = bgp.PriorityRoute.Should().Be("Auto VPN");
		_ = bgp.Ipv6.Should().NotBeNull();
		_ = bgp.Ipv6!.SinglePeering.Should().NotBeNull();
		_ = bgp.Ipv6.SinglePeering!.Enabled.Should().BeFalse();
		_ = bgp.TunnelDownTermination.Should().NotBeNull();
		_ = bgp.TunnelDownTermination!.Enabled.Should().BeNull();
	}
}
