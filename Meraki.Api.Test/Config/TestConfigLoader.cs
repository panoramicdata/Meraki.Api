using Meraki.Api.Exceptions;
using Microsoft.Extensions.Configuration;

namespace Meraki.Api.Test.Config;

/// <summary>
/// Builds the integration test configuration.
/// </summary>
/// <remarks>
/// User secrets are the primary source. They are keyed by the UserSecretsId in
/// Meraki.Api.Test.csproj and stored under the user profile, so every clone of this repository
/// resolves to the same credentials without an appsettings.json per working copy.
/// <para>
/// appsettings.json is still read, as an optional fallback for working copies set up before the
/// move to user secrets. It is gitignored, and any value in user secrets wins over it.
/// </para>
/// </remarks>
internal static class TestConfigLoader
{
	/// <summary>
	/// The legacy config file, which sits in the project directory, three levels above the build
	/// output the tests run from.
	/// </summary>
	/// <remarks>
	/// Resolved to an absolute path against <see cref="AppContext.BaseDirectory"/>, for two reasons:
	/// AddJsonFile resolves a relative path through a PhysicalFileProvider, which rejects "../"
	/// traversal outright, and the previous File.ReadAllText resolved against the current directory,
	/// so the file was only found when the tests happened to be run from the output directory.
	/// </remarks>
	private static string LegacyAppSettingsPath
		=> Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "..", "..", "..", "appsettings.json"));

	private const string MissingConfigurationMessage =
		"No test configuration found. Set it with user secrets, which are shared by every clone of this repository:\r\n" +
		"    dotnet user-secrets set \"MerakiClientOptions:ApiKey\" \"<your 40-character Meraki API key>\" --project Meraki.Api.Test\r\n" +
		"...and likewise for TestOrganizationId, TestNetworkId, TestDeviceSerial, TestCameraNetworkId, TestCameraSerial, TestSwitchSerial and TestMac.\r\n" +
		"To import an existing config in one go, pipe it in:\r\n" +
		"    Get-Content Meraki.Api.Test/appsettings.json | dotnet user-secrets set --project Meraki.Api.Test\r\n" +
		"See appsettings.example.json for the full shape. A local appsettings.json is still honoured as a fallback.";

	/// <summary>
	/// Loads and validates the test configuration.
	/// </summary>
	/// <exception cref="ConfigurationException">Thrown when the configuration is absent or incomplete.</exception>
	public static TestConfig Load()
		=> Bind(new ConfigurationBuilder()
			// Ordered so that user secrets override the legacy file rather than the other way round.
			.AddJsonFile(LegacyAppSettingsPath, optional: true)
			.AddUserSecrets(typeof(TestConfigLoader).Assembly, optional: true)
			.Build());

	/// <summary>
	/// Binds and validates an already-built configuration. Separated from <see cref="Load"/> so the
	/// binding and validation can be tested without a user secrets store.
	/// </summary>
	/// <exception cref="ConfigurationException">Thrown when the configuration is absent or incomplete.</exception>
	internal static TestConfig Bind(IConfiguration configuration)
	{
		var config = configuration.Get<TestConfig>();

		// Nothing configured at all reads as a setup problem, not as a missing value, so it gets the
		// instructions rather than the name of whichever property happened to be checked first.
		if (config?.MerakiClientOptions is null)
		{
			throw new ConfigurationException(MissingConfigurationMessage);
		}

		config.Validate();

		return config;
	}
}
