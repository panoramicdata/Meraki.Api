using System.Net;
using System.Reflection;
using Meraki.Api.Attributes;

namespace Meraki.Api.Test.Wireless;

/// <summary>
/// GET /organizations/{organizationId}/wireless/airMarshal/rules returns "remaining" in its meta counts and a numeric
/// "ruleId". No credentials or network are needed: a wrapping handler answers the request.
/// </summary>
public class AirMarshalRulesTests
{
	// The shape the API returns, with made-up ids, names and match strings
	private const string RulesResponse = """
		{"items":[
		{"ruleId":111111111111111111,"network":{"id":"L_222222222222222222","name":"Network A"},"type":"block","match":{"type":"contains","string":"example"},"updatedAt":"2024-01-02T03:04:05Z","createdAt":"2024-01-01T00:00:00Z"}
		],"meta":{"counts":{"items":{"total":1,"remaining":0}}}}
		""";

	[Fact]
	public async Task GetOrganizationWirelessAirMarshalRules_RealResponse_DeserializesWithoutMissingMembers()
	{
		var handler = new AnsweringHandler(RulesResponse);
		using var client = new MerakiClient(new MerakiClientOptions
		{
			ApiKey = "0000000000000000000000000000000000000000",
			UserAgent = "Meraki.Api.Test/1.0",
			MaxAttemptCount = 1,
			JsonMissingMemberHandling = JsonMissingMemberHandling.ThrowOnError,
			WrapHttpMessageHandler = handler.Around
		});

		var rules = await client
			.Wireless
			.AirMarshal
			.GetOrganizationWirelessAirMarshalRulesAsync(
				"333333",
				networkIds: ["L_222222222222222222"],
				perPage: 1000,
				startingAfter: null,
				endingBefore: null,
				TestContext.Current.CancellationToken);

		_ = handler.RequestUri.Should().StartWith("https://api.meraki.com/api/v1/organizations/333333/wireless/airMarshal/rules");
		_ = rules.Meta.Counts.Items.Total.Should().Be(1);
		_ = rules.Meta.Counts.Items.Remaining.Should().Be(0);
		var rule = rules.Items.Should().ContainSingle().Subject;
		_ = rule.RuleId.Should().Be("111111111111111111");
		_ = rule.Type.Should().Be("block");
		_ = rule.Match.Type.Should().Be("contains");
		_ = rule.Match.MatchString.Should().Be("example");
		_ = rule.Network.Id.Should().Be("L_222222222222222222");
	}

	// Only "type" and "match" can be written (see AirMarshalRuleCreateUpdateRequest); the rest is set by the API
	[Theory]
	[InlineData(nameof(AirMarshalRulesItem.RuleId))]
	[InlineData(nameof(AirMarshalRulesItem.CreatedAt))]
	[InlineData(nameof(AirMarshalRulesItem.UpdatedAt))]
	[InlineData(nameof(AirMarshalRulesItem.Network))]
	public void AirMarshalRulesItem_ApiSetProperty_IsReadOnly(string propertyName)
		=> typeof(AirMarshalRulesItem).GetProperty(propertyName)!
			.GetCustomAttribute<ApiAccessAttribute>()!
			.ApiAccess.Should().Be(ApiAccess.Read);

	[Fact]
	public void AirMarshalRulesItem_RuleId_IsTheKey()
		=> typeof(AirMarshalRulesItem).GetProperty(nameof(AirMarshalRulesItem.RuleId))!
			.GetCustomAttribute<ApiKeyAttribute>()
			.Should().NotBeNull();

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
