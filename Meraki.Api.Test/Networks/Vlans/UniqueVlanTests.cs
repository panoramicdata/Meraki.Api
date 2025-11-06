using System.Net;

namespace Meraki.Api.Test.Networks.Vlans;

public class UniqueVlanTests(ITestOutputHelper testOutputHelper) : MerakiClientTest(testOutputHelper)
{
	[Fact]
	public async Task UniqueVlan_Crud_Succeeds()
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
				CancellationToken);

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
				CancellationToken);
			_ = newVlan.Should().NotBeNull();

		}
		finally
		{
			// Delete the Configuration Template
			await TestMerakiClient.Organizations.ConfigTemplates.DeleteOrganizationConfigTemplateAsync(
				Configuration.TestOrganizationId,
				configurationTemplate.Id
				);
		}

		// Make sure that the Configuration Template is gone
		var exception = await Assert.ThrowsAsync<Refit.ApiException>(
			() => TestMerakiClient.Organizations.ConfigTemplates.GetOrganizationConfigTemplateAsync(
				Configuration.TestOrganizationId,
				configurationTemplate.Id
				)
			);
		_ = exception.StatusCode.Should().Be(HttpStatusCode.NotFound);
	}

	private async Task<ConfigurationTemplate> CreateValidConfigurationTemplateAsync(string configurationTemplateName)
		=> await TestMerakiClient
			.Organizations
			.ConfigTemplates
			.CreateOrganizationConfigTemplateAsync(
				Configuration.TestOrganizationId,
				new ConfigurationTemplateCreateRequest
				{
					Name = configurationTemplateName,
					TimeZone = "Europe/London"
				}
			);
}
