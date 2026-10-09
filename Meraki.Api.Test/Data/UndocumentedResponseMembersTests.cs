using Newtonsoft.Json;

namespace Meraki.Api.Test.Data;

/// <summary>
/// Members the live API returns but the OpenAPI spec does not document. Deserializing with
/// MissingMemberHandling.Error, as JsonMissingMemberHandling.ThrowOnError does, fails on any
/// member the model lacks.
/// </summary>
public class UndocumentedResponseMembersTests
{
	private static readonly JsonSerializerSettings _strictSettings = new()
	{
		MissingMemberHandling = MissingMemberHandling.Error
	};

	private static T Deserialize<T>(string json)
		=> JsonConvert.DeserializeObject<T>(json, _strictSettings)!;

	[Fact]
	public void DeserializeSwitchPort_Interface_Succeeds()
	{
		var port = Deserialize<SwitchPort>("{\"portId\":\"1\",\"interface\":{\"name\":\"GigabitEthernet1/0/1\",\"switch\":1,\"module\":0,\"slot\":null,\"subslot\":null,\"number\":1}}");

		_ = port.Interface.Should().NotBeNull();
		_ = port.Interface!.Name.Should().Be("GigabitEthernet1/0/1");
		_ = port.Interface.Switch.Should().Be(1);
		_ = port.Interface.Module.Should().Be(0);
		_ = port.Interface.Slot.Should().BeNull();
		_ = port.Interface.Subslot.Should().BeNull();
		_ = port.Interface.Number.Should().Be(1);
	}

	[Fact]
	public void DeserializeConfigTemplateSwitchProfilePort_NullInterfaceFields_Succeeds()
	{
		var port = Deserialize<ConfigTemplateSwitchProfilePort>("{\"portId\":\"1\",\"interface\":{\"name\":null,\"switch\":null,\"module\":null,\"slot\":null,\"subslot\":null,\"number\":null}}");

		_ = port.Interface.Should().NotBeNull();
		_ = port.Interface!.Name.Should().BeNull();
		_ = port.Interface.Number.Should().BeNull();
	}

	[Fact]
	public void DeserializeAccessPolicyRadiusServer_Radsec_Succeeds()
	{
		var server = Deserialize<RadiusServer>("{\"serverId\":\"1\",\"host\":\"192.0.2.10\",\"port\":1812,\"radsec\":{\"enabled\":false}}");

		_ = server.Radsec.Should().NotBeNull();
		_ = server.Radsec!.Enabled.Should().BeFalse();
	}

	[Fact]
	public void SerializeRadiusServer_WithoutRadsec_OmitsRadsec()
	{
		// RadiusServer is also used in update requests, so an unset radsec must not be sent
		var json = JsonConvert.SerializeObject(
			new RadiusServer { Host = "192.0.2.10", Port = 1812 },
			new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

		_ = json.Should().NotContain("radsec");
	}

	[Fact]
	public void DeserializeBrandingPolicy_Appearance_Succeeds()
	{
		var policy = Deserialize<BrandingPolicy>("{\"brandingPolicyId\":\"1\",\"name\":\"Example policy\",\"appearance\":{\"dashboardMenuTheme\":\"light\"}}");

		_ = policy.Appearance.Should().NotBeNull();
		_ = policy.Appearance!.DashboardMenuTheme.Should().Be("light");
	}

	[Fact]
	public void DeserializeVpnBgp_LocalAsNumber_Succeeds()
	{
		var bgp = Deserialize<VpnBgp>("{\"enabled\":true,\"asNumber\":64512,\"localAsNumber\":65001}");

		_ = bgp.LocalAsNumber.Should().Be(65001);
	}

	[Fact]
	public void DeserializeVpnBgp_NullLocalAsNumber_Succeeds()
	{
		var bgp = Deserialize<VpnBgp>("{\"enabled\":true,\"asNumber\":64512,\"localAsNumber\":null}");

		_ = bgp.LocalAsNumber.Should().BeNull();
	}

	[Fact]
	public void DeserializeHub_Vrfs_Succeeds()
	{
		var hub = Deserialize<Hub>("{\"hubId\":\"N_1\",\"useDefaultRoute\":false,\"vrfs\":[{\"id\":\"100000000000000001\",\"name\":\"ExampleVrfA\"},{\"id\":\"100000000000000002\",\"name\":\"ExampleVrfB\"}]}");

		_ = hub.Vrfs.Should().HaveCount(2);
		_ = hub.Vrfs![0].Id.Should().Be("100000000000000001");
		_ = hub.Vrfs[1].Name.Should().Be("ExampleVrfB");
	}

	[Fact]
	public void DeserializeStaticRoute_Vrf_Succeeds()
	{
		var route = Deserialize<StaticRoute>("{\"id\":\"1\",\"networkId\":\"N_1\",\"name\":\"Example route\",\"subnet\":\"198.51.100.0/24\",\"vrf\":{\"id\":\"100000000000000001\",\"name\":\"ExampleVrfA\"}}");

		_ = route.Vrf.Should().NotBeNull();
		_ = route.Vrf!.Id.Should().Be("100000000000000001");
		_ = route.Vrf.Name.Should().Be("ExampleVrfA");
	}
}
