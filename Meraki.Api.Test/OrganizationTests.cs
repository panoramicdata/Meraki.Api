using FluentAssertions;
using Meraki.Api.Data;
using Refit;
using System;
using System.Collections.Generic;
using System.Threading;
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
		public async void GetAsync_Succeeds()
		{
			var result = await TestMerakiClient
				.Organizations
				.GetOrganizationAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			ValidateOrganisation(result);
		}

		[Fact]
		public async void GetAllThirdPartyVpnPeersAsync_Succeeds()
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
		public async void GetAllInventoryAsync_Succeeds()
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
		public async void GetOrganizationLicenseState_Succeeds()
		{
			var result = await TestMerakiClient
				.Organizations
				.Licenses
				.GetOrganizationLicensesOverviewAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);

			result.Should().NotBeNull();
		}

		[Fact]
		public async void GetOrganizationLicenses_Succeeds()
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
		public async void GetOrganizationDevices_Succeeds()
		{
			var organizationDevices = await TestMerakiClient
				.Organizations
				.Devices
				.GetOrganizationDevicesAsync(Configuration.TestOrganizationId, default)
				.ConfigureAwait(false);

			organizationDevices.Should().NotBeNull();
		}

		[Fact]
		public async void GetOrganizationDeviceStatus_Succeeds()
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
		public async void GetOrganizationDeviceLicense_Succeeds()
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

#pragma warning disable xUnit1004 // Test methods should not be skipped
		[Fact(Skip = "Not part of general run")]
#pragma warning restore xUnit1004 // Test methods should not be skipped
		public async void ClaimDeviceAsync_Succeeds()
		{
			var result = await TestMerakiClient
				.Organizations
				.ClaimIntoOrganizationAsync(Configuration.TestOrganizationId, new OrganizationClaimRequest { Serials = new List<string> { Configuration.TestDeviceSerial } })
				.ConfigureAwait(false);
			result.Should().NotBeNull();
			result.Serials.Should().NotBeEmpty();
		}

		[Fact]
		public async void Crud_Succeeds()
		{
			// Create
			const string initialOrganizationName = "TestOrganization";
			var createdOrganization = await TestMerakiClient
				.Organizations
				.CreateOrganizationAsync(new OrganizationCreateRequest { Name = initialOrganizationName })
				.ConfigureAwait(false);
			CheckOrganization(createdOrganization, initialOrganizationName);

			await Task.Delay(TimeSpan.FromSeconds(5))
				.ConfigureAwait(false);

			// Read
			var refetchedOrganization = await TestMerakiClient
				.Organizations
				.GetOrganizationAsync(createdOrganization.Id)
				.ConfigureAwait(false);
			CheckOrganization(refetchedOrganization, initialOrganizationName, createdOrganization.Id);

			await Task.Delay(TimeSpan.FromSeconds(5))
				.ConfigureAwait(false);

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
		public async void GetNetworksAsync_Succeeds()
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
		public async void GetAllPagesForNetworksAsync_Succeeds()
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
		public async void GetAllPagesWithDefaultPerPage_ForNetworksAsync_Succeeds()
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
		public async void GetAllNetworksAsync_Succeeds()
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
}
