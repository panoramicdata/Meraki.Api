namespace Meraki.Api.Test;

public class OrganizationTests : MerakiClientTest
{
	public OrganizationTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

	[Fact]
	public async Task GetAllAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.GetOrganizationsAsync()
			.ConfigureAwait(false);
		result.Should().BeOfType<List<Organization>>();
		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
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
	public async Task GetAllThirdPartyVpnPeersAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Appliance
			.Vpn
			.ThirdPartyVpnPeers
			.GetOrganizationApplianceVpnThirdPartyVPNPeersAsync(Configuration.TestOrganizationId)
			.ConfigureAwait(false);
		result.Should().BeOfType<ThirdPartyVpnPeer>();
		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetInventoryAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.InventoryDevices
			.GetOrganizationInventoryDevicesAsync(Configuration.TestOrganizationId)
			.ConfigureAwait(false);
		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
	}

	[Fact]
	public async Task GetInventoryAllAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.InventoryDevices
			.GetOrganizationInventoryDevicesAllAsync(Configuration.TestOrganizationId)
			.ConfigureAwait(false);
		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
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

	[Fact]
	public async Task GetOrganizationDevices_Succeeds()
	{
		var organizationDevices = await TestMerakiClient
			.Organizations
			.Devices
			.GetOrganizationDevicesAsync(Configuration.TestOrganizationId, default)
			.ConfigureAwait(false);

		organizationDevices.Should().NotBeNull();
	}

	[Fact]
	public async Task GetOrganizationDeviceStatus_Succeeds()
	{
		var organizationDeviceStatus = await TestMerakiClient
			.Organizations
			.Devices
			.GetOrganizationDevicesStatusesAsync(Configuration.TestOrganizationId, default)
			.ConfigureAwait(false);

		organizationDeviceStatus.Should().NotBeNull();
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

	//[Fact(Skip = "Not part of general run")]
	public async Task ClaimDeviceAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.ClaimIntoOrganizationAsync(Configuration.TestOrganizationId, new OrganizationClaimRequest { Serials = new List<string> { Configuration.TestDeviceSerial } })
			.ConfigureAwait(false);
		result.Should().NotBeNull();
		result.Serials.Should().NotBeEmpty();
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

		// wait to allow the organisation to be created properly
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
			await TestMerakiClient
				.Organizations
				.GetOrganizationAsync(createdOrganization.Id)
				.ConfigureAwait(false);
		};
		await act
			.Should()
			.ThrowAsync<ApiException>()
			.ConfigureAwait(false);
	}

	[Fact]
	public async Task GetNetworksAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.Networks
			.GetOrganizationNetworksAsync(Configuration.TestOrganizationId)
			.ConfigureAwait(false);

		result.Should().BeOfType<List<Network>>();
		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
		var firstResult = result[0];
		NetworkTests.ValidateNetwork(firstResult);
	}

	private static void ValidateOrganisation(Organization org)
	{
		org.Should().NotBeNull();
		org.Id.Should().NotBeNullOrWhiteSpace();
		org.Name.Should().NotBeNullOrWhiteSpace();
		org.Url.Should().NotBeNullOrWhiteSpace();
	}

	private static void CheckOrganization(
		Organization organization,
		string initialOrganizationName,
		string? id = default)
	{
		organization.Should().NotBeNull();
		organization.Id.Should().NotBeNullOrWhiteSpace();
		if (id != null)
		{
			// Compare the id
			organization.Id.Should().Be(id);
		}

		organization.Name.Should().Be(initialOrganizationName);
		organization.Url.Should().NotBeNullOrWhiteSpace();
	}

	[Fact]
	public async Task GetAllPagesForNetworksAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.GetAllAsync(
				(perPage, startingAfter, cancellationToken)
				=> TestMerakiClient
					.Organizations
					.Networks
					.GetOrganizationNetworksAsync(
						Configuration.TestOrganizationId,
						perPage: perPage,
						startingAfter: startingAfter,
						cancellationToken: cancellationToken
					),
				3,
				CancellationToken.None
			)
			.ConfigureAwait(false);

		result.Should().BeOfType<List<Network>>();
		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
		var firstResult = result[0];
		NetworkTests.ValidateNetwork(firstResult);
	}

	[Fact]
	public async Task GetAllPagesWithDefaultPerPage_ForNetworksAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.GetAllAsync(
				(startingAfter, cancellationToken)
				=> TestMerakiClient
					.Organizations
					.Networks
					.GetOrganizationNetworksAsync(
						Configuration.TestOrganizationId,
						startingAfter: startingAfter,
						cancellationToken: cancellationToken
					),
				CancellationToken.None
			)
			.ConfigureAwait(false);

		result.Should().BeOfType<List<Network>>();
		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
		var firstResult = result[0];
		NetworkTests.ValidateNetwork(firstResult);
	}

	[Fact]
	public async Task GetAllNetworksAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.Networks
			.GetOrganizationNetworksAllAsync(Configuration.TestOrganizationId)
			.ConfigureAwait(false);

		result.Should().BeOfType<List<Network>>();
		result.Should().NotBeNull();
		result.Should().NotBeEmpty();
		var firstResult = result[0];
		NetworkTests.ValidateNetwork(firstResult);
	}
}
