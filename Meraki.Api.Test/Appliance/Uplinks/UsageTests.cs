using System.Globalization;
using System.Net;

namespace Meraki.Api.Test.Appliance.Uplinks;

public class UsageTests(ITestOutputHelper testOutputHelper) : MerakiClientTest(testOutputHelper)
{
	// MS-24442: Meraki serves appliance uplink usageHistory only for t0 within ~30 days of "now",
	// and this cap is the same at ALL resolutions. Verified 2026-06-16 against the live test org:
	// 30d ago succeeds, 31d/60d ago fail with 400 "timespan goes too far into the past", identical
	// for resolutions 60/300/600/1800/3600/86400. A coarser resolution does NOT extend the window.
	// Separately, the documented "t1 max 14 days after t0" span limit is NOT enforced: spans up to
	// at least 29 days return data at hourly resolution (bounded in practice only by the ~30-day
	// lookback), so the whole available window can be fetched in a single call.
	private const int ApproxMaxLookbackDays = 30;

	[Fact]
	public async Task GetNetworkApplianceUplinksUsageHistory_Succeeds()
	{
		// Get Appliance Networks
		var networks = await TestMerakiClient
			.Organizations
			.Networks
			.GetOrganizationNetworksAsync(
				Configuration.TestOrganizationId,
				productTypes: [ProductType.Appliance],
				cancellationToken: CancellationToken);

		if (networks.Count == 0)
		{
			// No appliance networks to test
			return;
		}

		// Get the first appliance network
		var applianceNetwork = networks.First();

		// Get the uplink usage history
		var uplinkUsageHistory = await TestMerakiClient
			.Appliance
			.Uplinks
			.UsageHistory
			.GetNetworkApplianceUplinksUsageHistoryAsync(
				applianceNetwork.Id,
				timespan: 7200,
				cancellationToken: CancellationToken);

		_ = uplinkUsageHistory.Should().NotBeNull();
	}

	/// <summary>
	/// MS-24442: A window comfortably inside the ~30-day lookback limit returns data.
	/// </summary>
	[Fact]
	public async Task GetNetworkApplianceUplinksUsageHistory_WithinLookbackLimit_ReturnsData()
	{
		var applianceNetwork = await GetFirstApplianceNetworkAsync();

		// 7 days ago is well inside the ~30-day limit.
		var t0 = HourAligned(UtcNow.AddDays(-7));
		var t1 = t0.AddDays(1);

		var history = await TestMerakiClient
			.Appliance
			.Uplinks
			.UsageHistory
			.GetNetworkApplianceUplinksUsageHistoryAsync(
				applianceNetwork.Id,
				t0: Format(t0),
				t1: Format(t1),
				resolution: 3600,
				cancellationToken: CancellationToken);

		_ = history.Should().NotBeNull();
	}

	/// <summary>
	/// MS-24442: A window beyond the ~30-day lookback limit is rejected by Meraki with
	/// 400 "timespan goes too far into the past". The DataMagic worker must treat this as a
	/// signal to advance its cursor forward, not as a terminal error.
	/// </summary>
	[Fact]
	public async Task GetNetworkApplianceUplinksUsageHistory_BeyondLookbackLimit_ThrowsTimespanTooFarInThePast()
	{
		var applianceNetwork = await GetFirstApplianceNetworkAsync();

		// 60 days ago is safely beyond the ~30-day limit (for every resolution).
		var t0 = HourAligned(UtcNow.AddDays(-(ApproxMaxLookbackDays * 2)));
		var t1 = t0.AddDays(1);

		Func<Task> act = async () => _ = await TestMerakiClient
			.Appliance
			.Uplinks
			.UsageHistory
			.GetNetworkApplianceUplinksUsageHistoryAsync(
				applianceNetwork.Id,
				t0: Format(t0),
				t1: Format(t1),
				resolution: 3600,
				cancellationToken: CancellationToken);

		var assertion = await act.Should().ThrowAsync<ApiException>();
		_ = assertion.Which.StatusCode.Should().Be(HttpStatusCode.BadRequest);
		_ = assertion.Which.Content.Should().Contain("too far into the past");
	}

	/// <summary>
	/// MS-24442: The documented "t1 can be a maximum of 14 days after t0" span limit is not enforced.
	/// A span wider than 14 days (here ~28 days, kept within the ~30-day lookback) returns data at
	/// hourly resolution, so the worker can fetch the whole available window in a single call.
	/// </summary>
	[Fact]
	public async Task GetNetworkApplianceUplinksUsageHistory_SpanWiderThanDocumented14Days_ReturnsData()
	{
		var applianceNetwork = await GetFirstApplianceNetworkAsync();

		// ~28-day span ending now: wider than the documented 14-day max, still within the ~30-day lookback.
		var t1 = HourAligned(UtcNow);
		var t0 = t1.AddDays(-(ApproxMaxLookbackDays - 2));

		var history = await TestMerakiClient
			.Appliance
			.Uplinks
			.UsageHistory
			.GetNetworkApplianceUplinksUsageHistoryAsync(
				applianceNetwork.Id,
				t0: Format(t0),
				t1: Format(t1),
				resolution: 3600,
				cancellationToken: CancellationToken);

		_ = history.Should().NotBeNull();
	}

	private async Task<Network> GetFirstApplianceNetworkAsync()
	{
		var networks = await TestMerakiClient
			.Organizations
			.Networks
			.GetOrganizationNetworksAsync(
				Configuration.TestOrganizationId,
				productTypes: [ProductType.Appliance],
				cancellationToken: CancellationToken);

		_ = networks.Should().NotBeEmpty("an appliance network is required for uplink usageHistory tests");
		return networks[0];
	}

	private static DateTimeOffset HourAligned(DateTimeOffset value)
		=> new(value.Year, value.Month, value.Day, value.Hour, 0, 0, TimeSpan.Zero);

	private static string Format(DateTimeOffset value)
		=> value.ToString("yyyy-MM-ddTHH:mm:ss.ffffffZ", CultureInfo.InvariantCulture);
}
