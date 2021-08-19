using Divergic.Logging.Xunit;
using FluentAssertions;
using Meraki.Api.Data;
using Meraki.Api.Exceptions;
using Meraki.Api.Test.Config;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;
using Xunit.Abstractions;

namespace Meraki.Api.Test
{
	public class MerakiClientTest
	{
		protected DateTimeOffset UtcNow { get; } = DateTimeOffset.UtcNow;

		protected DateTimeOffset Utc10DaysAgo => UtcNow - TimeSpan.FromDays(10);

		private MerakiClient? _merakiClient;

		private Configuration? _configuration;

		protected ICacheLogger Logger { get; }

		public MerakiClientTest(ITestOutputHelper iTestOutputHelper)
		{
			Logger = iTestOutputHelper.BuildLogger();
		}

		public Configuration Configuration
		{
			get
			{
				// Have we already created this?
				if (_configuration != null)
				{
					// Yes - return that one
					return _configuration;
				}
				// No - we need to create one

				// Load config from file
				var fileInfo = new FileInfo("../../../appsettings.json");

				// Does the config file exist?
				if (!fileInfo.Exists)
				{
					// No - hint to the user what to do
					throw new ConfigurationException("Missing appsettings.json.  Please copy the appsettings.example.json in the project root folder and set the various values appropriately.");
				}
				// Yes

				// Load in the config
				_configuration = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(fileInfo.FullName));
				if(_configuration is null)
				{
					throw new ConfigurationException("Configuration did not deserialize");
				}
				_configuration.Validate();
				return _configuration;
			}
		}

		protected MerakiClient MerakiClient
			=> _merakiClient ??= new MerakiClient(Configuration.MerakiClientOptions, Logger);

		protected async Task<Network> GetTestNetworkAsync()
		{
			var networks = await MerakiClient
				.Networks
				.GetAllAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			networks.Should().NotBeNull();
			networks.Should().NotBeEmpty();
			return networks[0];
		}
	}
}