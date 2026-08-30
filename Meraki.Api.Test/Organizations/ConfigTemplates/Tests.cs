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
				},
				cancellationToken: CancellationToken);
		_ = createResult.Should().NotBeNull();

		try
		{
			await AssertConfigurationTemplateReadsBackAsync(createResult.Id, configurationTemplateName, timeZone);
			await UpdateAndVerifyConfigurationTemplateAsync(createResult.Id, configurationTemplateName + "x", timeZone);
			await EnableVlansAndAddOneAsync(createResult.Id);
		}
		finally
		{
			await TestMerakiClient
				.Organizations
				.ConfigTemplates
				.DeleteOrganizationConfigTemplateAsync(
					Configuration.TestOrganizationId,
					createResult.Id,
					cancellationToken: CancellationToken);
		}
	}

	private async Task AssertConfigurationTemplateReadsBackAsync(
		string configurationTemplateId,
		string expectedName,
		string expectedTimeZone)
	{
		var refetched = await TestMerakiClient
			.Organizations
			.ConfigTemplates
			.GetOrganizationConfigTemplateAsync(
				Configuration.TestOrganizationId,
				configurationTemplateId,
				cancellationToken: CancellationToken);
		_ = refetched.Should().NotBeNull();
		_ = refetched.Name.Should().Be(expectedName);
		_ = refetched.TimeZone.Should().Be(expectedTimeZone);
	}

	private async Task UpdateAndVerifyConfigurationTemplateAsync(
		string configurationTemplateId,
		string newName,
		string timeZone)
	{
		_ = await TestMerakiClient
			.Organizations
			.ConfigTemplates
			.UpdateOrganizationConfigTemplateAsync(
				Configuration.TestOrganizationId,
				configurationTemplateId,
				new ConfigurationTemplateUpdate
				{
					Name = newName,
					TimeZone = timeZone
				},
				cancellationToken: CancellationToken);

		await AssertConfigurationTemplateReadsBackAsync(configurationTemplateId, newName, timeZone);
	}

	/// <summary>
	/// VLANs have to be enabled on the template before one can be added to it.
	/// </summary>
	private async Task EnableVlansAndAddOneAsync(string configurationTemplateId)
	{
		_ = await TestMerakiClient
			.Appliance
			.Vlans
			.Settings
			.UpdateNetworkApplianceVlansSettingsAsync(
				configurationTemplateId,
				new VlansEnabledState
				{
					Enabled = true
				},
				cancellationToken: CancellationToken);

		_ = await TestMerakiClient
			.Appliance
			.Vlans
			.CreateNetworkApplianceVlanAsync(
				configurationTemplateId,
				new VlanCreationRequest
				{
					Id = "2",
					Name = "VLAN 2",
					Subnet = $"{PrivateNetworkFirst3Octets}.0/24",
					ApplianceIp = $"{PrivateNetworkFirst3Octets}.1"
				},
				cancellationToken: CancellationToken);
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
			.GetOrganizationNetworksAsync(
				Configuration.TestOrganizationId,
				configurationTemplate.Id,
				cancellationToken: CancellationToken);
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
				.Switch
				.ConfigTemplates
				.Profiles
				.GetOrganizationConfigTemplateSwitchProfilesAsync(
					Configuration.TestOrganizationId,
					configurationTemplate.Id,
					cancellationToken: CancellationToken);
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
			.GetOrganizationConfigTemplatesAsync(
				Configuration.TestOrganizationId,
				cancellationToken: CancellationToken);
		_ = configurationTemplates.Should().BeOfType<List<ConfigurationTemplate>>();
		_ = configurationTemplates.Should().NotBeNull();
		return configurationTemplates;
	}
}
