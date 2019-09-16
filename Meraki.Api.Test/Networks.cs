using Xunit;

namespace Meraki.Api.Test
{
	public class Networks : MerakiClientTest
	{
		[Fact]
		public async void GetAllSsidsAsync_Succeeds()
		{
			var result = await MerakiClient
				.Networks
				.GetAllSsidsAsync(Configuration.TestNetworkId)
				.ConfigureAwait(false);
			Assert.NotNull(result);
			Assert.NotEmpty(result);
		}

		[Fact]
		public async void GetAllDevicesAsync_Succeeds()
		{
			var result = await MerakiClient
				.Networks
				.GetAllSsidsAsync(Configuration.TestNetworkId)
				.ConfigureAwait(false);
			Assert.NotNull(result);
			Assert.NotEmpty(result);
		}

		[Fact]
		public async void GetDeviceAsync_Succeeds()
		{
			var result = await MerakiClient
				.Networks
				.GetDeviceAsync(Configuration.TestNetworkId, Configuration.TestDeviceSerial)
				.ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
