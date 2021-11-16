using FluentAssertions;
using Meraki.Api.Data;
using System.Collections.Generic;
using System.Threading;
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
		public async void GetChangeLogEntriesPagedAsync_Succeeds()
		{
			var result = await TestMerakiClient
				.Organizations
				.ConfigurationChanges
				.GetOrganizationConfigurationChangesAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			result.Should().BeOfType<List<ChangeLogEntry>>();
			result.Should().NotBeNull();
			result.Should().NotBeEmpty();
		}

		[Fact]
		public async void GetAllAsync_Succeeds()
		{
			var result = await TestMerakiClient
				.Organizations
				.ConfigurationChanges
				.GetOrganizationConfigurationChangesAllAsync(organizationId: Configuration.TestOrganizationId, cancellationToken: CancellationToken.None)
				.ConfigureAwait(false);

			result.Should().BeOfType<List<ChangeLogEntry>>();
			result.Should().NotBeNull();
			result.Should().NotBeEmpty();
		}
	}
}
