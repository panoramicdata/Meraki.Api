using FluentAssertions;
using Meraki.Api.Data;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Meraki.Api.Test
{
	public class OrganizationTests : MerakiClientTest
	{
		public OrganizationTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
		{
		}

		[Fact]
		public async void GetAllAsync_Succeeds()
		{
			var result = await MerakiClient
				.Organizations
				.GetAllAsync()
				.ConfigureAwait(false);
			result.Should().BeOfType<List<Organization>>();
			result.Should().NotBeNull();
			result.Should().NotBeEmpty();
			var firstResult = result[0];
			Validate(firstResult);
		}

		[Fact]
		public async void GetAsync_Succeeds()
		{
			var result = await MerakiClient
				.Organizations
				.GetAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			Validate(result);
		}

		[Fact]
		public async void GetAllThirdPartyVpnPeersAsync_Succeeds()
		{
			var result = await MerakiClient
				.Organizations
				.GetThirdPartyVpnPeersAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			result.Should().BeOfType<List<ThirdPartyVpnPeer>>();
			result.Should().NotBeNull();
		}

		[Fact]
		public async void GetAllInventoryAsync_Succeeds()
		{
			var result = await MerakiClient
				.Organizations
				.GetInventoryAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			result.Should().NotBeNull();
			result.Should().NotBeEmpty();
		}

		[Fact]
		public async void GetOrganizationLicenseState_Succeeds()
		{
			var result = await MerakiClient
				.Organizations
				.GetLicenseStateAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);

			result.Should().NotBeNull();
		}

		[Fact]
		public async void GetOrganizationLicenses_Succeeds()
		{
			var licenses = await MerakiClient
				.Licenses
				.GetPageAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);

			licenses.Should().NotBeNull();
		}

		[Fact]
		public async void GetOrganizationDevices_Succeeds()
		{
			var organizationDevices = await MerakiClient
				.Organizations
				.GetDevicesAsync(Configuration.TestOrganizationId, default)
				.ConfigureAwait(false);

			organizationDevices.Should().NotBeNull();
		}

		[Fact]
		public async void GetOrganizationDeviceStatus_Succeeds()
		{
			var organizationDeviceStatus = await MerakiClient
				.Organizations
				.GetDeviceStatusesAsync(Configuration.TestOrganizationId, default)
				.ConfigureAwait(false);

			organizationDeviceStatus.Should().NotBeNull();
		}

		/// <summary>
		/// Get an organization device license by ID
		/// </summary>
		[Fact]
		public async void GetOrganizationDeviceLicense_Succeeds()
		{
			var organizationDeviceLicenses = await MerakiClient
				.Licenses
				.GetPageAsync(Configuration.TestOrganizationId, cancellationToken: default)
				.ConfigureAwait(false);

			organizationDeviceLicenses.Should().NotBeNull();

			var license = organizationDeviceLicenses.FirstOrDefault();

			var organizationDeviceLicense = await MerakiClient
				.Licenses
				.GetAsync(Configuration.TestOrganizationId, license!.Id)
				.ConfigureAwait(false);

			organizationDeviceLicense.Should().NotBeNull();
		}

		[Fact]
		public async void ClaimDeviceAsync_Succeeds()
		{
			var result = await MerakiClient
				.Organizations
				.ClaimAsync(Configuration.TestOrganizationId, new OrganizationClaimRequest { Serials = new List<string> { Configuration.TestDeviceSerial } })
				.ConfigureAwait(false);
			result.Should().NotBeNull();
			result.Serials.Should().NotBeEmpty();
		}

		[Fact]
		public async void Crud_Succeeds()
		{
			// Create
			const string initialOrganizationName = "TestOrganization";
			var createdOrganization = await MerakiClient
				.Organizations
				.CreateAsync(new OrganizationCreateRequest { Name = initialOrganizationName })
				.ConfigureAwait(false);
			CheckOrganization(createdOrganization, initialOrganizationName);

			await Task.Delay(TimeSpan.FromSeconds(5))
				.ConfigureAwait(false);

			// Read
			var refetchedOrganization = await MerakiClient
				.Organizations
				.GetAsync(createdOrganization.Id)
				.ConfigureAwait(false);
			CheckOrganization(refetchedOrganization, initialOrganizationName, createdOrganization.Id);

			await Task.Delay(TimeSpan.FromSeconds(5))
				.ConfigureAwait(false);

			// Update
			const string newOrganizationName = "TestOrganizationNewName";
			var updatedOrganization = await MerakiClient
				.Organizations
				.UpdateAsync(createdOrganization.Id, new OrganizationUpdateRequest { Name = newOrganizationName })
				.ConfigureAwait(false);
			CheckOrganization(updatedOrganization, newOrganizationName, createdOrganization.Id);

			await Task.Delay(TimeSpan.FromSeconds(5))
				.ConfigureAwait(false);

			// Delete
			await MerakiClient
				.Organizations
				.DeleteAsync(createdOrganization.Id)
				.ConfigureAwait(false);

			await Task.Delay(TimeSpan.FromSeconds(5))
				.ConfigureAwait(false);

			// It should be gone now
			Func<Task> act = async () =>
			{
				await MerakiClient
					.Organizations
					.GetAsync(createdOrganization.Id)
					.ConfigureAwait(false);
			};
			await act
				.Should()
				.ThrowAsync<ApiException>()
				.ConfigureAwait(false);
		}

		private static void Validate(Organization org)
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
				organization.Id.Should().Be(id);
			}
			organization.Name.Should().Be(initialOrganizationName);
			organization.Url.Should().NotBeNullOrWhiteSpace();
		}
	}
}
