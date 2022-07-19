using FluentAssertions;
using Meraki.Api.Data;
using System.Net;
using Xunit.Abstractions;

namespace Meraki.Api.NewTest;
[Collection("API Collection")]
public class UniqueVlanTests : MerakiClientUnitTest
{
	public UniqueVlanTests(ITestOutputHelper testOutputHelper) : base(testOutputHelper)
	{
	}

	[Fact]
	public async Task BasicCrud_Succeeds()
	{
		// Create the test Configuration Template
		var configurationTemplate = await CreateValidConfigurationTemplateAsync("VLAN Test ConfigTemplate");

		// Make sure we've got something back
		_ = configurationTemplate.Should().NotBeNull();

		try
		{
			// Enable Vlans on the Configuration Template
			_ = await TestMerakiClient.Appliance.Vlans.Settings.UpdateNetworkApplianceVlansSettingsAsync(
				configurationTemplate.Id,
				new() { Enabled = true },
				default);

			// Create a uniquely subnetted VLAN
			var vlanCreationRequest = new VlanCreationRequest
			{
				Id = "10",
				Cidr = "10.1.0.0/8",
				Mask = 28,
				Name = "AM and Colleague",
				TemplateVlanType = "unique",
				GroupPolicyId = null,
				ApplianceIp = null,
				Subnet = null
			};
			var newVlan = await TestMerakiClient.Appliance.Vlans.CreateNetworkApplianceVlanAsync(
				configurationTemplate.Id,
				vlanCreationRequest,
				default);
			_ = newVlan.Should().NotBeNull();

		}
		finally
		{
			// Delete the Configuration Template
			await TestMerakiClient.Organizations.ConfigTemplates.DeleteOrganizationConfigTemplateAsync(
				TestOrganizationId,
				configurationTemplate.Id
				);
		}

		// Make sure that the Configuration Template is gone
		var exception = await Assert.ThrowsAsync<Refit.ApiException>(
			() => TestMerakiClient.Organizations.ConfigTemplates.GetOrganizationConfigTemplateAsync(
				TestOrganizationId,
				configurationTemplate.Id
				)
			);
		_ = exception.StatusCode.Should().Be(HttpStatusCode.NotFound);

	}
}