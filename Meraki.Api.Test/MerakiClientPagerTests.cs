using Meraki.Api.Exceptions;
using System.Net;
using System.Net.Http.Headers;

namespace Meraki.Api.Test;

/// <summary>
/// Link-header parsing and page-following behaviour of the pagination helpers
/// (<see href="https://github.com/panoramicdata/Meraki.Api/issues/356">issue 356</see>).
/// No credentials or network are needed.
/// </summary>
public class MerakiClientPagerTests
{
	private const string Page2Url = "https://api.meraki.com/api/v1/organizations/123/devices?perPage=1000&startingAfter=Q2XX";

	private static HttpResponseHeaders HeadersWithLink(string link)
	{
		var response = new HttpResponseMessage();
		_ = response.Headers.TryAddWithoutValidation("Link", link);
		return response.Headers;
	}

	[Fact]
	public void GetNextPageUri_WithExtraLinkAttribute_StillReturnsTheNextUri()
	{
		var headers = HeadersWithLink($"<{Page2Url}>; rel=next; title=\"next page\"");

		var next = MerakiClient.GetNextPageUri(headers);

		_ = next.Should().Be(new Uri(Page2Url));
	}

	[Fact]
	public void GetNextPageUri_WithQuotedRelValue_StillReturnsTheNextUri()
	{
		var headers = HeadersWithLink($"<{Page2Url}>; rel=\"next\"");

		var next = MerakiClient.GetNextPageUri(headers);

		_ = next.Should().Be(new Uri(Page2Url));
	}

	[Fact]
	public void GetNextPageUri_WithTwoNextSegments_ReturnsTheFirstRatherThanThrowing()
	{
		var headers = HeadersWithLink($"<{Page2Url}>; rel=next, <https://api.meraki.com/api/v1/other>; rel=next");

		var next = MerakiClient.GetNextPageUri(headers);

		_ = next.Should().Be(new Uri(Page2Url));
	}

	[Theory]
	[InlineData("<>; rel=next")]
	[InlineData("<not a url>; rel=next")]
	[InlineData("<organizations/123/devices?startingAfter=Q2XX>; rel=next")]
	public void GetNextPageUri_WithNextLinkThatCannotBeFollowed_Throws(string link)
	{
		var headers = HeadersWithLink(link);

		var act = () => MerakiClient.GetNextPageUri(headers);

		_ = act.Should().Throw<PaginationException>().WithMessage("*rel=next*");
	}

	[Fact]
	public async Task GetAllAsync_FollowsANextLinkThatCarriesExtraAttributes()
	{
		var pagesRequested = new List<string?>();

		var all = await MerakiClient.GetAllAsync<string>(
			(startingAfter, _, _) =>
			{
				pagesRequested.Add(startingAfter);
				return Task.FromResult(startingAfter is null
					? Page(["a", "b"], $"<{Page2Url}>; rel=next; title=\"next page\"")
					: Page(["c"], link: null));
			},
			TestContext.Current.CancellationToken);

		_ = all.Should().Equal("a", "b", "c");
		_ = pagesRequested.Should().Equal(null, "Q2XX");
	}

	[Fact]
	public async Task GetAllAsync_WithANextLinkThatCannotBeFollowed_ThrowsRatherThanReturningTruncatedData()
	{
		var act = () => MerakiClient.GetAllAsync<string>(
			(_, _, _) => Task.FromResult(Page(["a", "b"], "<not a url>; rel=next")),
			TestContext.Current.CancellationToken);

		_ = await act.Should().ThrowAsync<PaginationException>();
	}

	private static ApiResponse<List<string>> Page(List<string> items, string? link)
	{
		var response = new HttpResponseMessage(HttpStatusCode.OK)
		{
			RequestMessage = new HttpRequestMessage(HttpMethod.Get, "https://api.meraki.com/api/v1/organizations/123/devices")
		};
		if (link is not null)
		{
			_ = response.Headers.TryAddWithoutValidation("Link", link);
		}

		return new ApiResponse<List<string>>(response, items, new RefitSettings());
	}
}
