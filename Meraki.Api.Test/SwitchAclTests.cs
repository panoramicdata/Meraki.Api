using FluentAssertions;
using Meraki.Api.Data;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;

namespace Meraki.Api.Test
{
	public class SwitchAclTests : MerakiClientTest
	{
		public SwitchAclTests(ITestOutputHelper iTestOutputHelper) : base(iTestOutputHelper)
		{
		}

		[Fact]
		public async Task GetNetworkSwitchAccessControlLists()
		{
			var testNetwork = await GetFirstNetworkAsync().ConfigureAwait(false);
			var acls = await TestMerakiClient
				.SwitchAcls
				.GetAsync(testNetwork.Id)
				.ConfigureAwait(false);
			acls.Should().NotBeNull();
			acls.Rules.Should().NotBeNullOrEmpty();
		}

		[Fact]
		public async Task CreateNewNetworkSwitchAccessControlLists()
		{
			var testNetwork = await CreateTestNetworkAsync().ConfigureAwait(false);

			try
			{
				// Get the rules and check just the default is there
				var acls = await TestMerakiClient
					.SwitchAcls
					.GetAsync(testNetwork.Id)
					.ConfigureAwait(false);
				acls.Should().NotBeNull();
				acls.Rules.Should().ContainSingle();
				acls.Rules[0].Comment.Should().Be("Default rule");

				// Add a new rules
				var denySsh = new SwitchAccessControlListRule
				{
					Comment = "1. Deny SSH",
					Policy = AllowOrDeny.Deny,
					IpVersion = IpVersion.Ipv4,
					Protocol = TcpUdpAnyProtocol.Tcp,

					SourceCidr = "10.1.10.0/24",
					SourcePort = "any",
					DestinationCidr = "172.16.30.0/24",
					DestinationPort = "22",
					Vlan = "10"
				};
				var allowHttp = new SwitchAccessControlListRule
				{
					Comment = "2. Allow HTTP",
					Policy = AllowOrDeny.Allow,
					IpVersion = IpVersion.Ipv4,
					Protocol = TcpUdpAnyProtocol.Tcp,

					SourceCidr = "10.1.10.0/24",
					SourcePort = "any",
					DestinationCidr = "172.16.30.0/24",
					DestinationPort = "80",
					Vlan = "10"
				};

				// Update the rules
				await TestMerakiClient
					.SwitchAcls
					.UpdateAsync(
						testNetwork.Id,
						new()
						{
							Rules = new()
							{
								denySsh,
								allowHttp
							}
						}
					)
					.ConfigureAwait(false);

				// Get the rules and check they're both there
				acls = await TestMerakiClient
					.SwitchAcls
					.GetAsync(testNetwork.Id)
					.ConfigureAwait(false);

				// We should have 2 rules now
				acls.Should().NotBeNull();
				acls.Rules.Should().HaveCount(3);
				// Our new rules should be first
				acls.Rules[0].Comment.Should().Be(denySsh.Comment);
				acls.Rules[1].Comment.Should().Be(allowHttp.Comment);
				// The default rule should be last
				acls.Rules[^1].Comment.Should().Be("Default rule");
			}
			finally
			{
				await RemoveNetworkAsync(testNetwork.Id).ConfigureAwait(false);
			}
		}
	}
}
