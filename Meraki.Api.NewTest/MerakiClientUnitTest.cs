using Divergic.Logging.Xunit;
using Meraki.Api.Data;
using Newtonsoft.Json;
using Xunit.Abstractions;

namespace Meraki.Api.NewTest;
public abstract class MerakiClientUnitTest
{
	protected string TestOrganizationId { get; }
	protected string TestSwitchSerial { get; }
	protected ICacheLogger Logger { get; }
	protected MerakiClient TestMerakiClient { get; }

	protected MerakiClientUnitTest(ITestOutputHelper testOutputHelper)
	{
		var testConfig = JsonConvert.DeserializeObject<TestConfig>(
			File.ReadAllText("../../../appsettings.json")
			);
		if (testConfig is null)
		{
			throw new InvalidDataException("API Config Data is empty");
		}

		var merakiClientOptions = new MerakiClientOptions
		{
			ApiKey = testConfig.ApiKey,
			ApiNode = testConfig.ApiNode
		};
		TestOrganizationId = testConfig.OrganizationId;
		TestSwitchSerial = testConfig.SwitchSerial;
		Logger = testOutputHelper.BuildLogger();
		TestMerakiClient = new MerakiClient(merakiClientOptions, Logger);
	}

	protected static NetworkCreationRequest GetValidNetworkCreationRequest(string networkName)
		=> new()
		{
			Name = networkName,
			Notes = "Test notes for unit test network.",
			TimeZone = "Europe/London",
			ProductTypes = new() {
				ProductType.Appliance,
				ProductType.Camera,
				ProductType.CellularGateway,
				ProductType.Switch,
				ProductType.Wireless },
			Tags = new() { "TestTag1", "TestTag2", "TestTag3" }
		};

	protected Task<Network> CreateValidNetworkAsync(string networkName)
		=> TestMerakiClient
			.Organizations
			.Networks
			.CreateOrganizationNetworkAsync(TestOrganizationId, GetValidNetworkCreationRequest(networkName));

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
