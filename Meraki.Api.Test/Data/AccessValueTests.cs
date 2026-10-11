using Newtonsoft.Json;

namespace Meraki.Api.Test.Data;

/// <summary>
/// Admin and SAML role access values are open-ended: the API returns custom roles as
/// "custom-role:&lt;id&gt;:&lt;name&gt;" and values such as "camera-sensor" that a closed enum rejected,
/// failing the whole response. They must deserialize, parse and round-trip unchanged.
/// </summary>
public class AccessValueTests
{
	private const string CustomRoleWithName = "custom-role:123456789012345678:Example Role";
	private const string CustomRoleWithoutName = "custom-role:123456789012345678";

	[Theory]
	[InlineData(CustomRoleWithName, "Example Role")]
	[InlineData(CustomRoleWithoutName, null)]
	public void DeserializeSamlRoleNetwork_CustomRole_Succeeds(string access, string? expectedName)
	{
		var network = JsonConvert.DeserializeObject<SamlRoleNetwork>($"{{\"id\":\"L_1\",\"access\":\"{access}\"}}");

		_ = network!.Access.Value.Should().Be(access);
		_ = network.Access.IsCustomRole.Should().BeTrue();
		_ = network.Access.CustomRoleId.Should().Be("123456789012345678");
		_ = network.Access.CustomRoleName.Should().Be(expectedName);
	}

	[Theory]
	[InlineData(CustomRoleWithName, "Example Role")]
	[InlineData(CustomRoleWithoutName, null)]
	public void DeserializeAdminNetworkAccess_CustomRole_Succeeds(string access, string? expectedName)
	{
		var network = JsonConvert.DeserializeObject<AdminNetworkAccess>($"{{\"id\":\"L_1\",\"access\":\"{access}\"}}");

		_ = network!.Access.Value.Should().Be(access);
		_ = network.Access.CustomRoleId.Should().Be("123456789012345678");
		_ = network.Access.CustomRoleName.Should().Be(expectedName);
	}

	[Theory]
	[InlineData(CustomRoleWithName, "Example Role")]
	[InlineData(CustomRoleWithoutName, null)]
	public void DeserializeAdmin_CustomRoleOrgAccess_Succeeds(string orgAccess, string? expectedName)
	{
		var admin = JsonConvert.DeserializeObject<Admin>($"{{\"id\":\"1\",\"name\":\"Example\",\"orgAccess\":\"{orgAccess}\"}}");

		_ = admin!.OrganizationAccess.Value.Should().Be(orgAccess);
		_ = admin.OrganizationAccess.IsCustomRole.Should().BeTrue();
		_ = admin.OrganizationAccess.CustomRoleId.Should().Be("123456789012345678");
		_ = admin.OrganizationAccess.CustomRoleName.Should().Be(expectedName);
	}

	[Fact]
	public void DeserializeAdmin_CameraSensorOrgAccess_Succeeds()
	{
		var admin = JsonConvert.DeserializeObject<Admin>("{\"id\":\"1\",\"name\":\"Example\",\"orgAccess\":\"camera-sensor\"}");

		_ = admin!.OrganizationAccess.Should().Be(OrgAccess.CameraSensor);
		_ = admin.OrganizationAccess.IsCustomRole.Should().BeFalse();
	}

	[Fact]
	public void DeserializeAdmin_UnknownOrgAccess_IsKept()
	{
		var admin = JsonConvert.DeserializeObject<Admin>("{\"id\":\"1\",\"name\":\"Example\",\"orgAccess\":\"some-future-value\"}");

		_ = admin!.OrganizationAccess.Value.Should().Be("some-future-value");
		_ = admin.OrganizationAccess.CustomRoleId.Should().BeNull();
	}

