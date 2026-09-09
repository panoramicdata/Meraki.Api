using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Meraki.Api.Test.Data;

/// <summary>
/// Regression tests for Systems Manager response members the v1.74.0 OpenAPI spec documents that
/// the models lacked. Each payload has the shape the spec documents, and is deserialized with the
/// settings <see cref="JsonMissingMemberHandling.ThrowOnError"/> uses so an unmapped field fails
/// the test rather than being dropped.
/// </summary>
public class SmMemberTests
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

	// GET /organizations/{organizationId}/sm/vppAccounts/{vppAccountId}
	[Fact]
	public void Deserialize_SmVppAccount_MapsEveryDocumentedField()
	{
		var account = Deserialize<SmVppAccount>("""
			{ "vppAccountId": "1", "contentToken": "token", "email": "admin@example.com", "name": "Example VPP", "allowedAdmins": "All admins", "networkIdAdmins": "", "assignableNetworks": "All networks", "assignableNetworkIds": [ "N_1" ], "vppLocationId": "L_1", "vppLocationName": "Example", "lastSyncedAt": "2026-09-09T10:00:00Z", "lastForceSyncedAt": null, "parsedToken": { "orgName": "Example", "hashedToken": "abc", "expiresAt": "2027-01-01T00:00:00Z" }, "id": "1", "vppServiceToken": "token" }
			""");

		_ = account.VppAccountId.Should().Be("1");
		_ = account.AssignableNetworkIds.Should().ContainSingle();
		_ = account.ParsedToken!.OrgName.Should().Be("Example");
		_ = account.LastForceSyncedAt.Should().BeNull();
	}

	// GET /networks/{networkId}/sm/profiles
	[Fact]
	public void Deserialize_SmProfile_MapsPayloadTypes()
	{
		var profile = Deserialize<SmProfile>("""
			{ "id": "1", "name": "Wi-Fi", "description": "", "scope": "all", "tags": [], "payloadTypes": [ "com.apple.wifi.managed" ] }
			""");

		_ = profile.PayloadTypes.Should().ContainSingle();
	}

	// GET /networks/{networkId}/sm/trustedAccessConfigs
	[Fact]
	public void Deserialize_SmTrustedAccessConfig_MapsTimeboundType()
	{
		var config = Deserialize<SmTrustedAccessConfig>("""
			{ "id": "1", "ssidName": "Guest", "name": "Guests", "scope": "all", "tags": [], "timeboundType": "static", "sendExpirationEmails": false, "notifyTimeBeforeAccessEnds": 0, "additionalEmailText": "", "accessStartAt": "2026-09-01T00:00:00Z", "accessEndAt": "2026-09-30T00:00:00Z" }
			""");

		_ = config.TimeboundType.Should().Be("static");
	}

	// POST /networks/{networkId}/sm/devices/modifyTags - previously declared as returning the request
	// type, none of whose members the response contains.
	[Fact]
	public void Deserialize_SmDevicesModifyTagsResponse_MapsReturnedDevice()
	{
		var devices = Deserialize<List<SmDevicesModifyTagsResponse>>("""
			[ { "id": "1", "serial": "Q2XX-ABCD-1234", "wifiMac": "00:11:22:33:44:55", "tags": [ "sales" ] } ]
			""");

		_ = devices.Should().ContainSingle().Which.Tags.Should().ContainSingle();
	}
}
