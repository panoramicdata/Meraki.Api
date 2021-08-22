using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Meraki.Api.Test
{
	public class SwitchPortScheduleTests : MerakiClientTest
	{
		public SwitchPortScheduleTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
		{
		}

		[Fact]
		public async void GetSwitchPortStatuses_Succeeds()
		{
			var switchPortSchedules = await MerakiClient
				.SwitchPortSchedules
				.GetNetworkSwitchPortSchedulesAsync(Configuration.TestNetworkId)
				.ConfigureAwait(false);

			switchPortSchedules.Should().NotBeNull();
		}
	}
}
