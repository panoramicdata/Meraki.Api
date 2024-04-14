using Newtonsoft.Json;

namespace Meraki.Api.Test.Organizations.ConfigurationChanges;

public class Tests(ITestOutputHelper iTestOutputHelper) : MerakiClientTest(iTestOutputHelper)
{
	private static readonly string[] _problematicDecodes = [
// This one doesn't work in Docker.
"""
{
	"occurredAt":"2023-04-17T10:57:23.46855Z",
	"networkId":"N_740279188749070379",
	"type":"channel_scan",
	"description":"Channel scan",
	"clientId":"",
	"clientDescription":"",
	"deviceSerial":"Q3AU-HM4D-JQ48",
	"deviceName":"MY-SHA-6MY0321-AP01",
	"ssidNumber":0,
	"ssidName":"",
	"eventData":
	{
		"aid":null,
		"alarm_id":null,
		"arp_resp":null,
		"arp_src":null,
		"attr":null,
		"auth_neg_dur":null,
		"band":null,
		"bssid":null,
		"channel":"2/1",
		"client_ip":null,
		"client_mac":null,
		"device":null,
		"dhcp_ip":null,
		"dhcp_lease_completed":null,
		"dhcp_resp":null,
		"dhcp_server":null,
		"dhcp_server_mac":null,
		"dos_count":null,
		"dst":null,
		"duration":null,
		"full_conn":null,
		"group":null,
		"http_resp":null,
		"identity":null,
		"instigator":null,
		"inter_arrival":null,
		"ip_resp":null,
		"ip_src":null,
		"is_8021x":null,
		"last_auth_ago":null,
		"last_known_client_ip":null,
		"packet":null,
		"radio":null,
		"reason":null,
		"rssi":null,
		"rtt":null,
		"state":null,
		"vap":null
	}
}
"""
	];

	[Fact]
	public void GetOrganizationConfigurationChangesAsync_Succeeds()
	{
		// Use Newtonsoft to deserialize ProblematicDecodes into a ChangeLogEntry
		// to see what fields are missing.
		foreach (var problematicDecode in _problematicDecodes)
		{
			var changeLogEntry = JsonConvert.DeserializeObject<ChangeLogEntry>(problematicDecode);
			_ = changeLogEntry.Should().NotBeNull();
		}
	}

	[Fact]
	public async Task GetChangeLogEntriesPagedAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.ConfigurationChanges
			.GetOrganizationConfigurationChangesAsync(Configuration.TestOrganizationId);
		_ = result.Should().BeOfType<List<ChangeLogEntry>>();
		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();
	}

	[Fact]
	public async Task GetAllAsync_Succeeds()
	{
		var result = await TestMerakiClient
			.Organizations
			.ConfigurationChanges
			.GetOrganizationConfigurationChangesAllAsync(organizationId: Configuration.TestOrganizationId, cancellationToken: CancellationToken.None);

		_ = result.Should().BeOfType<List<ChangeLogEntry>>();
		_ = result.Should().NotBeNull();
		_ = result.Should().NotBeEmpty();
	}
}
