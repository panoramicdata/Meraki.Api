using Newtonsoft.Json;

namespace Meraki.Api.Test.Data;

/// <summary>
/// Regression tests for
/// <see href="https://github.com/panoramicdata/Meraki.Api/issues/360">issue 360</see>: the
/// cumulative byte counters on appliance uplink usage exceed Int32.MaxValue on busy networks.
/// </summary>
public class OrganizationApplianceUplinksUsageByNetworkItemByUplinkItemTests
{
	// 5 TB sent, 3 TB received: a plausible 31-day figure for a busy uplink, far above Int32.MaxValue.
	private const string Json = """
		{
			"serial": "Q2QN-9J8L-SLPD",
			"interface": "wan1",
			"sent": 5000000000000,
			"received": 3000000000000
		}
		""";

	[Fact]
	public void Deserialize_ByteCountsAboveInt32MaxValue_Succeeds()
	{
		var item = JsonConvert.DeserializeObject<OrganizationApplianceUplinksUsageByNetworkItemByUplinkItem>(Json);

		_ = item.Should().NotBeNull();
		_ = item!.Sent.Should().Be(5_000_000_000_000L);
		_ = item.Received.Should().Be(3_000_000_000_000L);
	}
}
