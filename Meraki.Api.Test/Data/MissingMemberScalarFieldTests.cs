using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Test.Data;

/// <summary>
/// Regression tests for the scalar response fields that live organizations were observed to return
/// with no matching model property. Each payload keeps the shape of a real Dashboard API response
/// with identifying values replaced, and each test deserializes it with the same settings
/// <see cref="JsonMissingMemberHandling.ThrowOnError"/> uses, so an unmapped field fails the test
/// rather than being silently dropped.
/// </summary>
public class MissingMemberScalarFieldTests
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

	// GET /networks/{networkId}/vlanProfiles/assignments/byDevice
	[Fact]
	public void Deserialize_VlanProfileDeviceAssignment_MapsConfigurationSource()
	{
		const string json = """
			{
				"name": "AP-01",
				"mac": "00:11:22:33:44:55",
				"serial": "Q2XX-ABCD-1234",
				"productType": "wireless",
				"vlanProfile": {
					"iname": "Default",
					"name": "Default Profile",
					"isDefault": true
				},
				"configurationSource": "Cloud",
				"stack": {
					"id": null,
					"name": null
				}
			}
			""";

		var assignment = Deserialize<VlanProfileDeviceAssignment>(json);

		_ = assignment.ConfigurationSource.Should().Be("Cloud");
	}

	// GET /organizations/{organizationId}/configTemplates/{configTemplateId}/switch/profiles/{profileId}/ports
	[Fact]
	public void Deserialize_ConfigTemplateSwitchProfilePort_MapsActiveVlans()
	{
		const string json = """
			{
				"portId": "1",
				"name": "Client Access",
				"tags": [],
				"enabled": true,
				"poeEnabled": true,
				"type": "access",
				"vlan": 50,
				"voiceVlan": 60,
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
				"mirror": {
					"mode": "Not mirroring traffic"
				}
			}
			""";

		var port = Deserialize<ConfigTemplateSwitchProfilePort>(json);

		_ = port.ActiveVlans.Should().Be("1-4094");
	}

	// GET /networks/{networkId}/camera/qualityRetentionProfiles
	// videoSettings is trimmed to two camera models; the full response lists every supported model.
	[Fact]
	public void Deserialize_CameraQualityRetentionProfile_MapsAxisVideoQuality()
	{
		const string json = """
			{
				"id": "220",
				"name": "Default",
				"restrictedBandwidthModeEnabled": false,
				"motionBasedRetentionEnabled": false,
				"audioRecordingEnabled": false,
				"cloudArchiveEnabled": true,
				"maxRetentionDays": null,
				"scheduleId": null,
				"motionDetectorVersion": 2,
				"smartRetention": {
					"enabled": false
				},
				"videoSettings": {
					"MV2": {
						"quality": "High",
						"resolution": "1920x1080"
					},
					"MV44X": {
						"quality": "Enhanced",
						"resolution": "2560x1920"
					}
				},
				"axisVideoQuality": "enhanced"
			}
			""";

		var profile = Deserialize<CameraQualityRetentionProfile>(json);

		_ = profile.AxisVideoQuality.Should().Be("enhanced");
	}

	// GET /networks/{networkId}/appliance/vpn/bgp
	// The same response also carries ipv6 and tunnelDownTermination, which are mapped separately.
	[Fact]
	public void Deserialize_VpnBgp_MapsPriorityRoute()
	{
		const string json = """
			{
				"enabled": false,
				"ibgpHoldTimer": 240,
				"asNumber": 64512,
				"routerId": null,
				"priorityRoute": "Auto VPN",
				"neighbors": []
			}
			""";

		var bgp = Deserialize<VpnBgp>(json);

		_ = bgp.PriorityRoute.Should().Be("Auto VPN");
	}

	// GET /devices/{serial}/switch/routing/interfaces
	[Fact]
	public void Deserialize_RoutingInterface_MapsIsSwitchDefaultGateway()
	{
		const string json = """
			{
				"interfaceId": "1234567890123456789",
				"name": "Firewall Transit",
				"subnet": "10.0.0.0/29",
				"interfaceIp": "10.0.0.4",
				"mtu": 0,
				"multicastRouting": "disabled",
				"vlanId": 500,
				"defaultGateway": "10.0.0.1",
				"ospfSettings": {
					"area": "ospfDisabled"
				},
				"ospfV3": {
					"area": "ospfV3Disabled"
				},
				"uplinkV4": true,
				"uplinkV6": false,
				"mode": "vlan",
				"switchPortId": null,
				"isSwitchDefaultGateway": false,
				"candidateUplinkV4": true,
				"staticV4Dns1": "8.8.8.8",
				"staticV4Dns2": null,
				"vrf": {
					"name": "Default"
				},
				"vrrp": {
					"ipv4": {
						"enabled": false
					},
					"ipv6": {
						"enabled": false
					}
				}
			}
			""";

		var routingInterface = Deserialize<RoutingInterface>(json);

		_ = routingInterface.IsSwitchDefaultGateway.Should().BeFalse();
	}

	// GET /organizations/{organizationId}/appliance/trafficShaping/vpnExclusions/byNetwork
	[Fact]
	public void Deserialize_TrafficShapingVpnExclusionsApplication_MapsProtocolAndSource()
	{
		const string json = """
			{
				"id": "meraki:layer7/application/1431",
				"name": "Microsoft Office 365",
				"protocol": "any",
				"source": null
			}
			""";

		var application = Deserialize<TrafficShapingVpnExclusionsApplication>(json);

		_ = application.Protocol.Should().Be(TrafficShapingVpnExclusionsCustomProtocol.Any);
		_ = application.Source.Should().BeNull();
	}
}
