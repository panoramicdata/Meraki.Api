namespace Meraki.Api.Test.Switch.AccessControlLists;

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
			await AssertOnlyTheDefaultRuleExistsAsync(testNetwork.Id);

			var denySsh = CreateRule("1. Deny SSH", AllowOrDeny.Deny, destinationPort: "22");
			var allowHttp = CreateRule("2. Allow HTTP", AllowOrDeny.Allow, destinationPort: "80");

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

			await AssertRulesAreInOrderAsync(testNetwork.Id, denySsh, allowHttp);
		}
		finally
		{
			await RemoveNetworkAsync(testNetwork.Id);
		}
	}

	/// <summary>
	/// A new network starts with only the implicit default rule.
	/// </summary>
	private async Task AssertOnlyTheDefaultRuleExistsAsync(string networkId)
	{
		var acls = await TestMerakiClient
			.Switch
			.AccessControlLists
			.GetNetworkSwitchAccessControlListsAsync(networkId, cancellationToken: CancellationToken);
		_ = acls.Should().NotBeNull();
		_ = acls.Rules.Should().ContainSingle();
		_ = acls.Rules[0].Comment.Should().Be(DefaultRuleComment);
	}

	/// <summary>
	/// The two new rules should come back ahead of the default rule, which always stays last.
	/// </summary>
	private async Task AssertRulesAreInOrderAsync(
		string networkId,
		SwitchAccessControlListRule denySsh,
		SwitchAccessControlListRule allowHttp)
	{
		var acls = await TestMerakiClient
			.Switch
			.AccessControlLists
			.GetNetworkSwitchAccessControlListsAsync(networkId, cancellationToken: CancellationToken);

		_ = acls.Should().NotBeNull();
		_ = acls.Rules.Should().HaveCount(3);
		_ = acls.Rules[0].Comment.Should().Be(denySsh.Comment);
		_ = acls.Rules[1].Comment.Should().Be(allowHttp.Comment);
		_ = acls.Rules[^1].Comment.Should().Be(DefaultRuleComment);
	}

	private const string DefaultRuleComment = "Default rule";

	/// <summary>
	/// The two rules differ only by comment, policy and destination port.
	/// </summary>
	private static SwitchAccessControlListRule CreateRule(string comment, AllowOrDeny policy, string destinationPort)
		=> new()
		{
			Comment = comment,
			Policy = policy,
			IpVersion = IpVersion.Ipv4,
			Protocol = TcpUdpAnyProtocol.Tcp,
			SourceCidr = "10.1.10.0/24",
			SourcePort = "any",
			DestinationCidr = "172.16.30.0/24",
			DestinationPort = destinationPort,
			Vlan = "10"
		};
}
