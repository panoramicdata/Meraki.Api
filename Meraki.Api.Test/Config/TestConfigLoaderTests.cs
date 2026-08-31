using Meraki.Api.Exceptions;
using Microsoft.Extensions.Configuration;

namespace Meraki.Api.Test.Config;

/// <summary>
/// Covers the binding and validation half of the test configuration chain. The chain itself reads
/// user secrets, which cannot be injected, so <see cref="TestConfigLoader.Bind"/> is separated from
/// <see cref="TestConfigLoader.Load"/> in order to be testable.
/// </summary>
public class TestConfigLoaderTests
{
	private static IConfiguration Configuration(Dictionary<string, string?> values)
		=> new ConfigurationBuilder().AddInMemoryCollection(values).Build();

	private static Dictionary<string, string?> CompleteConfiguration()
		=> new(StringComparer.Ordinal)
		{
			["MerakiClientOptions:ApiKey"] = "0000000000000000000000000000000000000000",
			["MerakiClientOptions:UserAgent"] = "Meraki.Api.Test/1.0 PanoramicData",
			["TestOrganizationId"] = "123456",
			["TestNetworkId"] = "N_000000000000000000",
			["TestDeviceSerial"] = "ABC1-DEF2-GHI3",
			["TestCameraNetworkId"] = "N_000000000000000001",
			["TestCameraSerial"] = "ABC1-DEF2-GHI4",
			["TestSwitchSerial"] = "ABC1-DEF2-GHI5",
			["TestMac"] = "12:34:ab:a1:cd:2e"
		};

	[Fact]
	public void Bind_WithCompleteConfiguration_Succeeds()
	{
		var config = TestConfigLoader.Bind(Configuration(CompleteConfiguration()));

		_ = config.MerakiClientOptions.ApiKey.Should().Be("0000000000000000000000000000000000000000");
		_ = config.TestOrganizationId.Should().Be("123456");
		_ = config.TestMac.Should().Be("12:34:ab:a1:cd:2e");
	}

	[Fact]
	public void Bind_WithNoConfigurationAtAll_ExplainsHowToSetSecrets()
	{
		var act = () => TestConfigLoader.Bind(Configuration([]));

		_ = act.Should()
			.Throw<ConfigurationException>()
			.WithMessage("*dotnet user-secrets*");
	}

	[Fact]
	public void Bind_WithNoConfigurationAtAll_StillMentionsTheAppSettingsFallback()
	{
		var act = () => TestConfigLoader.Bind(Configuration([]));

		_ = act.Should()
			.Throw<ConfigurationException>()
			.WithMessage("*appsettings.json*");
	}

	[Fact]
	public void Bind_WithAPartialConfiguration_ReportsTheMissingValue()
	{
		var values = CompleteConfiguration();
		_ = values.Remove("TestMac");

		var act = () => TestConfigLoader.Bind(Configuration(values));

		_ = act.Should()
			.Throw<ConfigurationException>()
			.WithMessage("*TestMac*");
	}

	/// <summary>
	/// Optional values are left null rather than being coerced to empty strings, because the tests
	/// that use them skip when they are absent.
	/// </summary>
	[Fact]
	public void Bind_WithOptionalValuesAbsent_LeavesThemNull()
	{
		var config = TestConfigLoader.Bind(Configuration(CompleteConfiguration()));

		_ = config.TestMt10Serial.Should().BeNull();
		_ = config.TestOrganizationIdSupportingPerDeviceLicensing.Should().BeNull();
	}
}
