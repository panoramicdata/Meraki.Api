using Newtonsoft.Json;

namespace Meraki.Api.Test.Data;

/// <summary>
/// Members the live API returns that the models lacked. Deserializing with
/// MissingMemberHandling.Error, as JsonMissingMemberHandling.ThrowOnError does, fails on any
/// member the model lacks. All sample values are invented.
/// </summary>
public class MissingMembers20261025Tests
{
	private static readonly JsonSerializerSettings _strictSettings = new()
	{
		MissingMemberHandling = MissingMemberHandling.Error
	};

	private static T Deserialize<T>(string json)
		=> JsonConvert.DeserializeObject<T>(json, _strictSettings)!;

	[Fact]
	public void DeserializeSiteToSiteVpn_NatTraversal_Succeeds()
	{
		var vpn = Deserialize<SiteToSiteVpn>("{\"mode\":\"spoke\",\"hubs\":[{\"hubId\":\"N_1234567890\",\"useDefaultRoute\":false}],\"subnets\":[],\"natTraversal\":{\"mode\":\"automatic\"}}");

		_ = vpn.Mode.Should().Be(SiteToSiteVpnMode.Spoke);
		_ = vpn.NatTraversal.Should().NotBeNull();
		_ = vpn.NatTraversal!.Mode.Should().Be("automatic");
	}

	[Fact]
	public void DeserializeSiteToSiteVpn_ManualNatTraversal_Succeeds()
	{
		var vpn = Deserialize<SiteToSiteVpn>("{\"mode\":\"spoke\",\"hubs\":[],\"subnets\":[],\"natTraversal\":{\"mode\":\"manual\",\"publicIp\":\"203.0.113.10\",\"publicPort\":45678}}");

		_ = vpn.NatTraversal.Should().NotBeNull();
		_ = vpn.NatTraversal!.Mode.Should().Be("manual");
		_ = vpn.NatTraversal.PublicIp.Should().Be("203.0.113.10");
		_ = vpn.NatTraversal.PublicPort.Should().Be(45678);
	}

	[Fact]
	public void DeserializeVpnBgp_NeighborExplicitOutboundRouteAdvertisement_Succeeds()
	{
		var bgp = Deserialize<VpnBgp>("{\"enabled\":true,\"asNumber\":64515,\"ibgpHoldTimer\":120,\"neighbors\":[{\"ip\":\"192.0.2.10\",\"remoteAsNumber\":64516,\"filter\":{\"out\":null},\"explicitOutboundRouteAdvertisement\":{\"enabled\":true}}]}");

		var neighbor = bgp.Neighbors.Should().ContainSingle().Subject;
		_ = neighbor.ExplicitOutboundRouteAdvertisement.Should().NotBeNull();
		_ = neighbor.ExplicitOutboundRouteAdvertisement!.Enabled.Should().BeTrue();
	}

	[Fact]
	public void DeserializeVpnBgp_NeighborFilterWithNullOut_Succeeds()
	{
		var bgp = Deserialize<VpnBgp>("{\"enabled\":true,\"asNumber\":64515,\"ibgpHoldTimer\":120,\"neighbors\":[{\"ip\":\"192.0.2.10\",\"remoteAsNumber\":64516,\"filter\":{\"out\":null}}]}");

		var neighbor = bgp.Neighbors.Should().ContainSingle().Subject;
		_ = neighbor.Filter.Should().NotBeNull();
		_ = neighbor.Filter!.Out.Should().BeNull();
	}

	[Fact]
	public void DeserializeNeighbor_FilterWithOut_Succeeds()
	{
		var neighbor = Deserialize<Neighbor>("{\"ip\":\"192.0.2.10\",\"filter\":{\"out\":[\"198.51.100.0/24\",\"203.0.113.5/32\"]}}");

		_ = neighbor.Filter.Should().NotBeNull();
		_ = neighbor.Filter!.Out.Should().Equal("198.51.100.0/24", "203.0.113.5/32");
	}

	[Fact]
	public void DeserializeWirelessRfProfiles_Weatherized_Succeeds()
	{
		var profiles = Deserialize<List<WirelessRfProfile>>("[{\"id\":\"1234567890\",\"networkId\":\"L_1234567890\",\"name\":\"Outdoor profile\",\"weatherized\":{\"deployment\":{\"mode\":\"outdoor\"}}}]");

		var profile = profiles.Should().ContainSingle().Subject;
		_ = profile.Weatherized.Should().NotBeNull();
		_ = profile.Weatherized!.Deployment.Should().NotBeNull();
		_ = profile.Weatherized.Deployment!.Mode.Should().Be("outdoor");
	}
}
