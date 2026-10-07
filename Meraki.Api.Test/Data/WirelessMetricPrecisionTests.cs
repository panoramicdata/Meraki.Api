using Newtonsoft.Json;

namespace Meraki.Api.Test.Data;

public class WirelessMetricPrecisionTests
{
	[Theory]
	[InlineData("12.5", 12.5)]
	[InlineData("48.0", 48.0)]
	[InlineData("7", 7.0)]
	public void DeserializeLatencyOverall_Average_AcceptsDecimals(string json, double expected)
	{
		var value = JsonConvert.DeserializeObject<OrganizationWirelessDevicesLatencyByItemOverall>($"{{\"average\":{json}}}");

		_ = value!.Average.Should().Be(expected);
	}

	[Theory]
	[InlineData("0.35", 0.35)]
	[InlineData("2.0", 2.0)]
	public void DeserializePacketLoss_LossPercentage_AcceptsDecimals(string json, double expected)
	{
		var downstream = JsonConvert.DeserializeObject<OrganizationWirelessDevicesPacketLossItemDownstream>($"{{\"lossPercentage\":{json}}}");
		var upstream = JsonConvert.DeserializeObject<OrganizationWirelessDevicesPacketLossItemUpstream>($"{{\"lossPercentage\":{json}}}");

		_ = downstream!.LossPercentage.Should().Be(expected);
		_ = upstream!.LossPercentage.Should().Be(expected);
	}

	[Theory]
	[InlineData("33.7", 33.7)]
	[InlineData("48.0", 48.0)]
	public void DeserializeChannelUtilizationByBand_Percentage_AcceptsDecimals(string json, double expected)
	{
		var body = $"{{\"percentage\":{json}}}";

		_ = JsonConvert.DeserializeObject<OrganizationWirelessDevicesChannelUtilizationByBandItemWifi>(body)!.Percentage.Should().Be(expected);
		_ = JsonConvert.DeserializeObject<OrganizationWirelessDevicesChannelUtilizationByBandItemNonWifi>(body)!.Percentage.Should().Be(expected);
		_ = JsonConvert.DeserializeObject<OrganizationWirelessDevicesChannelUtilizationByBandItemTotal>(body)!.Percentage.Should().Be(expected);
	}
}
