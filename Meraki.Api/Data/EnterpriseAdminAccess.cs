namespace Meraki.Api.Data;

/// <summary>
/// Whether or not an SSID is accessible by 'enterprise' administrators ('access disabled' or 'access enabled')
/// </summary>
/// <value>Whether or not an SSID is accessible by 'enterprise' administrators ('access disabled' or 'access enabled')</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum EnterpriseAdminAccess
{
	/// <summary>
	/// Enum Disabled for "access disabled"
	/// </summary>
	[EnumMember(Value = "access disabled")]
	Disabled,

	/// <summary>
	/// Enum Enabled for "access enabled"
	/// </summary>
	[EnumMember(Value = "access enabled")]
	Enabled
}
