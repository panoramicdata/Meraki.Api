namespace Meraki.Api.Test.Organizations.Wireless.Radio;

public class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	// Confirmed not every org supports this endpoint (some return 404) -
	// a failure here may mean the current TestOrganizationId lacks the RF Health feature, not a code regression.
	[Fact]
	public async Task GetOrganizationWirelessRadioRfHealthOverviewByNetworkByInterval_Succeeds()
	{
		var result = await TestMerakiClient
			.Wireless
			.Radio
			.RfHealth
			.GetOrganizationWirelessRadioRfHealthOverviewByNetworkByIntervalAsync(
				Configuration.TestOrganizationId,
				interval: 86400,
				cancellationToken: CancellationToken);

		_ = result.Should().NotBeNull();
		_ = result.Items.Should().NotBeEmpty();

		var firstItem = result.Items[0];
		_ = firstItem.Network.Id.Should().NotBeNullOrEmpty();
		_ = firstItem.Network.Name.Should().NotBeNullOrEmpty();
		_ = firstItem.Readings.Should().NotBeEmpty();

		var firstReading = firstItem.Readings[0];
		_ = firstReading.StartTs.Should().NotBeNullOrEmpty();
		_ = firstReading.EndTs.Should().NotBeNullOrEmpty();
		_ = firstReading.HealthMetrics.ByBand.Should().NotBeEmpty();

		var firstBand = firstReading.HealthMetrics.ByBand[0];
		_ = firstBand.Band.Should().NotBeNullOrEmpty();
	}

	[Fact]
	public async Task GetOrganizationWirelessRadioRfHealthOverviewByNetworkByInterval_InvalidInterval_Throws()
	{
		Func<Task> action = async ()
			=> _ = await TestMerakiClient
				.Wireless
				.Radio
				.RfHealth
				.GetOrganizationWirelessRadioRfHealthOverviewByNetworkByIntervalAsync(
					Configuration.TestOrganizationId,
					interval: 3600,
					cancellationToken: CancellationToken);

		_ = await action.Should().ThrowAsync<ApiException>();
	}

	[Fact]
	public async Task GetOrganizationWirelessRadioRfHealthOverviewByNetworkByInterval_MaxTimespan_Succeeds()
	{
		var result = await TestMerakiClient
			.Wireless
			.Radio
			.RfHealth
			.GetOrganizationWirelessRadioRfHealthOverviewByNetworkByIntervalAsync(
				Configuration.TestOrganizationId,
				timespan: 2629746,
				cancellationToken: CancellationToken);

		_ = result.Should().NotBeNull();
		_ = result.Items.Should().NotBeEmpty();
	}
}
