using FluentAssertions;
using Meraki.Api.Data;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace Meraki.Api.Test
{
	public class Admins : MerakiClientTest
	{
		public Admins(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
		{
		}

		[Fact]
		public async void GetAll_Succeeds()
		{
			var result = await MerakiClient
				.Admins
				.GetAllAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			result.Should().BeOfType<List<Admin>>();
			result.Should().NotBeNull();
			result.Should().NotBeEmpty();
		}
	}
}
