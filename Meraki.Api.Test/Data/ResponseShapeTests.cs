using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Test.Data;

/// <summary>
/// Regression tests for return types and member names that disagreed with the Dashboard API in a
/// way that stopped the response binding at all: a <c>List</c> declared where the API sends an
/// <c>{items, meta}</c> wrapper or a single object, a single object declared where the API sends an
/// array, and misspelt <c>[DataMember]</c> names. Each payload has the shape the v1.74.0 OpenAPI
/// spec documents, and is deserialized with the settings <see cref="JsonMissingMemberHandling.ThrowOnError"/>
/// uses so an unmapped field fails the test.
/// </summary>
public class ResponseShapeTests
{
	private static readonly JsonSerializerSettings ThrowOnMissingMember = new()
	{
		NullValueHandling = NullValueHandling.Ignore,
		MissingMemberHandling = MissingMemberHandling.Error,
		Converters = [new StringEnumConverter()]
	};

	private static T Deserialize<T>(string json)
	{
		var result = JsonConvert.DeserializeObject<T>(json, ThrowOnMissingMember);
		_ = result.Should().NotBeNull();
		return result!;
	}

	// GET /organizations/{organizationId}/networks/moves - an {items, meta} wrapper, previously
	// declared as List<NetworkMoveDetailed>. Also covers the "intiator" misspelling and the moveId
	// and result members the spec now carries.
	[Fact]
	public void Deserialize_NetworkMovesResponse_BindsWrapperAndInitiator()
	{
		const string json = """
			{
				"items": [
					{
						"moveId": "1234567890123456789",
						"createdAt": "2026-09-01T10:00:00Z",
						"lastUpdatedAt": "2026-09-01T10:05:00Z",
						"initiator": { "admin": { "id": "1" } },
						"network": { "id": "N_1" },
						"organizations": { "source": { "id": "10" }, "target": { "id": "20" } },
						"result": { "status": "completed", "reason": null }
					}
				],
				"meta": { "counts": { "items": { "total": 1, "remaining": 0 } } }
			}
			""";

		var response = Deserialize<NetworkMovesResponse>(json);

		_ = response.Items.Should().ContainSingle();
		_ = response.Items[0].MoveId.Should().Be("1234567890123456789");
		_ = response.Items[0].Initiator.Should().NotBeNull();
		_ = response.Items[0].Result.Should().NotBeNull();
		_ = response.Items[0].Result!.Status.Should().Be("completed");
		_ = response.Meta.Counts!.Items.Total.Should().Be(1);
	}

	// PUT /organizations/{organizationId}/sm/sentry/policies/assignments - an {items} wrapper with
	// no meta, previously declared as the item type.
	[Fact]
	public void Deserialize_SentryPoliciesAssignmentsUpdateResponse_BindsItems()
	{
		const string json = """
			{ "items": [ { "networkId": "N_1", "policies": [] } ] }
			""";

		var response = Deserialize<OrganizationSmSentryPoliciesAssignmentsUpdateResponse>(json);

		_ = response.Items.Should().ContainSingle().Which.NetworkId.Should().Be("N_1");
	}

	// GET /networks/{networkId}/appliance/firewall/inboundCellularFirewallRules - a {rules} object,
	// previously declared as List<MxFirewallRule>.
	[Fact]
	public void Deserialize_InboundCellularFirewallRules_BindsRulesObject()
	{
		const string json = """
			{ "rules": [ { "comment": "Allow", "policy": "allow", "protocol": "tcp", "srcPort": "Any", "srcCidr": "Any", "destPort": "443", "destCidr": "Any", "syslogEnabled": false } ] }
			""";

		var rules = Deserialize<InboundCellularFirewallRules>(json);

		_ = rules.Rules.Should().ContainSingle();
	}

	// GET /networks/{networkId}/appliance/firewall/firewalledServices/{service} - a single object,
	// previously declared as List<FirewalledService>.
	[Fact]
	public void Deserialize_FirewalledService_BindsSingleObject()
	{
		const string json = """
			{ "service": "ICMP", "access": "restricted", "allowedIps": [ "192.0.2.10" ] }
			""";

		var service = Deserialize<FirewalledService>(json);

		_ = service.AllowedIps.Should().ContainSingle();
	}

	// Misspelt [DataMember] names, each of which meant the property never bound.
	[Fact]
	public void Deserialize_ConnectivityEvents_BindsOccurredAt()
	{
		var events = Deserialize<ConnectivityEvents>("""{ "occurredAt": "2026-09-01T10:00:00Z" }""");

		_ = events.OccurredAt.Should().Be(new DateTime(2026, 9, 1, 10, 0, 0, DateTimeKind.Utc));
	}

	[Fact]
	public void Deserialize_SensorAlertConditionThresholdTemperature_BindsFahrenheit()
	{
		var threshold = Deserialize<SensorAlertConditionThresholdTemperature>("""{ "celsius": 20.5, "fahrenheit": 68.9 }""");

		_ = threshold.Fahrenheit.Should().Be(68.9);
	}

	[Fact]
	public void Deserialize_OrganizationSplashTheme_BindsThemeAssets()
	{
		var theme = Deserialize<OrganizationSplashTheme>("""{ "themeAssets": [] }""");

		_ = theme.ThemeAssets.Should().BeEmpty();
	}

	[Fact]
	public void Deserialize_OrganizationLicensingCotermLicenseMoveResponse_BindsMovedLicenses()
	{
		var response = Deserialize<OrganizationLicensingCotermLicenseMoveResponse>("""{ "movedLicenses": [] }""");

		_ = response.MovedLicenses.Should().BeEmpty();
	}

	[Fact]
	public void Deserialize_NetworksCampusGatewayClusterUplink_BindsAddresses()
	{
		var uplink = Deserialize<NetworksCampusGatewayClusterUplink>("""{ "addresses": [] }""");

		_ = uplink.Addresses.Should().BeEmpty();
	}
}
