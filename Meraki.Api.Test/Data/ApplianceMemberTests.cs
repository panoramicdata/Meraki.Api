using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Test.Data;

/// <summary>
/// Regression tests for Appliance response members the v1.74.0 OpenAPI spec documents that the
/// models lacked. Each payload has the shape the spec documents, and is deserialized with the
/// settings <see cref="JsonMissingMemberHandling.ThrowOnError"/> uses so an unmapped field fails
/// the test rather than being dropped.
/// </summary>
public class ApplianceMemberTests
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

	// GET /networks/{networkId}/appliance/ports/{portId}
	[Fact]
	public void Deserialize_AppliancePort_MapsSgt()
	{
		var port = Deserialize<AppliancePort>("""
			{ "number": 4, "enabled": true, "type": "access", "dropUntaggedTraffic": false, "vlan": 10, "allowedVlans": "all", "accessPolicy": "open", "sgt": { "id": 1234, "enabled": true } }
			""");

		_ = port.Sgt!.Id.Should().Be(1234);
		_ = port.Sgt.Enabled.Should().BeTrue();
	}

	// GET /networks/{networkId}/appliance/vpn/siteToSiteVpn
	[Fact]
	public void Deserialize_SiteToSiteVpn_MapsSgtAndHostTranslations()
	{
		var vpn = Deserialize<SiteToSiteVpn>("""
			{ "mode": "spoke", "hubs": [], "subnets": [], "sgt": { "enabled": false }, "hostTranslations": [ { "name": "web", "local": { "address": "10.0.0.5" }, "remote": { "address": "192.0.2.5" } } ] }
			""");

		_ = vpn.Sgt!.Enabled.Should().BeFalse();
		_ = vpn.HostTranslations.Should().ContainSingle().Which.Remote!.Address.Should().Be("192.0.2.5");
	}

	// GET /networks/{networkId}/appliance/singleLan
	[Fact]
	public void Deserialize_LanConfiguration_MapsVrf()
	{
		var lan = Deserialize<LanConfiguration>("""
			{ "subnet": "10.0.0.0/24", "applianceIp": "10.0.0.1", "vrf": { "id": "1", "name": "Default" } }
			""");

		_ = lan.Vrf!.Name.Should().Be("Default");
	}

	// peers[] from GET /organizations/{organizationId}/appliance/vpn/thirdPartyVPNPeers
	[Fact]
	public void Deserialize_ThirdPartyVpnPeer_MapsEcmpUplinkConfigsAndReceiveLimit()
	{
		var peer = Deserialize<ThirdPartyVpnPeer>("""
			{ "peerId": "1", "name": "DC", "publicIp": "192.0.2.10", "privateSubnets": [ "10.1.0.0/16" ], "ikeVersion": "2", "ebgpNeighbor": { "neighborId": 1, "neighborIp": "169.254.0.2", "ipVersion": 4, "remoteAsNumber": 65001, "ebgpHoldTimer": 180, "ebgpMultihop": 2, "sourceIp": "169.254.0.1", "receiveLimit": 100, "pathPrepend": [], "multiExitDiscriminator": 1, "weight": 10 }, "ecmpUplinkConfigs": [ { "id": "1", "wan": "wan1", "privateSubnets": [ "10.1.0.0/16" ], "ebgpNeighbor": { "neighborIp": "169.254.0.2", "sourceIp": "169.254.0.1" } } ] }
			""");

		_ = peer.EbgpNeighbor!.ReceiveLimit.Should().Be(100);
		_ = peer.EcmpUplinkConfigs.Should().ContainSingle().Which.EbgpNeighbor!.NeighborIp.Should().Be("169.254.0.2");
	}

	// items[] from GET /organizations/{organizationId}/appliance/vpn/statuses - previously typed as
	// the configuration wrapper, whose only member is "peers".
	[Fact]
	public void Deserialize_VpnStatus_MapsThirdPartyVpnPeerStatuses()
	{
		var status = Deserialize<VpnStatus>("""
			{ "networkId": "N_1", "networkName": "HQ", "deviceSerial": "Q2XX-ABCD-1234", "deviceStatus": "online", "uplinks": [], "vpnMode": "hub", "exportedSubnets": [], "merakiVpnPeers": [], "thirdPartyVpnPeers": [ { "name": "DC", "publicIp": "192.0.2.10", "reachability": "reachable" } ] }
			""");

		_ = status.ThirdPartyVpnPeers.Should().ContainSingle().Which.Reachability.Should().Be("reachable");
	}

	// POST /networks/{networkId}/appliance/umbrella/account/connect
	[Fact]
	public void Deserialize_NetworkUmbrellaAccountConnectResponse_MapsUmbrella()
	{
		var response = Deserialize<NetworkUmbrellaAccountConnectResponse>("""
			{ "umbrellaOrganizationId": "1", "umbrella": { "organization": { "id": "1" } } }
			""");

		_ = response.Umbrella!.Organization!.Id.Should().Be("1");
	}

	// GET /networks/{networkId}/appliance/staticRoutes/{staticRouteId}
	[Fact]
	public void Deserialize_StaticRoute_MapsIpVersion()
	{
		var route = Deserialize<StaticRoute>("""
			{ "id": "1", "ipVersion": 4, "networkId": "N_1", "enabled": true, "name": "To DC", "subnet": "10.1.0.0/16", "gatewayIp": "10.0.0.254" }
			""");

		_ = route.IpVersion.Should().Be(4);
	}
}
