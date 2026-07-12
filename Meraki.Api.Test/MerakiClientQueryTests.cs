using System.Net.Http;

namespace Meraki.Api.Test;

/// <summary>
/// Unit tests for the generic <see cref="MerakiClient.QueryAsync(HttpMethod, string, string, string, bool, System.Threading.CancellationToken)"/>
/// passthrough helpers (URI construction and Link-header pagination parsing). These require no network.
/// </summary>
public class MerakiClientQueryTests
{
	[Theory]
	[InlineData("https://api.meraki.com/api/v1", "organizations", "https://api.meraki.com/api/v1/organizations")]
	[InlineData("https://api.meraki.com/api/v1", "/organizations", "https://api.meraki.com/api/v1/organizations")]
	[InlineData("https://api.meraki.com/api/v1/", "organizations", "https://api.meraki.com/api/v1/organizations")]
	[InlineData("https://api.meraki.com/api/v1", "organizations/123/appliance/uplink/statuses?perPage=5", "https://api.meraki.com/api/v1/organizations/123/appliance/uplink/statuses?perPage=5")]
	[InlineData("https://api.meraki.cn/api/v1", "networks/L_1/appliance/trafficShaping/uplinkBandwidth", "https://api.meraki.cn/api/v1/networks/L_1/appliance/trafficShaping/uplinkBandwidth")]
	public void BuildRequestUri_PreservesApiV1SegmentAndCombinesPath(string baseAddress, string path, string expected)
	{
		var uri = MerakiClient.BuildRequestUri(new Uri(baseAddress), path);
		uri.AbsoluteUri.Should().Be(expected);
	}

	[Fact]
	public void GetNextPageUri_WithRelNext_ReturnsAbsoluteNextUriWithCursor()
	{
		using var response = new HttpResponseMessage();
		response.Headers.TryAddWithoutValidation(
			"Link",
			"<https://api.meraki.com/api/v1/organizations/123/devices?perPage=1000&startingAfter=Q2XX>; rel=next");

		var next = MerakiClient.GetNextPageUri(response.Headers);

		next.Should().NotBeNull();
		System.Web.HttpUtility.ParseQueryString(next!.Query).Get("startingAfter").Should().Be("Q2XX");
	}

	[Fact]
	public void GetNextPageUri_WithFirstAndPrevButNoNext_ReturnsNull()
	{
		using var response = new HttpResponseMessage();
		response.Headers.TryAddWithoutValidation(
			"Link",
			"<https://api.meraki.com/api/v1/x?startingAfter=A>; rel=first, <https://api.meraki.com/api/v1/x?endingBefore=B>; rel=prev");

		MerakiClient.GetNextPageUri(response.Headers).Should().BeNull();
	}

	[Fact]
	public void GetNextPageUri_WithNoLinkHeader_ReturnsNull()
	{
		using var response = new HttpResponseMessage();
		MerakiClient.GetNextPageUri(response.Headers).Should().BeNull();
	}
}
