using Meraki.Api.Interfaces.Products.Appliance;
using Meraki.Api.Interfaces.Products.CellularGateway;
using Meraki.Api.Interfaces.Products.Wireless;
using Microsoft.Extensions.Logging.Abstractions;
using System.Net;
using System.Text;
using System.Web;

namespace Meraki.Api.Test;

/// <summary>
/// The AllAsync helpers for wireless packet loss by device, and for appliance and cellular gateway uplink
/// statuses, follow the Link header across every page
/// (<see href="https://github.com/panoramicdata/Meraki.Api/issues/435">issue 435</see>). The Refit clients are
/// built with the same settings as <see cref="MerakiClient"/>, over a handler that serves canned pages, so no
/// credentials or network are needed.
/// </summary>
public class UplinkStatusesAndPacketLossPagingTests
{
	private const string OrganizationId = "123456";

	[Fact]
	public async Task PacketLossAll_FollowsTheNextLink_AndSendsTheWindowOnEveryPage()
	{
		var handler = new PagingHandler(
			"""[{"device":{"serial":"Q2AA-0000-0001"}}]""",
			"""[{"device":{"serial":"Q2AA-0000-0002"}}]""");

		var all = await CreateClient<IWirelessDevicePacketLoss>(handler)
			.GetOrganizationWirelessDevicesPacketLossAllAsync(OrganizationId, timespan: 3600, cancellationToken: TestContext.Current.CancellationToken);

		_ = all.Select(item => item.Device!.Serial).Should().Equal("Q2AA-0000-0001", "Q2AA-0000-0002");
		_ = handler.Requests.Should().HaveCount(2)
			.And.OnlyContain(uri => uri.AbsolutePath == "/api/v1/organizations/123456/wireless/devices/packetLoss/byDevice"
				&& HttpUtility.ParseQueryString(uri.Query)["timespan"] == "3600");
		_ = handler.Requests.Select(uri => HttpUtility.ParseQueryString(uri.Query)["startingAfter"]).Should().Equal(null, "page2");
	}

	[Fact]
	public async Task ApplianceUplinkStatusesAll_FollowsEveryNextLink_AndSendsTheFiltersOnEveryPage()
	{
		var handler = new PagingHandler(
			"""[{"serial":"Q2MX-0000-0001"}]""",
			"""[{"serial":"Q2MX-0000-0002"}]""",
			"""[{"serial":"Q2MX-0000-0003"}]""");

		var all = await CreateClient<IApplianceUplinkStatuses>(handler)
			.GetOrganizationApplianceUplinkStatusesAllAsync(
				OrganizationId,
				serials: ["Q2MX-0000-0001", "Q2MX-0000-0002", "Q2MX-0000-0003"],
				cancellationToken: TestContext.Current.CancellationToken);

		_ = all.Select(status => status.Serial).Should().Equal("Q2MX-0000-0001", "Q2MX-0000-0002", "Q2MX-0000-0003");
		_ = handler.Requests.Should().HaveCount(3)
			.And.OnlyContain(uri => uri.AbsolutePath == "/api/v1/organizations/123456/appliance/uplink/statuses"
				&& HttpUtility.ParseQueryString(uri.Query).GetValues("serials[]")!.Length == 3);
		_ = handler.Requests.Select(uri => HttpUtility.ParseQueryString(uri.Query)["startingAfter"]).Should().Equal(null, "page2", "page3");
	}

	[Fact]
	public async Task CellularGatewayUplinkStatusesAll_OnePage_MakesOneRequest()
	{
		var handler = new PagingHandler("""[{"serial":"Q2MG-0000-0001"}]""");

		var all = await CreateClient<ICellularGatewayUplinkStatuses>(handler)
			.GetOrganizationCellularGatewayUplinkStatusesAllAsync(OrganizationId, cancellationToken: TestContext.Current.CancellationToken);

		_ = all.Should().ContainSingle().Which.Serial.Should().Be("Q2MG-0000-0001");
		_ = handler.Requests.Should().ContainSingle().Which.AbsolutePath.Should().Be("/api/v1/organizations/123456/cellularGateway/uplink/statuses");
	}

	[Fact]
	public async Task CellularGatewayUplinkStatusesAll_LaterPageFails_ThrowsRatherThanReturningTheFirstPage()
	{
		var handler = new PagingHandler("""[{"serial":"Q2MG-0000-0001"}]""", null);

		var act = () => CreateClient<ICellularGatewayUplinkStatuses>(handler)
			.GetOrganizationCellularGatewayUplinkStatusesAllAsync(OrganizationId, cancellationToken: TestContext.Current.CancellationToken);

		_ = (await act.Should().ThrowAsync<ApiException>()).Which.StatusCode.Should().Be(HttpStatusCode.InternalServerError);
		_ = handler.Requests.Should().HaveCount(2);
	}

	private static T CreateClient<T>(HttpMessageHandler handler)
	{
		var options = new MerakiClientOptions
		{
			ApiKey = "0000000000000000000000000000000000000000",
			UserAgent = "Meraki.Api.Test/1.0"
		};

		var httpClient = new HttpClient(handler) { BaseAddress = new Uri("https://api.meraki.com/api/v1") };

		// Must match the RefitSettings in the MerakiClient constructor.
		var settings = new RefitSettings
		{
			ContentSerializer = new CustomNewtonsoftJsonContentSerializer(options, NullLogger.Instance),
			CollectionFormat = CollectionFormat.Multi
		};

		return RestService.For<T>(httpClient, settings);
	}

	/// <summary>
	/// Serves the pages in order, each linking to the next with a rel=next Link header, and records every
	/// request. A null page answers 500.
	/// </summary>
	private sealed class PagingHandler(params string?[] pages) : HttpMessageHandler
	{
		public List<Uri> Requests { get; } = [];

		// S1172: the signature is HttpMessageHandler's, so the unused token cannot be removed.
#pragma warning disable S1172 // Unused method parameters should be removed
		protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
#pragma warning restore S1172 // Unused method parameters should be removed
		{
			Requests.Add(request.RequestUri!);
			var pageIndex = Requests.Count - 1;
			var page = pages[pageIndex];
			if (page is null)
			{
				return Task.FromResult(new HttpResponseMessage(HttpStatusCode.InternalServerError) { RequestMessage = request });
			}

			var response = new HttpResponseMessage(HttpStatusCode.OK)
			{
				RequestMessage = request,
				Content = new StringContent(page, Encoding.UTF8, "application/json")
			};

			if (pageIndex + 1 < pages.Length)
			{
				var nextPage = $"{request.RequestUri!.GetLeftPart(UriPartial.Path)}?startingAfter=page{pageIndex + 2}";
				_ = response.Headers.TryAddWithoutValidation("Link", $"<{nextPage}>; rel=next");
			}

			return Task.FromResult(response);
		}
	}
}
