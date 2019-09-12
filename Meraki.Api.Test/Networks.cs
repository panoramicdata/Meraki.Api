using Xunit;

namespace Meraki.Api.Test
{
	public class Networks : MerakiClientTest
	{
		[Fact]
		public async void GetAll_Succeeds()
		{
			var result = await MerakiClient
				.Networks
				.GetAllAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
