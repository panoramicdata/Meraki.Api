namespace Meraki.Api.Test.Organizations.Licenses;

public class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	[Fact]
	public async Task GetOrganizationLicenseState_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.Licenses
			.GetOrganizationLicensesOverviewAsync(
				Configuration.TestOrganizationId,
				cancellationToken: CancellationToken);

		_ = result.Should().NotBeNull();
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
			.GetOrganizationLicensesAsync(
				Configuration.TestOrganizationIdSupportingPerDeviceLicensing,
				cancellationToken: CancellationToken);

		_ = licenses.Should().NotBeNull();
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
			.GetOrganizationLicensesAsync(
				Configuration.TestOrganizationIdSupportingPerDeviceLicensing,
				cancellationToken: CancellationToken);

		_ = organizationDeviceLicenses.Should().NotBeNullOrEmpty();
		var license = organizationDeviceLicenses[0];

		var organizationDeviceLicense = await TestMerakiClient
			.Organizations
			.Licenses
			.GetOrganizationLicenseAsync(
				Configuration.TestOrganizationIdSupportingPerDeviceLicensing,
				license.Id,
				CancellationToken);

		_ = organizationDeviceLicense.Should().NotBeNull();
	}
}
