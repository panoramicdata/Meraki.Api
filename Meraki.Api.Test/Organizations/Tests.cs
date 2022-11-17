namespace Meraki.Api.Test.Organizations;

public class Tests : MerakiClientTest
{
	public Tests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetAllAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.GetOrganizationsAsync()
			.ConfigureAwait(false);
		_ = result.Should().BeOfType<List<Organization>>();
		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();
		var firstResult = result[0];
		ValidateOrganisation(firstResult);
	}

	[Fact]
	public async Task GetAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.GetOrganizationAsync(Configuration.TestOrganizationId)
			.ConfigureAwait(false);
		ValidateOrganisation(result);
	}

	[Fact]
	public async Task Crud_Succeeds()
	{
		const string initialOrganizationName = "TestOrganization";

		// Check to see if the organization already exists and bomb out if it does
		var existingOrganizations = await TestMerakiClient
			.Organizations
			.GetOrganizationsAsync()
			.ConfigureAwait(false);
		if (existingOrganizations.Any(o => o.Name == initialOrganizationName))
		{
			throw new Exception($"Test Organization {initialOrganizationName} already exists");
		}

		// Create
		var createdOrganization = await TestMerakiClient
			.Organizations
			.CreateOrganizationAsync(new OrganizationCreateRequest { Name = initialOrganizationName })
			.ConfigureAwait(false);
		CheckOrganization(createdOrganization, initialOrganizationName);

		// wait to allow the organization to be created properly
		await Task.Delay(TimeSpan.FromSeconds(5))
			.ConfigureAwait(false);

		// Read
		var refetchedOrganization = await TestMerakiClient
			.Organizations
			.GetOrganizationAsync(createdOrganization.Id)
			.ConfigureAwait(false);
		CheckOrganization(refetchedOrganization, initialOrganizationName, createdOrganization.Id);

		// Update
		const string newOrganizationName = "TestOrganizationNewName";
		var updatedOrganization = await TestMerakiClient
			.Organizations
			.UpdateOrganizationAsync(createdOrganization.Id, new OrganizationUpdateRequest { Name = newOrganizationName })
			.ConfigureAwait(false);
		CheckOrganization(updatedOrganization, newOrganizationName, createdOrganization.Id);

		await Task.Delay(TimeSpan.FromSeconds(5))
			.ConfigureAwait(false);

		// Delete
		await TestMerakiClient
			.Organizations
			.DeleteOrganizationAsync(createdOrganization.Id)
			.ConfigureAwait(false);

		await Task.Delay(TimeSpan.FromSeconds(5))
			.ConfigureAwait(false);

		// It should be gone now
		Func<Task> act = async () =>
		{
			_ = await TestMerakiClient
				.Organizations
				.GetOrganizationAsync(createdOrganization.Id)
				.ConfigureAwait(false);
		};
		_ = await act
			.Should()
			.ThrowAsync<ApiException>()
			.ConfigureAwait(false);
	}

	//[Fact(Skip = "Not part of general run")]
	public async Task ClaimDeviceAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.ClaimIntoOrganizationAsync(Configuration.TestOrganizationId, new OrganizationClaimRequest { Serials = new List<string> { Configuration.TestDeviceSerial } })
			.ConfigureAwait(false);
		_ = result.Should().NotBeNull();
		_ = result.Serials.Should().NotBeEmpty();
	}

	private static void ValidateOrganisation(Organization org)
	{
		_ = org.Should().NotBeNull();
		_ = org.Id.Should().NotBeNullOrWhiteSpace();
		_ = org.Name.Should().NotBeNullOrWhiteSpace();
		_ = org.Url.Should().NotBeNullOrWhiteSpace();
	}

	private static void CheckOrganization(
		Organization organization,
		string initialOrganizationName,
		string? id = default)
	{
		_ = organization.Should().NotBeNull();
		_ = organization.Id.Should().NotBeNullOrWhiteSpace();
		if (id != null)
		{
			// Compare the id
			_ = organization.Id.Should().Be(id);
		}

		_ = organization.Name.Should().Be(initialOrganizationName);
		_ = organization.Url.Should().NotBeNullOrWhiteSpace();
	}
}
