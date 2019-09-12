using Xunit;

namespace Meraki.Api.Test
{
	public class Organizations : MerakiClientTest
	{
		[Fact]
		public async void GetAllOrganizations_Succeeds()
		{
			var result = await MerakiClient
				.Organizations
				.GetAllAsync()
				.ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
