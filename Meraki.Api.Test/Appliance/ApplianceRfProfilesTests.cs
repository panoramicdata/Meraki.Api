using System.Net;

namespace Meraki.Api.Test.Appliance;

/// <summary>
/// GET /networks/{networkId}/appliance/rfProfiles returns a bare JSON array of profiles, not the object with an "assigned"
/// list that the published schema describes. No credentials or network are needed: a wrapping handler answers the request.
/// </summary>
public class ApplianceRfProfilesTests
{
	// The shape the API returns, with made-up ids and names
	private const string BareArrayResponse = """
		[{"id":"111111111111111111","networkId":"L_222222222222222222","name":"MX RF Profile","twoFourGhzSettings":{"minBitrate":36,"axEnabled":true},"fiveGhzSettings":{"minBitrate":12,"axEnabled":true},"perSsidSettings":{"1":{"bandOperationMode":"dual","bandSteeringEnabled":true},"2":{"bandOperationMode":"2.4ghz","bandSteeringEnabled":false},"3":{"bandOperationMode":"dual","bandSteeringEnabled":true},"4":{"bandOperationMode":"dual","bandSteeringEnabled":true}}}]
		""";

	[Fact]
	public async Task GetNetworkApplianceRfProfiles_BareArrayResponse_Deserializes()
	{
		var handler = new AnsweringHandler(BareArrayResponse);
		using var client = new MerakiClient(new MerakiClientOptions
		{
			ApiKey = "0000000000000000000000000000000000000000",
			UserAgent = "Meraki.Api.Test/1.0",
			MaxAttemptCount = 1,
			WrapHttpMessageHandler = handler.Around
		});

		var profiles = await client
			.Appliance
			.RfProfiles
			.GetNetworkApplianceRfProfiles("L_222222222222222222", TestContext.Current.CancellationToken);

		_ = handler.RequestUri.Should().Be("https://api.meraki.com/api/v1/networks/L_222222222222222222/appliance/rfProfiles");
		var profile = profiles.Should().ContainSingle().Subject;
		_ = profile.Id.Should().Be("111111111111111111");
		_ = profile.NetworkId.Should().Be("L_222222222222222222");
		_ = profile.Name.Should().Be("MX RF Profile");
		_ = profile.TwoFourGhzSettings!.MinBitrate.Should().Be(36);
		_ = profile.TwoFourGhzSettings.AxEnabled.Should().BeTrue();
		_ = profile.FiveGhzSettings!.MinBitrate.Should().Be(12);
		_ = profile.FiveGhzSettings.AxEnabled.Should().BeTrue();
		_ = profile.PerSsidSettings!.Ssid1!.BandOperationMode.Should().Be("dual");
		_ = profile.PerSsidSettings.Ssid2!.BandOperationMode.Should().Be("2.4ghz");
		_ = profile.PerSsidSettings.Ssid2.BandSteeringEnabled.Should().BeFalse();
		_ = profile.PerSsidSettings.Ssid4!.BandSteeringEnabled.Should().BeTrue();
	}

	private sealed class AnsweringHandler(string responseJson) : DelegatingHandler
	{
		public string? RequestUri { get; private set; }

		public AnsweringHandler Around(HttpMessageHandler inner)
		{
			InnerHandler = inner;
			return this;
		}

		protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			RequestUri = request.RequestUri!.ToString();
			return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
			{
				Content = new StringContent(responseJson, System.Text.Encoding.UTF8, "application/json")
			});
		}
	}
}
