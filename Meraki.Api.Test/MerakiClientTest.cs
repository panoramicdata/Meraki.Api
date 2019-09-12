using Meraki.Api.Test.Config;
using Meraki.Api.Test.Exceptions;
using Newtonsoft.Json;
using System.IO;
using Xunit;

namespace Meraki.Api.Test
{
	public class MerakiClientTest
	{
		private MerakiClient? _merakiClient;

		protected MerakiClient MerakiClient
		{
			get
			{
				// Have we already created this?
				if (_merakiClient != null)
				{
					// Yes - return that one
					return _merakiClient;
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
				var result = JsonConvert.DeserializeObject<Configuration>(File.ReadAllText(fileInfo.FullName));
				Assert.NotNull(result);
				Assert.NotNull(result.MerakiClientOptions);

				return _merakiClient = new MerakiClient(result.MerakiClientOptions);
			}
		}
	}
}