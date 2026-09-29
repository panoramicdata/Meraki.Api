using Meraki.Api.Interfaces.General.Organizations;
using Meraki.Api.Interfaces.Products.Camera;
using Microsoft.Extensions.Logging.Abstractions;
using System.Net;
using System.Text;

namespace Meraki.Api.Test.Client;

/// <summary>
/// Regression tests for methods whose route has an <c>{organizationId}</c> placeholder with no
/// parameter to fill it. Refit throws an <see cref="ArgumentException"/> before sending, so every
/// call failed; Refit 16's RF015 analyzer rejects the declarations at build time. The Refit client is
/// built with the same settings as <see cref="MerakiClient"/>, over a handler that records the
/// request, so no credentials or network are needed.
/// </summary>
public class UnmatchedRouteParameterTests
{
	private const string OrganizationId = "123456";

	[Fact]
	public async Task CreateOrganizationCameraCustomAnalyticsArtifact_SendsOrganizationIdInPath()
	{
		var (client, handler) = CreateClient<ICameraCustomAnalyticsArtifacts>();

		_ = await client.CreateOrganizationCameraCustomAnalyticsArtifactAsync(
			OrganizationId,
			new CameraCustomAnalyticsArtifactCreateRequest { Name = "People counter" },
			TestContext.Current.CancellationToken);

		_ = handler.RequestUri!.AbsoluteUri.Should().Be("https://api.meraki.com/api/v1/organizations/123456/camera/customAnalytics/artifacts");
		_ = handler.Method.Should().Be(HttpMethod.Post);
	}

	[Fact]
	public async Task UpdateOrganizationApplianceVpnSiteToSiteIpsecPeersSlas_SendsOrganizationIdInPath()
	{
		var (client, handler) = CreateClient<IOrganizationsVpnSiteToSiteIpsec>();

		_ = await client.UpdateOrganizationApplianceVpnSiteToSiteIpsecPeersSlasAsync(
			OrganizationId,
			new OrganizationApplianceVpnSiteToSiteIpsecPeersSlasUpdateRequest(),
			TestContext.Current.CancellationToken);

		_ = handler.RequestUri!.AbsoluteUri.Should().Be("https://api.meraki.com/api/v1/organizations/123456/appliance/vpn/siteToSite/ipsec/peers/slas");
		_ = handler.Method.Should().Be(HttpMethod.Put);
	}

	private static (T Client, RecordingHandler Handler) CreateClient<T>()
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

		return (RestService.For<T>(httpClient, settings), handler);
	}

	/// <summary>
	/// Records the request and answers with an empty object.
	/// </summary>
	private sealed class RecordingHandler : HttpMessageHandler
	{
		public Uri? RequestUri { get; private set; }

		public HttpMethod? Method { get; private set; }

		// S1172: the signature is HttpMessageHandler's, so the unused token cannot be removed.
#pragma warning disable S1172 // Unused method parameters should be removed
		protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
#pragma warning restore S1172 // Unused method parameters should be removed
		{
			RequestUri = request.RequestUri;
			Method = request.Method;
			return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
			{
				RequestMessage = request,
				Content = new StringContent("{}", Encoding.UTF8, "application/json")
			});
		}
	}
}
