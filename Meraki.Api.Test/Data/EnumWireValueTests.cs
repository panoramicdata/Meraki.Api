using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Test.Data;

public class EnumWireValueTests
{
	private static readonly JsonSerializerSettings Settings = new()
	{
		Converters = [new StringEnumConverter()]
	};

	[Theory]
	[InlineData("allowedCountries", Layer7FirewallRuleType.AllowedCountries)]
	[InlineData("blacklistedCountries", Layer7FirewallRuleType.BlacklistedCountries)]
	[InlineData("whitelistedCountries", Layer7FirewallRuleType.WhitelistedCountries)]
	public void DeserializeLayer7FirewallRuleType_CountryRules_Succeeds(string wireValue, Layer7FirewallRuleType expected)
	{
		var value = JsonConvert.DeserializeObject<Layer7FirewallRuleType>($"\"{wireValue}\"", Settings);

		_ = value.Should().Be(expected);
	}

	[Fact]
	public void DeserializeSplashPage_MicrosoftEntraId_Succeeds()
	{
		var value = JsonConvert.DeserializeObject<SplashPage>("\"Microsoft Entra ID\"", Settings);

		_ = value.Should().Be(SplashPage.MicrosoftEntraID);
	}

	[Theory]
	[InlineData("8021x-entra", AuthMode.Auth8021xEntra)]
	[InlineData("ipsk-with-radius-easy-psk", AuthMode.IpskWithRadiusEasyPsk)]
	[InlineData("open-enhanced-with-radius", AuthMode.OpenEnhancedWithRadius)]
	public void DeserializeAuthMode_NewModes_Succeeds(string wireValue, AuthMode expected)
	{
		var value = JsonConvert.DeserializeObject<AuthMode>($"\"{wireValue}\"", Settings);

		_ = value.Should().Be(expected);
	}

	[Fact]
	public void DeserializeProductType_CampusGateway_Succeeds()
	{
		var value = JsonConvert.DeserializeObject<ProductType>("\"campusGateway\"", Settings);

		_ = value.Should().Be(ProductType.CampusGateway);
	}

	[Fact]
	public void SerializeNewEnumMembers_UsesWireValue()
	{
		_ = JsonConvert.SerializeObject(SplashPage.MicrosoftEntraID, Settings).Should().Be("\"Microsoft Entra ID\"");
		_ = JsonConvert.SerializeObject(ProductType.CampusGateway, Settings).Should().Be("\"campusGateway\"");
		_ = JsonConvert.SerializeObject(AuthMode.Auth8021xEntra, Settings).Should().Be("\"8021x-entra\"");
	}
}
