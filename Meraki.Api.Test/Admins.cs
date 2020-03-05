using FluentAssertions;
using Xunit;

namespace Meraki.Api.Test
{
	public class Admins : MerakiClientTest
	{
		[Fact]
		public async void GetAll_Succeeds()
		{
			var result = await MerakiClient
				.Admins
				.GetAllAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			result.Should().NotBeNull();
			result.Should().NotBeEmpty();
		}
	}
}
