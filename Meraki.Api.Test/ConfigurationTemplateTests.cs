using FluentAssertions;
using Meraki.Api.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Meraki.Api.Test
{
	public class ConfigurationTemplateTest : MerakiClientTest
	{
		public ConfigurationTemplateTest(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
		{
		}

		[Fact]
		public async void GetNetworksByConfigTemplateIdAsync_Succeeds()
		{
			var configurationTemplates = await GetAllAsync().ConfigureAwait(false);
			if (configurationTemplates.Count == 0)
			{
				return;
			}

			var configurationTemplate = configurationTemplates[0];

			var result = await MerakiClient
				.Organizations
				.GetNetworksAsync(Configuration.TestOrganizationId, configurationTemplate.Id)
				.ConfigureAwait(false);
			result.Should().NotBeNull();
		}

		[Fact]
		public async void GetAllConfigurationTemplatesAsync_Succeeds()
		{
			var configurationTemplates = await GetAllAsync().ConfigureAwait(false);

			// Get their associated switch profiles (for the first up to 3)
			foreach (var configurationTemplate in configurationTemplates.Take(3))
			{
				var switchProfiles = await MerakiClient
				.SwitchProfiles
				.GetAllAsync(Configuration.TestOrganizationId, configurationTemplate.Id)
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
			var configurationTemplates = await MerakiClient
				.ConfigurationTemplates
				.GetAllAsync(Configuration.TestOrganizationId)
				.ConfigureAwait(false);
			configurationTemplates.Should().BeOfType<List<ConfigurationTemplate>>();
			configurationTemplates.Should().NotBeNull();
			return configurationTemplates;
		}
	}
}
