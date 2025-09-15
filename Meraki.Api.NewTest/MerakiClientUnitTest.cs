using Divergic.Logging.Xunit;
using Meraki.Api.Data;
using Newtonsoft.Json;
using Xunit.Abstractions;

namespace Meraki.Api.NewTest;
public abstract class MerakiClientUnitTest
{
	protected string TestOrganizationId { get; }
	protected string TestSwitchSerial { get; }

	protected string TestApplianceSerial { get; }

	protected string TestMt40DeviceSerial { get; }

	protected TestConfig TestConfig { get; }

#pragma warning disable CS3003 // Type is not CLS-compliant
	protected ICacheLogger Logger { get; }
#pragma warning restore CS3003 // Type is not CLS-compliant
	protected MerakiClient TestMerakiClient { get; }

	protected MerakiClientUnitTest(ITestOutputHelper testOutputHelper)
	{
		var testConfig = JsonConvert.DeserializeObject<TestConfig>(
			File.ReadAllText("../../../appsettings.json")
			) ?? throw new InvalidDataException("API Config Data is empty");

		var merakiClientOptions = new MerakiClientOptions
		{
			ApiKey = testConfig.ApiKey,
		};

		if (testConfig.HttpClientInnerTimeoutSeconds.HasValue)
		{
			merakiClientOptions.HttpClientInnerTimeoutSeconds = testConfig.HttpClientInnerTimeoutSeconds.Value;
		}

		TestOrganizationId = testConfig.OrganizationId;
		TestSwitchSerial = testConfig.SwitchSerial;
		TestApplianceSerial = testConfig.ApplianceSerial;
		TestMt40DeviceSerial = testConfig.Mt40DeviceSerial;
		TestConfig = testConfig;
		Logger = testOutputHelper.BuildLogger();
		TestMerakiClient = new MerakiClient(merakiClientOptions, Logger);
	}

	protected static NetworkCreationRequest GetValidNetworkCreationRequest(string networkName)
		=> new()
		{
			Name = networkName,
			Notes = "Test notes for unit test network.",
			TimeZone = "Europe/London",
			ProductTypes = [
				ProductType.Appliance,
				ProductType.Camera,
				ProductType.CellularGateway,
				ProductType.Switch,
				ProductType.Wireless ],
			Tags = ["TestTag1", "TestTag2", "TestTag3"]
		};

	protected async Task<Network> CreateValidNetworkAsync(string networkName)
	{
		var existingNetworks = await TestMerakiClient
			.Organizations
			.Networks
			.GetOrganizationNetworksAsync(TestOrganizationId)
			.ConfigureAwait(false);

		return existingNetworks.Any(x => x.Name == networkName)
			? existingNetworks.First(x => x.Name == networkName)
			: await TestMerakiClient
				.Organizations
				.Networks
				.CreateOrganizationNetworkAsync(TestOrganizationId, GetValidNetworkCreationRequest(networkName))
			.ConfigureAwait(false);
	}

	protected static ConfigurationTemplateCreateRequest GetValidConfigurationTemplateCreationRequest(string configurationTemplateName)
		=> new()
		{
			Name = configurationTemplateName,
			TimeZone = "Europe/London"
		};

	protected Task<ConfigurationTemplate> CreateValidConfigurationTemplateAsync(string configurationTemplateName)
		=> TestMerakiClient
			.Organizations
			.ConfigTemplates
			.CreateOrganizationConfigTemplateAsync(
				TestOrganizationId,
				GetValidConfigurationTemplateCreationRequest(configurationTemplateName)
			);
}
