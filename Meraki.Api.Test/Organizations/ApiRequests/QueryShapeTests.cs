using Meraki.Api.Interfaces.General.Organizations;
using Microsoft.Extensions.Logging.Abstractions;
using System.Text;

namespace Meraki.Api.Test.Organizations.ApiRequests;

/// <summary>
/// Checks the query string sent for the API request overview filters. The API documents
/// <c>userAgent</c> as a single string (partial match) and answers <c>userAgent[]</c> with
/// 400 "'userAgent' must be a string"; the id filters are arrays. The Refit client is built with the
/// same settings as <see cref="MerakiClient"/>, over a handler that records the request, so no
/// credentials or network are needed.
/// </summary>
public class QueryShapeTests
{
	[Fact]
	public async Task GetOverviewResponseCodesByInterval_SendsUserAgentAsAPlainString()
	{
		var (client, handler) = CreateClient();

		_ = await client.GetOrganizationApiRequestsOverviewResponseCodesByIntervalAsync(
			"123456",
			timespan: 3600,
			userAgent: "ExampleApp/",
			cancellationToken: TestContext.Current.CancellationToken);

		var query = handler.RequestUri!.Query;
		_ = query.Should().Contain("userAgent=ExampleApp%2F");
		_ = query.Should().NotContain("userAgent%5B%5D").And.NotContain("userAgent[]");
	}

	[Fact]
	public async Task GetOverviewResponseCodesByInterval_SendsIdFiltersAsArrays()
	{
		var (client, handler) = CreateClient();

		_ = await client.GetOrganizationApiRequestsOverviewResponseCodesByIntervalAsync(
			"123456",
			adminIds: ["111", "222"],
			cancellationToken: TestContext.Current.CancellationToken);

		_ = Uri.UnescapeDataString(handler.RequestUri!.Query).Should().Contain("adminIds[]=111&adminIds[]=222");
	}

	[Fact]
	public async Task GetOverviewResponseCodesByInterval_OmitsUserAgentWhenNull()
	{
		var (client, handler) = CreateClient();

		_ = await client.GetOrganizationApiRequestsOverviewResponseCodesByIntervalAsync(
			"123456",
			timespan: 3600,
			cancellationToken: TestContext.Current.CancellationToken);

		_ = handler.RequestUri!.Query.Should().NotContain("userAgent");
	}

	private static (IOrganizationsApiRequests Client, RecordingHandler Handler) CreateClient()
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

		return (RestService.For<IOrganizationsApiRequests>(httpClient, settings), handler);
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
			return Task.FromResult(new HttpResponseMessage(System.Net.HttpStatusCode.OK)
			{
				Content = new StringContent("[]", Encoding.UTF8, "application/json")
			});
		}
	}
}