	[Theory]
	[InlineData("full")]
	[InlineData("read-only")]
	[InlineData("enterprise")]
	[InlineData("none")]
	[InlineData("camera-sensor")]
	[InlineData(CustomRoleWithName)]
	[InlineData(CustomRoleWithoutName)]
	public void OrgAccess_RoundTripsUnchanged(string orgAccess)
	{
		var json = $"{{\"orgAccess\":\"{orgAccess}\"}}";

		var request = JsonConvert.DeserializeObject<AdminUpdateRequest>(json);

		_ = JsonConvert.SerializeObject(request, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore })
			.Should().Be(json);
	}

	[Theory]
	[InlineData("full")]
	[InlineData("read-only")]
	[InlineData("guest-ambassador")]
	[InlineData("monitor-only")]
	[InlineData("switchport")]
	[InlineData("switch-port-manager")]
	[InlineData("ssid-admin")]
	[InlineData("port-tags")]
	[InlineData("custom-role")]
	[InlineData(CustomRoleWithName)]
	[InlineData(CustomRoleWithoutName)]
	public void AccessPrivilege_RoundTripsUnchanged(string access)
	{
		var json = $"{{\"id\":\"L_1\",\"access\":\"{access}\"}}";

		var network = JsonConvert.DeserializeObject<SamlRoleNetwork>(json);

		_ = JsonConvert.SerializeObject(network).Should().Be(json);
	}

	[Fact]
	public void KnownValues_EqualStaticMembers()
	{
		_ = JsonConvert.DeserializeObject<OrgAccess>("\"full\"").Should().Be(OrgAccess.Full);
		_ = JsonConvert.DeserializeObject<OrgAccess>("\"read-only\"").Should().Be(OrgAccess.Readonly);
		_ = JsonConvert.DeserializeObject<OrgAccess>("\"enterprise\"").Should().Be(OrgAccess.Enterprise);
		_ = JsonConvert.DeserializeObject<OrgAccess>("\"none\"").Should().Be(OrgAccess.None);
		_ = (JsonConvert.DeserializeObject<OrgAccess>("\"full\"") == OrgAccess.Full).Should().BeTrue();
		_ = (JsonConvert.DeserializeObject<OrgAccess>("\"full\"") == OrgAccess.Readonly).Should().BeFalse();

		_ = JsonConvert.DeserializeObject<AccessPrivilege>("\"full\"").Should().Be(AccessPrivilege.Full);
		_ = JsonConvert.DeserializeObject<AccessPrivilege>("\"read-only\"").Should().Be(AccessPrivilege.ReadOnly);
		_ = JsonConvert.DeserializeObject<AccessPrivilege>("\"guest-ambassador\"").Should().Be(AccessPrivilege.GuestAmbassador);
		_ = JsonConvert.DeserializeObject<AccessPrivilege>("\"monitor-only\"").Should().Be(AccessPrivilege.MonitorOnly);
		_ = JsonConvert.DeserializeObject<AccessPrivilege>("\"switchport\"").Should().Be(AccessPrivilege.Switchport);
		_ = JsonConvert.DeserializeObject<AccessPrivilege>("\"switch-port-manager\"").Should().Be(AccessPrivilege.SwitchPortManager);
		_ = JsonConvert.DeserializeObject<AccessPrivilege>("\"ssid-admin\"").Should().Be(AccessPrivilege.Ssidadmin);
		_ = JsonConvert.DeserializeObject<AccessPrivilege>("\"port-tags\"").Should().Be(AccessPrivilege.Porttags);
		_ = JsonConvert.DeserializeObject<AccessPrivilege>("\"custom-role\"").Should().Be(AccessPrivilege.Customrole);
	}

	[Fact]
	public void Equality_IsCaseSensitive()
		=> _ = new OrgAccess("FULL").Should().NotBe(OrgAccess.Full);

	[Fact]
	public void CustomRoleName_ContainingColon_IsKeptWhole()
	{
		var access = new AccessPrivilege("custom-role:123456789012345678:Example: Role");

		_ = access.CustomRoleId.Should().Be("123456789012345678");
		_ = access.CustomRoleName.Should().Be("Example: Role");
	}

	[Theory]
	[InlineData("custom-role")]
	[InlineData("custom-role:")]
	[InlineData("custom-role::Example Role")]
	[InlineData("full")]
	public void NotACustomRole_HasNoId(string value)
	{
		var access = new AccessPrivilege(value);

		_ = access.IsCustomRole.Should().BeFalse();
		_ = access.CustomRoleId.Should().BeNull();
		_ = access.CustomRoleName.Should().BeNull();
	}

	[Fact]
	public void ToString_ReturnsRawValue()
	{
		_ = OrgAccess.Readonly.ToString().Should().Be("read-only");
		_ = new AccessPrivilege(CustomRoleWithName).ToString().Should().Be(CustomRoleWithName);
		_ = default(OrgAccess).ToString().Should().BeEmpty();
	}

	[Fact]
	public void Default_SerializesAsNull()
		=> _ = JsonConvert.SerializeObject(new AdminCreationRequest()).Should().Contain("\"orgAccess\":null");

	[Fact]
	public void UpdateRequest_UnsetOrgAccess_IsNotSent()
		=> _ = JsonConvert.SerializeObject(new AdminUpdateRequest { Name = "Example" }, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore })
			.Should().Be("{\"name\":\"Example\"}");

	[Fact]
	public void NullableAccess_DeserializesNull()
		=> _ = JsonConvert.DeserializeObject<OrgAccess?>("null").Should().BeNull();
}
