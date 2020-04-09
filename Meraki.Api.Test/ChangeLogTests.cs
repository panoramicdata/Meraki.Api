using FluentAssertions;
using Meraki.Api.Data;
using System.Collections.Generic;
using Xunit;
using Xunit.Abstractions;

namespace Meraki.Api.Test
{
	public class ChangeLogTests : MerakiClientTest
	{
		public ChangeLogTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
		{
		}

		[Fact]
		public async void GetChangeLogEntriesAsync_Succeeds()
		{
			var result = await MerakiClient
				.ChangeLogs
				.GetAllAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			result.Should().BeOfType<List<ChangeLogEntry>>();
			result.Should().NotBeNull();
			result.Should().NotBeEmpty();
		}
	}
}
