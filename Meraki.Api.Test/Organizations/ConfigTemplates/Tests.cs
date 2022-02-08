namespace Meraki.Api.Test.Organizations.ConfigTemplates;

public class Tests : MerakiClientTest
{
	public Tests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
	{
	}

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
				})
			.ConfigureAwait(false);
		createResult.Should().NotBeNull();

		try
		{
			// Read 1
			var refetchedConfigurationTemplate =
			await TestMerakiClient
				.Organizations
				.ConfigTemplates
				.GetOrganizationConfigTemplateAsync(
					Configuration.TestOrganizationId,
					createResult.Id)
				.ConfigureAwait(false);
			refetchedConfigurationTemplate.Should().NotBeNull();
			refetchedConfigurationTemplate.Name.Should().Be(configurationTemplateName);
			refetchedConfigurationTemplate.TimeZone.Should().Be(timeZone);

			// Update
			await TestMerakiClient
				.Organizations
				.ConfigTemplates
				.UpdateOrganizationConfigTemplateAsync(
					Configuration.TestOrganizationId,
					createResult.Id,
					new ConfigurationTemplateUpdate
					{
						Name = configurationTemplateName + "x",
						TimeZone = timeZone
					})
				.ConfigureAwait(false);

			// Read 2
			var refetchedConfigurationTemplate2 =
			await TestMerakiClient
				.Organizations
				.ConfigTemplates
				.GetOrganizationConfigTemplateAsync(
					Configuration.TestOrganizationId,
					createResult.Id)
				.ConfigureAwait(false);
			refetchedConfigurationTemplate2.Should().NotBeNull();
			refetchedConfigurationTemplate2.Name.Should().Be(configurationTemplateName + "x");
			refetchedConfigurationTemplate2.TimeZone.Should().Be(timeZone);

			// Enable VLANs
			await TestMerakiClient
				.Appliance
				.Vlans
				.Settings
				.UpdateNetworkApplianceVlansSettingsAsync(createResult.Id, new VlansEnabledState
				{
					Enabled = true
				})
				.ConfigureAwait(false);

			// Set VLAN info
			var result = await TestMerakiClient
				.Appliance
				.Vlans
				.CreateNetworkApplianceVlanAsync(
					createResult.Id,
					new VlanCreationRequest
					{
						Id = "2",
						Name = "VLAN 2",
						Subnet = "10.0.0.0/24",
						ApplianceIp = "10.0.0.1"
					})
				.ConfigureAwait(false);
		}
		finally
		{
			await TestMerakiClient
				.Organizations
				.ConfigTemplates
				.DeleteOrganizationConfigTemplateAsync(
					Configuration.TestOrganizationId,
					createResult.Id)
				.ConfigureAwait(false);
		}
	}

	[Fact]
	public async Task GetNetworksByConfigTemplateIdAsync_Succeeds()
	{
		var configurationTemplates = await GetAllAsync().ConfigureAwait(false);
		if (configurationTemplates.Count == 0)
		{
			return;
		}

		var configurationTemplate = configurationTemplates[0];

		var result = await TestMerakiClient
			.Organizations
			.Networks
			.GetOrganizationNetworksAsync(Configuration.TestOrganizationId, configurationTemplate.Id)
			.ConfigureAwait(false);
		result.Should().NotBeNull();
	}

	[Fact]
	public async Task GetAllConfigurationTemplatesAsync_Succeeds()
	{
		var configurationTemplates = await GetAllAsync().ConfigureAwait(false);

		// Get their associated switch profiles (for the first up to 3)
		foreach (var configurationTemplate in configurationTemplates.Take(3))
		{
			var switchProfiles = await TestMerakiClient
				.Switch.ConfigTemplates.Profiles
				.GetOrganizationConfigTemplateSwitchProfilesAsync(Configuration.TestOrganizationId, configurationTemplate.Id)
				.ConfigureAwait(false);
			switchProfiles.Should().BeOfType<List<SwitchProfile>>();
			switchProfiles.Should().NotBeNull();
			if (switchProfiles.Count > 0)
			{
				switchProfiles.All(switchProfile => string.IsNullOrWhiteSpace(switchProfile.Model)).Should().BeFalse();
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
		configurationTemplates.Should().BeOfType<List<ConfigurationTemplate>>();
		configurationTemplates.Should().NotBeNull();
		return configurationTemplates;
	}
}
