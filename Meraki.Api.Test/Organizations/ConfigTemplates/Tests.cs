namespace Meraki.Api.Test.Organizations.ConfigTemplates;

public class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	[Fact]
	public async Task CreateReadUpdateDeleteConfigurationTemplate_Succeeds()
	{
		// Create
		var configurationTemplateName = $"Test_{Guid.NewGuid().ToString()[..10]}";
		const string timeZone = "Europe/London";
		var createResult = await TestMerakiClient
			.Organizations
			.ConfigTemplates
			.CreateOrganizationConfigTemplateAsync(
				Configuration.TestOrganizationId,
				new ConfigurationTemplateCreateRequest
				{
					Name = configurationTemplateName,
					TimeZone = timeZone
				});
		_ = createResult.Should().NotBeNull();

		try
		{
			// Read 1
			var refetchedConfigurationTemplate =
			await TestMerakiClient
				.Organizations
				.ConfigTemplates
				.GetOrganizationConfigTemplateAsync(
					Configuration.TestOrganizationId,
					createResult.Id);
			_ = refetchedConfigurationTemplate.Should().NotBeNull();
			_ = refetchedConfigurationTemplate.Name.Should().Be(configurationTemplateName);
			_ = refetchedConfigurationTemplate.TimeZone.Should().Be(timeZone);

			// Update
			_ = await TestMerakiClient
				.Organizations
				.ConfigTemplates
				.UpdateOrganizationConfigTemplateAsync(
					Configuration.TestOrganizationId,
					createResult.Id,
					new ConfigurationTemplateUpdate
					{
						Name = configurationTemplateName + "x",
						TimeZone = timeZone
					});

			// Read 2
			var refetchedConfigurationTemplate2 =
			await TestMerakiClient
				.Organizations
				.ConfigTemplates
				.GetOrganizationConfigTemplateAsync(
					Configuration.TestOrganizationId,
					createResult.Id);
			_ = refetchedConfigurationTemplate2.Should().NotBeNull();
			_ = refetchedConfigurationTemplate2.Name.Should().Be(configurationTemplateName + "x");
			_ = refetchedConfigurationTemplate2.TimeZone.Should().Be(timeZone);

			// Enable VLANs
			_ = await TestMerakiClient
				.Appliance
				.Vlans
				.Settings
				.UpdateNetworkApplianceVlansSettingsAsync(createResult.Id, new VlansEnabledState
				{
					Enabled = true
				});

			// Set VLAN info
			_ = await TestMerakiClient
				.Appliance
				.Vlans
				.CreateNetworkApplianceVlanAsync(
					createResult.Id,
					new VlanCreationRequest
					{
						Id = "2",
						Name = "VLAN 2",
						Subnet = $"{PrivateNetworkFirst3Octets}.0/24",
						ApplianceIp = $"{PrivateNetworkFirst3Octets}.1"
					});
		}
		finally
		{
			await TestMerakiClient
				.Organizations
				.ConfigTemplates
				.DeleteOrganizationConfigTemplateAsync(
					Configuration.TestOrganizationId,
					createResult.Id);
		}
	}

	[Fact]
	public async Task GetNetworksByConfigTemplateIdAsync_Succeeds()
	{
		var configurationTemplates = await GetAllAsync();
		if (configurationTemplates.Count == 0)
		{
			return;
		}

		var configurationTemplate = configurationTemplates[0];

		var result = await TestMerakiClient
			.Organizations
			.Networks
			.GetOrganizationNetworksAsync(Configuration.TestOrganizationId, configurationTemplate.Id);
		_ = result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllConfigurationTemplatesAsync_Succeeds()
	{
		var configurationTemplates = await GetAllAsync();

		// Get their associated switch profiles (for the first up to 3)
		foreach (var configurationTemplate in configurationTemplates.Take(3))
		{
			var switchProfiles = await TestMerakiClient
				.Switch.ConfigTemplates.Profiles
				.GetOrganizationConfigTemplateSwitchProfilesAsync(Configuration.TestOrganizationId, configurationTemplate.Id);
			_ = switchProfiles.Should().BeOfType<List<SwitchProfile>>();
			_ = switchProfiles.Should().NotBeNull();
			if (switchProfiles.Count > 0)
			{
				_ = switchProfiles.All(switchProfile => string.IsNullOrWhiteSpace(switchProfile.Model)).Should().BeFalse();
			}
		}
	}

	private async Task<List<ConfigurationTemplate>> GetAllAsync()
	{
		var configurationTemplates = await TestMerakiClient
			.Organizations
			.ConfigTemplates
			.GetOrganizationConfigTemplatesAsync(Configuration.TestOrganizationId)
			.ConfigureAwait(false);
		_ = configurationTemplates.Should().BeOfType<List<ConfigurationTemplate>>();
		_ = configurationTemplates.Should().NotBeNull();
		return configurationTemplates;
	}
}
