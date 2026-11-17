using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Newtonsoft.Json;

namespace Meraki.Api.Test.Data;

/// <summary>
/// Offline tests for issues 438, 439 and 440: enum members and decimal values the Dashboard API returns, and the
/// opt-in tolerance of unknown enum values
/// </summary>
public class DashboardResponseToleranceTests
{
	private sealed class Holder
	{
		[JsonProperty("rule")]
		public Layer7FirewallRuleType Rule { get; set; }

		[JsonProperty("maybe")]
		public Layer7FirewallRuleType? Maybe { get; set; }

		[JsonProperty("product")]
		public ProductType Product { get; set; }
	}

	private static async Task<T?> ReadAsync<T>(string json, UnknownEnumValueHandling handling = UnknownEnumValueHandling.Throw, ILogger? logger = null)
	{
		var serializer = new CustomNewtonsoftJsonContentSerializer(
			new MerakiClientOptions { UnknownEnumValueHandling = handling },
			logger ?? NullLogger.Instance);
		using var content = new StringContent(json);
		return await serializer.FromHttpContentAsync<T>(content, TestContext.Current.CancellationToken);
	}

	[Theory]
	[InlineData("allowedCountries", Layer7FirewallRuleType.AllowedCountries)]
	[InlineData("blacklistedCountries", Layer7FirewallRuleType.BlacklistedCountries)]
	[InlineData("whitelistedCountries", Layer7FirewallRuleType.WhitelistedCountries)]
	public void Layer7FirewallRuleType_RoundTripsNewMembers(string wire, Layer7FirewallRuleType expected)
		=> RoundTrip(wire, expected);

	[Fact]
	public void SplashPage_RoundTripsMicrosoftEntraId()
		=> RoundTrip("Microsoft Entra ID", SplashPage.MicrosoftEntraId);

	[Theory]
	[InlineData("8021x-entra", AuthMode.Auth8021xEntra)]
	[InlineData("ipsk-with-radius-easy-psk", AuthMode.IpskWithRadiusEasyPsk)]
	[InlineData("open-enhanced-with-radius", AuthMode.OpenEnhancedWithRadius)]
	public void AuthMode_RoundTripsNewMembers(string wire, AuthMode expected)
		=> RoundTrip(wire, expected);

	[Fact]
	public void ProductType_RoundTripsCampusGateway()
		=> RoundTrip("campusGateway", ProductType.CampusGateway);

	private static void RoundTrip<T>(string wire, T expected)
	{
		var json = JsonConvert.SerializeObject(expected);
		_ = json.Should().Be($"\"{wire}\"");
		_ = JsonConvert.DeserializeObject<T>(json).Should().Be(expected);
	}

	[Fact]
	public void LatencyOverall_ReadsDecimalAndWholeAverage()
	{
		_ = JsonConvert.DeserializeObject<OrganizationWirelessDevicesLatencyByItemOverall>("""{"average":20.06}""")!.Average.Should().Be(20.06);
		_ = JsonConvert.DeserializeObject<OrganizationWirelessDevicesLatencyByItemOverall>("""{"average":48.0}""")!.Average.Should().Be(48);
	}

	[Fact]
	public void PacketLoss_ReadsDecimalAndWholePercentages()
	{
		var down = JsonConvert.DeserializeObject<OrganizationWirelessDevicesPacketLossItemDownstream>("""{"lossPercentage":0.2}""")!;
		var up = JsonConvert.DeserializeObject<OrganizationWirelessDevicesPacketLossItemUpstream>("""{"lossPercentage":9.35}""")!;
		_ = down.LossPercentage.Should().Be(0.2);
		_ = up.LossPercentage.Should().Be(9.35);
		_ = JsonConvert.DeserializeObject<OrganizationWirelessDevicesPacketLossItemUpstream>("""{"lossPercentage":48.0}""")!.LossPercentage.Should().Be(48);
	}

	[Fact]
	public void ChannelUtilization_ReadsDecimalAndWholePercentages()
	{
		_ = JsonConvert.DeserializeObject<OrganizationWirelessDevicesChannelUtilizationByBandItemWifi>("""{"percentage":20.06}""")!.Percentage.Should().Be(20.06);
		_ = JsonConvert.DeserializeObject<OrganizationWirelessDevicesChannelUtilizationByBandItemNonWifi>("""{"percentage":0.2}""")!.Percentage.Should().Be(0.2);
		_ = JsonConvert.DeserializeObject<OrganizationWirelessDevicesChannelUtilizationByBandItemTotal>("""{"percentage":48.0}""")!.Percentage.Should().Be(48);
	}

	[Fact]
	public async Task UnknownEnumValue_ByDefault_FailsTheCall()
	{
		var act = () => ReadAsync<Holder>("""{"rule":"somethingNew"}""");
		_ = await act.Should().ThrowAsync<JsonSerializationException>();
	}

	[Fact]
	public async Task UnknownEnumValue_UseDefault_ReadsNullForNullableAndFirstMemberForNonNullable()
	{
		var holder = await ReadAsync<Holder>(
			"""{"rule":"somethingNew","maybe":"alsoNew","product":"futureProduct"}""",
			UnknownEnumValueHandling.UseDefault);

		_ = holder!.Rule.Should().Be(Layer7FirewallRuleType.Application);
		_ = holder.Maybe.Should().BeNull();
		_ = holder.Product.Should().Be(ProductType.Wireless);
	}

	[Fact]
	public async Task UnknownEnumValue_UseDefault_StillReadsKnownValuesAndAttributeDeclaredEnums()
	{
		var holder = await ReadAsync<Holder>(
			"""{"rule":"host","maybe":"port","product":"campusGateway"}""",
			UnknownEnumValueHandling.UseDefault);

		_ = holder!.Rule.Should().Be(Layer7FirewallRuleType.Host);
		_ = holder.Maybe.Should().Be(Layer7FirewallRuleType.Port);
		_ = holder.Product.Should().Be(ProductType.CampusGateway);
	}

	[Fact]
	public async Task UnknownEnumValue_UseDefault_LogsAWarningNamingThePropertyAndValue()
	{
		var logger = new CapturingLogger();

		_ = await ReadAsync<Holder>("""{"rule":"somethingNew"}""", UnknownEnumValueHandling.UseDefault, logger);

		_ = logger.Messages.Should().ContainSingle()
			.Which.Should().Contain("somethingNew").And.Contain("rule");
	}

	private sealed class CapturingLogger : ILogger
	{
		public List<string> Messages { get; } = [];

		public IDisposable? BeginScope<TState>(TState state) where TState : notnull => null;

		public bool IsEnabled(LogLevel logLevel) => true;

		public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
			=> Messages.Add(formatter(state, exception));
	}
}
