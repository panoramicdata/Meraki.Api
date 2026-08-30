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
			await EnableVlansAsync(configurationTemplate.Id);
			await CreateUniqueVlanAsync(configurationTemplate.Id);
		}
		finally
		{
			await DeleteConfigurationTemplateAsync(configurationTemplate.Id);
		}

		// Make sure that the Configuration Template is gone
		var act = () => TestMerakiClient
			.Organizations
			.ConfigTemplates
			.GetOrganizationConfigTemplateAsync(
				Configuration.TestOrganizationId,
				configurationTemplate.Id,
				cancellationToken: CancellationToken);

		_ = await act
			.Should()
			.ThrowExactlyAsync<ApiException>()
			.Where(ex => ex.StatusCode == HttpStatusCode.NotFound);
	}

	private async Task EnableVlansAsync(string configurationTemplateId)
		=> _ = await TestMerakiClient
			.Appliance
			.Vlans
			.Settings
			.UpdateNetworkApplianceVlansSettingsAsync(
				configurationTemplateId,
				new() { Enabled = true },
				cancellationToken: CancellationToken);

	/// <summary>
	/// Creates a VLAN whose subnet is allocated per bound network rather than shared, which is what
	/// TemplateVlanType "unique" means.
	/// </summary>
	private async Task CreateUniqueVlanAsync(string configurationTemplateId)
	{
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

		var newVlan = await TestMerakiClient
			.Appliance
			.Vlans
			.CreateNetworkApplianceVlanAsync(
				configurationTemplateId,
				vlanCreationRequest,
				cancellationToken: CancellationToken);
		_ = newVlan.Should().NotBeNull();
	}

	private Task DeleteConfigurationTemplateAsync(string configurationTemplateId)
		=> TestMerakiClient
			.Organizations
			.ConfigTemplates
			.DeleteOrganizationConfigTemplateAsync(
				Configuration.TestOrganizationId,
				configurationTemplateId,
				cancellationToken: CancellationToken);

	private Task<ConfigurationTemplate> CreateValidConfigurationTemplateAsync(string configurationTemplateName)
		=> TestMerakiClient
			.Organizations
			.ConfigTemplates
			.CreateOrganizationConfigTemplateAsync(
				Configuration.TestOrganizationId,
				new ConfigurationTemplateCreateRequest
				{
					Name = configurationTemplateName,
					TimeZone = "Europe/London"
				},
				cancellationToken: CancellationToken);
}
