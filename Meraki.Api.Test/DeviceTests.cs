using FluentAssertions;
using Xunit;

namespace Meraki.Api.Test
{
	public class DeviceTests : MerakiClientTest
	{
		[Fact]
		public async void GetDeviceAsync_Succeeds()
		{
			var result = await MerakiClient
				.Devices
				.GetAsync(Configuration.TestCameraNetworkName, Configuration.TestCameraSerial)
				.ConfigureAwait(false);
			result.Should().NotBeNull();
		}
	}
}
