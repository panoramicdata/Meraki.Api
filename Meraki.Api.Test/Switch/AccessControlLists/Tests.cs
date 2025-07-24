﻿namespace Meraki.Api.Test.Switch.AccessControlLists;

public class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	[Fact]
	public async Task GetNetworkSwitchAccessControlListsNestedInterface()
	{
		var testNetwork = await GetFirstNetworkAsync();
		var acls = await TestMerakiClient
			.Switch
			.AccessControlLists
			.GetNetworkSwitchAccessControlListsAsync(testNetwork.Id, cancellationToken: CancellationToken);
		_ = acls.Should().NotBeNull();
		_ = acls.Rules.Should().NotBeNullOrEmpty();
	}

	[Fact]
	public async Task GetNetworkSwitchAccessControlLists()
	{
		var testNetwork = await GetFirstNetworkAsync();
		var acls = await TestMerakiClient
			.Switch
			.AccessControlLists
			.GetNetworkSwitchAccessControlListsAsync(testNetwork.Id, cancellationToken: CancellationToken);
		_ = acls.Should().NotBeNull();
		_ = acls.Rules.Should().NotBeNullOrEmpty();
	}

	[Fact]
	public async Task CreateNewNetworkSwitchAccessControlLists()
	{
		var testNetwork = await CreateTestNetworkAsync();

		try
		{
			// Get the rules and check just the default is there
			var acls = await TestMerakiClient
				.Switch
				.AccessControlLists
				.GetNetworkSwitchAccessControlListsAsync(testNetwork.Id, cancellationToken: CancellationToken);
			_ = acls.Should().NotBeNull();
			_ = acls.Rules.Should().ContainSingle();
			_ = acls.Rules[0].Comment.Should().Be("Default rule");

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
			_ = await TestMerakiClient
				.Switch
				.AccessControlLists
				.UpdateNetworkSwitchAccessControlListsAsync(
					testNetwork.Id,
					new()
					{
						Rules =
						[
							denySsh,
							allowHttp
						]
					}, cancellationToken: CancellationToken
				);

			// Get the rules and check they're both there
			acls = await TestMerakiClient
				.Switch
				.AccessControlLists
				.GetNetworkSwitchAccessControlListsAsync(testNetwork.Id, cancellationToken: CancellationToken);

			// We should have 2 rules now
			_ = acls.Should().NotBeNull();
			_ = acls.Rules.Should().HaveCount(3);
			// Our new rules should be first
			_ = acls.Rules[0].Comment.Should().Be(denySsh.Comment);
			_ = acls.Rules[1].Comment.Should().Be(allowHttp.Comment);
			// The default rule should be last
			_ = acls.Rules[^1].Comment.Should().Be("Default rule");
		}
		finally
		{
			await RemoveNetworkAsync(testNetwork.Id);
		}
	}
}
