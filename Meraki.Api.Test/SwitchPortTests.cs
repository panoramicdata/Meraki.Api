using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace Meraki.Api.Test
{
	public class SwitchPortTests : MerakiClientTest
	{
		public SwitchPortTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
		{
		}

		[Fact]
		public async void GetSwitchPortStatuses_Succeeds()
		{
			var switchPorts = await MerakiClient
				.SwitchPorts
				.GetDeviceSwitchPortsAsync(Configuration.TestDeviceSerial)
				.ConfigureAwait(false);

			switchPorts.Should().NotBeNullOrEmpty();
		}
	}
}
