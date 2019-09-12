using Xunit;

namespace Meraki.Api.Test
{
	public class ApiUsages : MerakiClientTest
	{
		[Fact]
		public async void GetAll_Succeeds()
		{
			var result = await MerakiClient
				.ApiUsages
				.GetPageAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			Assert.NotNull(result);
		}
	}
}
