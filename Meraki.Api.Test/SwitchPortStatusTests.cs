using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Meraki.Api.Test
{
	public class SwitchPortStatusTests : MerakiClientTest
	{
		public SwitchPortStatusTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
		{
		}

		[Fact]
		public async void GetSwitchPortStatuses_Succeeds()
		{
			var switchPortStatuses = await MerakiClient
				.SwitchPorts
				.GetDeviceSwitchPortStatuses(Configuration.TestDeviceSerial)
				.ConfigureAwait(false);

			switchPortStatuses.Should().NotBeNullOrEmpty();
		}
	}
}
