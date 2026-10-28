using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Test.Data;

/// <summary>
/// Updating the site-to-site VPN settings can be answered with a 400 asking the caller to confirm
/// warnings (for example overlapping subnets) by sending changesConfirmed as true. The request
/// body must be able to carry it, and must not send it when it is not set.
/// </summary>
public class SiteToSiteVpnChangesConfirmedTests
{
	// The same null handling and enum conversion as the client's request serializer
	private static readonly JsonSerializerSettings _requestSettings = new()
	{
		NullValueHandling = NullValueHandling.Ignore,
		Converters = [new StringEnumConverter()]
	};

	[Fact]
	public void SerializeSiteToSiteVpn_ChangesConfirmedTrue_SendsChangesConfirmed()
	{
		var json = JsonConvert.SerializeObject(
			new SiteToSiteVpn { Mode = SiteToSiteVpnMode.Spoke, ChangesConfirmed = true },
			_requestSettings);

		_ = json.Should().Contain("\"changesConfirmed\":true");
	}

	[Fact]
	public void SerializeSiteToSiteVpn_ChangesConfirmedNotSet_DoesNotSendChangesConfirmed()
	{
		var json = JsonConvert.SerializeObject(
			new SiteToSiteVpn { Mode = SiteToSiteVpnMode.Spoke },
			_requestSettings);

		_ = json.Should().NotContain("changesConfirmed");
	}

	[Fact]
	public void DeserializeSiteToSiteVpn_ResponseWithoutChangesConfirmed_LeavesItNull()
	{
		var vpn = JsonConvert.DeserializeObject<SiteToSiteVpn>("{\"mode\":\"none\",\"hubs\":[],\"subnets\":[]}");

		_ = vpn!.ChangesConfirmed.Should().BeNull();
	}
}
