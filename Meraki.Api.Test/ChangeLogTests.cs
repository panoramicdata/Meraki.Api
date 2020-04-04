using FluentAssertions;
using Meraki.Api.Data;
using System.Collections.Generic;
using Xunit;

namespace Meraki.Api.Test
{
	public class ChangeLogTests : MerakiClientTest
	{
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
