using Meraki.Api.Interfaces.General.Organizations;
using Microsoft.Extensions.Logging.Abstractions;
using System.Net;
using System.Text;
using System.Web;

namespace Meraki.Api.Test.Organizations.ApplianceUplinksUsage;

/// <summary>
/// The window parameters of getOrganizationApplianceUplinksUsageByNetwork
/// (<see href="https://github.com/panoramicdata/Meraki.Api/issues/428">issue 428</see>) reach the query
/// string under Meraki's names, and are left out when not given. The Refit client is built with the same
/// settings as <see cref="MerakiClient"/>, over a handler that records the request, so no credentials or
/// network are needed.
/// </summary>
public class UplinksUsageByNetworkRequestTests
{
	private const string OrganizationId = "123456";
	private const string ExpectedPath = "https://api.meraki.com/api/v1/organizations/123456/appliance/uplinks/usage/byNetwork";

	[Fact]
	public async Task NoWindow_SendsNoQueryString()
	{
		var (client, handler) = CreateClient();

		_ = await client.GetOrganizationApplianceUplinksUsageByNetworkAsync(OrganizationId, cancellationToken: TestContext.Current.CancellationToken);

		_ = handler.RequestUri.Should().NotBeNull();
		_ = handler.RequestUri!.AbsoluteUri.Should().Be(ExpectedPath);
	}

	[Fact]
	public async Task T0AndT1_AreSentAsGiven_WithoutTimespan()
	{
		var (client, handler) = CreateClient();

		_ = await client.GetOrganizationApplianceUplinksUsageByNetworkAsync(
			OrganizationId,
			t0: "2026-09-24T05:22:00Z",
			t1: "2026-09-24T05:27:00Z",
			cancellationToken: TestContext.Current.CancellationToken);

		var uri = handler.RequestUri!;
		var query = HttpUtility.ParseQueryString(uri.Query);
		_ = uri.GetLeftPart(UriPartial.Path).Should().Be(ExpectedPath);
		_ = query.AllKeys.Should().BeEquivalentTo("t0", "t1");
		_ = query["t0"].Should().Be("2026-09-24T05:22:00Z");
		_ = query["t1"].Should().Be("2026-09-24T05:27:00Z");
	}

	[Fact]
	public async Task Timespan_IsSentInSeconds_WithoutT0OrT1()
	{
		var (client, handler) = CreateClient();

		_ = await client.GetOrganizationApplianceUplinksUsageByNetworkAsync(
			OrganizationId,
			timespan: 300,
			cancellationToken: TestContext.Current.CancellationToken);

		var uri = handler.RequestUri!;
		var query = HttpUtility.ParseQueryString(uri.Query);
		_ = uri.GetLeftPart(UriPartial.Path).Should().Be(ExpectedPath);
		_ = query.AllKeys.Should().BeEquivalentTo("timespan");
		_ = query["timespan"].Should().Be("300");
	}

	private static (IOrganizationsApplianceUplinksUsage Client, RecordingHandler Handler) CreateClient()
	{
		var options = new MerakiClientOptions
		{
			ApiKey = "0000000000000000000000000000000000000000",
			UserAgent = "Meraki.Api.Test/1.0"
		};

		var handler = new RecordingHandler();
		var httpClient = new HttpClient(handler) { BaseAddress = new Uri("https://api.meraki.com/api/v1") };

		// Must match the RefitSettings in the MerakiClient constructor.
		var settings = new RefitSettings
		{
			ContentSerializer = new CustomNewtonsoftJsonContentSerializer(options, NullLogger.Instance),
			CollectionFormat = CollectionFormat.Multi
		};

		return (RestService.For<IOrganizationsApplianceUplinksUsage>(httpClient, settings), handler);
	}

	/// <summary>
	/// Records the request and answers with an empty list.
	/// </summary>
	private sealed class RecordingHandler : HttpMessageHandler
	{
		public Uri? RequestUri { get; private set; }

		// S1172: the signature is HttpMessageHandler's, so the unused token cannot be removed.
#pragma warning disable S1172 // Unused method parameters should be removed
		protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
#pragma warning restore S1172 // Unused method parameters should be removed
		{
			RequestUri = request.RequestUri;
			return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
			{
				RequestMessage = request,
				Content = new StringContent("[]", Encoding.UTF8, "application/json")
			});
		}
	}
}
