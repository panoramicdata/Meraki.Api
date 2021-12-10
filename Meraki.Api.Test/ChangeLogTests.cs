namespace Meraki.Api.Test;

public class ChangeLogTests : MerakiClientTest
{
	public ChangeLogTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetChangeLogEntriesPagedAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.ConfigurationChanges
			.GetOrganizationConfigurationChangesAsync(Configuration.TestOrganizationId)
			.ConfigureAwait(false);
		_ = result.Should().BeOfType<List<ChangeLogEntry>>();
		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();
	}

	[Fact]
	public async Task GetAllAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.ConfigurationChanges
			.GetOrganizationConfigurationChangesAllAsync(organizationId: Configuration.TestOrganizationId, cancellationToken: CancellationToken.None)
			.ConfigureAwait(false);

		_ = result.Should().BeOfType<List<ChangeLogEntry>>();
		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();
	}
}
