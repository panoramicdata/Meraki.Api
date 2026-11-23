using Newtonsoft.Json;

namespace Meraki.Api.Test.Data;

/// <summary>
/// Members the live API returns that the models lacked. Deserializing with
/// MissingMemberHandling.Error, as JsonMissingMemberHandling.ThrowOnError does, fails on any
/// member the model lacks. All sample values are invented.
/// </summary>
public class MissingMembers20261123Tests
{
	private static readonly JsonSerializerSettings _strictSettings = new()
	{
		MissingMemberHandling = MissingMemberHandling.Error
	};

	private static T Deserialize<T>(string json)
		=> JsonConvert.DeserializeObject<T>(json, _strictSettings)!;

	[Theory]
	[InlineData("null", null)]
	[InlineData("false", false)]
	[InlineData("true", true)]
	public void DeserializeApplianceSettings_SdwanCellular_Succeeds(string enabledJson, bool? expected)
	{
		var settings = Deserialize<ApplianceSettings>($"{{\"clientTrackingMethod\":\"MAC address\",\"deploymentMode\":\"routed\",\"dynamicDns\":{{\"prefix\":\"example\",\"enabled\":true,\"url\":\"example.dynamic-m.com\"}},\"sdwanCellular\":{{\"enabled\":{enabledJson}}}}}");

		_ = settings.SdwanCellular.Should().NotBeNull();
		_ = settings.SdwanCellular!.Enabled.Should().Be(expected);
	}

	[Fact]
	public void DeserializeInventoryDevices_NullTrialId_Succeeds()
	{
		var devices = Deserialize<List<InventoryDevice>>("[{\"mac\":\"00:00:5e:00:53:01\",\"serial\":\"Q000-0000-0001\",\"name\":null,\"model\":\"MR00\",\"networkId\":null,\"trialId\":null}]");

		var device = devices.Should().ContainSingle().Subject;
		_ = device.TrialId.Should().BeNull();
	}

	[Fact]
	public void DeserializeInventoryDevices_TrialId_Succeeds()
	{
		var devices = Deserialize<List<InventoryDevice>>("[{\"serial\":\"Q000-0000-0001\",\"trialId\":\"1234567890\"}]");

		_ = devices.Should().ContainSingle().Subject.TrialId.Should().Be("1234567890");
	}

	[Fact]
	public void DeserializeApplianceRfProfiles_PerSsidName_Succeeds()
	{
		var profiles = Deserialize<List<NetworkApplianceRfProfile>>("[{\"id\":\"1234567890\",\"networkId\":\"L_1234567890\",\"name\":\"Example profile\",\"perSsidSettings\":{\"1\":{\"name\":\"Example SSID\",\"bandOperationMode\":\"dual\",\"bandSteeringEnabled\":true},\"2\":{\"name\":\"Unconfigured SSID 2\",\"bandOperationMode\":\"dual\",\"bandSteeringEnabled\":false}}}]");

		var profile = profiles.Should().ContainSingle().Subject;
		_ = profile.PerSsidSettings!.Ssid1!.Name.Should().Be("Example SSID");
		_ = profile.PerSsidSettings.Ssid2!.Name.Should().Be("Unconfigured SSID 2");
	}

	[Fact]
	public void DeserializeNetworkBluetoothSettings_SensorConnectTransmit_Succeeds()
	{
		var settings = Deserialize<NetworkBluetoothSettings>("{\"scanningEnabled\":false,\"transmit\":{\"advertised\":{\"power\":-60}},\"sensorConnect\":{\"enabled\":false,\"uuid\":\"00000000-0000-0000-0000-000000000000\",\"major\":1,\"transmit\":{\"advertised\":{\"power\":-60}}}}");

		_ = settings.SensorConnect.Should().NotBeNull();
		_ = settings.SensorConnect!.Transmit.Should().NotBeNull();
		_ = settings.SensorConnect.Transmit!.Advertised!.Power.Should().Be(-60);
	}

	[Fact]
	public void DeserializeThirdPartyVpnPeers_Sgt_Succeeds()
	{
		var peers = Deserialize<ThirdPartyVpnPeers>("{\"peers\":[{\"name\":\"Example peer\",\"publicIp\":\"192.0.2.1\",\"privateSubnets\":[\"198.51.100.0/24\"],\"ikeVersion\":\"2\",\"sgt\":{\"enabled\":false}}]}");

		var peer = peers.Peers.Should().ContainSingle().Subject;
		_ = peer.Sgt.Should().NotBeNull();
		_ = peer.Sgt!.Enabled.Should().BeFalse();
	}

	[Fact]
	public void DeserializeTrafficShaping_SpeedBurst_Succeeds()
	{
		var trafficShaping = Deserialize<TrafficShaping>("{\"globalBandwidthLimits\":{\"limitUp\":0,\"limitDown\":0},\"speedBurst\":{\"enabled\":true}}");

		_ = trafficShaping.SpeedBurst.Should().NotBeNull();
		_ = trafficShaping.SpeedBurst!.Enabled.Should().BeTrue();
	}
}
