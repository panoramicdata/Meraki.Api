using Newtonsoft.Json;

namespace Meraki.Api.Test.Data;

/// <summary>
/// Members the live API returns that the models lacked. Deserializing with
/// MissingMemberHandling.Error, as JsonMissingMemberHandling.ThrowOnError does, fails on any
/// member the model lacks. All sample values are invented.
/// </summary>
public class MissingMembers20261015Tests
{
	private static readonly JsonSerializerSettings _strictSettings = new()
	{
		MissingMemberHandling = MissingMemberHandling.Error
	};

	private static T Deserialize<T>(string json)
		=> JsonConvert.DeserializeObject<T>(json, _strictSettings)!;

	[Fact]
	public void DeserializeConfigTemplateSwitchProfilePort_PerpetualPoeAndFastPoe_Succeeds()
	{
		var port = Deserialize<ConfigTemplateSwitchProfilePort>("{\"portId\":\"1\",\"poeEnabled\":true,\"perpetualPoe\":{\"enabled\":true},\"fastPoe\":{\"enabled\":false}}");

		_ = port.PerpetualPoe.Should().NotBeNull();
		_ = port.PerpetualPoe!.Enabled.Should().BeTrue();
		_ = port.FastPoe.Should().NotBeNull();
		_ = port.FastPoe!.Enabled.Should().BeFalse();
	}

	[Fact]
	public void DeserializeRoutingInterfaceVrrpIpv4_AddressGroupPriorityPreemption_Succeeds()
	{
		var vrrp = Deserialize<RoutingInterfaceVrrpIpv4>("{\"enabled\":true,\"address\":\"192.0.2.1\",\"group\":5,\"priority\":100,\"preemption\":{\"enabled\":true}}");

		_ = vrrp.Enabled.Should().BeTrue();
		_ = vrrp.Address.Should().Be("192.0.2.1");
		_ = vrrp.Group.Should().Be(5);
		_ = vrrp.Priority.Should().Be(100);
		_ = vrrp.Preemption.Should().NotBeNull();
		_ = vrrp.Preemption!.Enabled.Should().BeTrue();
	}

	[Fact]
	public void DeserializeNetworkBluetoothSettings_SensorConnect_Succeeds()
	{
		const string json = """
			{
				"scanningEnabled": true,
				"advertisingEnabled": false,
				"eslEnabled": false,
				"sensorConnect": {
					"enabled": true,
					"scanning": { "enabled": true },
					"advertising": { "enabled": false },
					"filtering": {
						"ignore": {
							"mac": {
								"addressTypes": [ "random private" ]
							}
						}
					},
					"uuid": "00000000-0000-4000-8000-000000000001",
					"assignment": { "mode": "non-unique" },
					"major": 10,
					"minor": 20
				},
				"transmit": {
					"advertised": { "power": -59 }
				}
			}
			""";

		var settings = Deserialize<NetworkBluetoothSettings>(json);

		_ = settings.EslEnabled.Should().BeFalse();
		_ = settings.Transmit!.Advertised!.Power.Should().Be(-59);
		var sensorConnect = settings.SensorConnect;
		_ = sensorConnect.Should().NotBeNull();
		_ = sensorConnect!.Enabled.Should().BeTrue();
		_ = sensorConnect.Scanning!.Enabled.Should().BeTrue();
		_ = sensorConnect.Advertising!.Enabled.Should().BeFalse();
		_ = sensorConnect.Filtering!.Ignore!.Mac!.AddressTypes.Should().Equal("random private");
		_ = sensorConnect.Uuid.Should().Be("00000000-0000-4000-8000-000000000001");
		_ = sensorConnect.Assignment!.Mode.Should().Be("non-unique");
		_ = sensorConnect.Major.Should().Be(10);
		_ = sensorConnect.Minor.Should().Be(20);
	}

	[Fact]
	public void DeserializeSwitchStackMember_SwitchNumber_Succeeds()
	{
		var member = Deserialize<SwitchStackMember>("{\"serial\":\"Q000-0000-0001\",\"name\":\"Example switch\",\"model\":\"C9300-24U\",\"mac\":\"00:00:5e:00:53:01\",\"role\":\"active\",\"switchNumber\":2}");

		_ = member.SwitchNumber.Should().Be(2);
	}

	[Fact]
	public void DeserializeRfProfileBandSettings_EdRrmWithNullValues_Succeeds()
	{
		const string edRrm = """
			"edRrm": {
				"enabled": null,
				"sensitivity": { "threshold": null },
				"rogue": { "contribution": { "enabled": null } }
			}
			""";

		var twoFour = Deserialize<TwoPointFourGhzSettings>("{\"maxPower\":30," + edRrm + "}");
		var five = Deserialize<FiveGhzSettings>("{\"maxPower\":30," + edRrm + "}");
		var six = Deserialize<SixGhzSettings>("{\"maxPower\":30," + edRrm + "}");

		foreach (var settings in new[] { twoFour.EdRrm, five.EdRrm, six.EdRrm })
		{
			_ = settings.Should().NotBeNull();
			_ = settings!.Enabled.Should().BeNull();
			_ = settings.Sensitivity!.Threshold.Should().BeNull();
			_ = settings.Rogue!.Contribution!.Enabled.Should().BeNull();
		}
	}

	[Fact]
	public void DeserializeFiveGhzSettings_EdRrmWithValues_Succeeds()
	{
		var five = Deserialize<FiveGhzSettings>("{\"maxPower\":30,\"edRrm\":{\"enabled\":true,\"sensitivity\":{\"threshold\":-70},\"rogue\":{\"contribution\":{\"enabled\":false}}}}");

		_ = five.EdRrm!.Enabled.Should().BeTrue();
		_ = five.EdRrm.Sensitivity!.Threshold.Should().Be(-70);
		_ = five.EdRrm.Rogue!.Contribution!.Enabled.Should().BeFalse();
	}

	[Fact]
	public void DeserializeVlan_Vpn_Succeeds()
	{
		var vlan = Deserialize<Vlan>("{\"id\":10,\"name\":\"Example VLAN\",\"vpn\":{\"advertisement\":{\"enabled\":true}}}");

		_ = vlan.Vpn.Should().NotBeNull();
		_ = vlan.Vpn!.Advertisement.Should().NotBeNull();
		_ = vlan.Vpn.Advertisement!.Enabled.Should().BeTrue();
	}
}
