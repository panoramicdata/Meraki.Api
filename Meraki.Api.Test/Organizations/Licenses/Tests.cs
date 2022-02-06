namespace Meraki.Api.Test.Organizations.Licenses;

public class Tests : MerakiClientTest
{
	public Tests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetOrganizationLicenseState_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.Licenses
			.GetOrganizationLicensesOverviewAsync(Configuration.TestOrganizationId)
			.ConfigureAwait(false);

		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetOrganizationLicenses_Succeeds()
	{
		if (Configuration.TestOrganizationIdSupportingPerDeviceLicensing is null)
		{
			// We'll skip this test then
			return;
		}

		var licenses = await TestMerakiClient
			.Organizations
			.Licenses
			.GetOrganizationLicensesAsync(Configuration.TestOrganizationIdSupportingPerDeviceLicensing)
			.ConfigureAwait(false);

		licenses.Should().NotBeNull();
	}

	/// <summary>
	/// Get an organization device license by ID
	/// </summary>
	[Fact]
	public async Task GetOrganizationDeviceLicense_Succeeds()
	{
		if (Configuration.TestOrganizationIdSupportingPerDeviceLicensing is null)
		{
			// We'll skip this test then
			return;
		}

		var organizationDeviceLicenses = await TestMerakiClient
			.Organizations
			.Licenses
			.GetOrganizationLicensesAsync(Configuration.TestOrganizationIdSupportingPerDeviceLicensing)
			.ConfigureAwait(false);

		organizationDeviceLicenses.Should().NotBeNullOrEmpty();
		var license = organizationDeviceLicenses[0];

		var organizationDeviceLicense = await TestMerakiClient
			.Organizations
			.Licenses
			.GetOrganizationLicenseAsync(Configuration.TestOrganizationIdSupportingPerDeviceLicensing, license.Id)
			.ConfigureAwait(false);

		organizationDeviceLicense.Should().NotBeNull();
	}
}
