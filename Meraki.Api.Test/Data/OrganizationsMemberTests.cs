using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Test.Data;

/// <summary>
/// Regression tests for Organizations-area response members the v1.74.0 OpenAPI spec documents that
/// the models lacked. Each payload has the shape the spec documents, and is deserialized with the
/// settings <see cref="JsonMissingMemberHandling.ThrowOnError"/> uses so an unmapped field fails
/// the test rather than being dropped.
/// </summary>
public class OrganizationsMemberTests
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

	// products.wireless.nextUpgrade from GET /networks/{networkId}/firmwareUpgrades
	[Fact]
	public void Deserialize_NextUpgrade_MapsStrategyAndPredownload()
	{
		var next = Deserialize<NextUpgrade>("""
			{ "time": "2026-09-10T02:00:00Z", "strategy": "minimizeClientDowntime", "predownload": { "enabled": true }, "toVersion": { "id": "1", "shortName": "MR 31.1", "firmware": "wireless-31-1", "releaseType": "stable", "releaseDate": "2026-08-01T00:00:00Z" } }
			""");

		_ = next.Strategy.Should().Be("minimizeClientDowntime");
		_ = next.Predownload!.Enabled.Should().BeTrue();
	}

	// GET /organizations/{organizationId}/summary/top/networks/byStatus
	[Fact]
	public void Deserialize_NetworkStatusSummary_MapsGroupAndPermissions()
	{
		var summary = Deserialize<NetworkStatusSummary>("""
			{ "networkId": "N_1", "name": "HQ", "url": "https://example.invalid", "tags": [], "productTypes": [ "wireless" ], "group": { "id": "G_1" }, "permissions": { "canWrite": true } }
			""");

		_ = summary.Group!.Id.Should().Be("G_1");
		_ = summary.Permissions!.CanWrite.Should().BeTrue();
	}

	// GET /organizations/{organizationId}/adaptivePolicy/overview
	[Fact]
	public void Deserialize_OrganizationAdaptivePolicyOverview_MapsLimitsAndNewCounts()
	{
		var overview = Deserialize<OrganizationAdaptivePolicyOverview>("""
			{ "counts": { "groups": 3, "customGroups": 2, "customAcls": 1, "policies": 4, "denyPolicies": 1, "allowPolicies": 3, "policyObjects": 5 }, "limits": { "customGroups": 100, "rulesInAnAcl": 200, "aclsInAPolicy": 10, "policyObjects": 500 } }
			""");

		_ = overview.Counts.CustomGroups.Should().Be(2);
		_ = overview.Counts.PolicyObjects.Should().Be(5);
		_ = overview.Limits!.RulesInAnAcl.Should().Be(200);
	}

	// items[] from GET /organizations/{organizationId}/assurance/alerts/overview/byType - the model
	// previously carried the by-network item's members, none of which the API sends here.
	[Fact]
	public void Deserialize_OrganizationAssuranceAlertsOverviewByTypeItem_MapsDocumentedShape()
	{
		var item = Deserialize<OrganizationAssuranceAlertsOverviewByTypeItem>("""
			{ "type": "device_offline", "categoryType": "connectivity", "severity": "critical", "count": 7, "networkCount": 2, "networks": [ { "id": "N_1", "name": "HQ" } ], "deviceTypes": [ "switch" ], "deviceTags": [ "core" ], "lastAlertedAt": "2026-09-09T10:00:00Z", "lastResolvedAt": null }
			""");

		_ = item.Count.Should().Be(7);
		_ = item.Networks.Should().ContainSingle().Which.Name.Should().Be("HQ");
		_ = item.LastResolvedAt.Should().BeNull();
	}

	// items[] from GET /organizations/{organizationId}/devices/syslogServers/roles/byNetwork - the
	// member is "available", not "availableRoles".
	[Fact]
	public void Deserialize_OrganizationDevicesSyslogServersRolesByNetworkItem_MapsAvailable()
	{
		var item = Deserialize<OrganizationDevicesSyslogServersRolesByNetworkItem>("""
			{ "network": { "id": "N_1" }, "available": [ { "name": "Wireless event log", "value": "Wireless event log" } ] }
			""");

		_ = item.AvailableRoles.Should().ContainSingle();
	}

	// GET /organizations/{organizationId}/webhooks/alertTypes - the example payload is nested, not
	// flattened onto the alert type.
	[Fact]
	public void Deserialize_WebhookAlertType_MapsExample()
	{
		var alertType = Deserialize<WebhookAlertType>("""
			{ "alertTypeId": "power_supply_down", "alertType": "Power supply went down", "example": { "version": "0.1", "sharedSecret": "secret", "sentAt": "2026-09-09T10:00:00Z", "alertId": "1", "alertType": "Power supply went down", "alertTypeId": "power_supply_down", "alertLevel": "critical", "occurredAt": "2026-09-09T09:59:00Z", "alertData": { "supply": 1 }, "organizationId": "1", "organizationName": "Example", "organizationUrl": "https://example.invalid", "deviceSerial": "Q2XX-ABCD-1234", "deviceMac": "00:11:22:33:44:55", "deviceName": "sw1", "deviceUrl": "https://example.invalid", "deviceTags": [], "deviceModel": "MS", "networkId": "N_1", "networkName": "HQ", "networkUrl": "https://example.invalid", "networkTags": [], "enrollmentString": null, "notes": null, "productTypes": [ "switch" ], "encryptedId": "x" } }
			""");

		_ = alertType.Example!.AlertLevel.Should().Be("critical");
		_ = alertType.Example.ProductTypes.Should().ContainSingle();
	}

	// GET /organizations/{organizationId}/saml/idps/{idpId}
	[Fact]
	public void Deserialize_SamlIdp_MapsSsoLoginUrlAndVisionConsumerUrl()
	{
		var idp = Deserialize<SamlIdp>("""
			{ "idpId": "1", "consumerUrl": "https://example.invalid/c", "visionConsumerUrl": "https://example.invalid/v", "x509certSha1Fingerprint": "00:11", "ssoLoginUrl": "https://example.invalid/sso", "sloLogoutUrl": "https://example.invalid/slo" }
			""");

		_ = idp.SsoLoginUrl.Should().Be("https://example.invalid/sso");
		_ = idp.VisionConsumerUrl.Should().Be("https://example.invalid/v");
	}
}
