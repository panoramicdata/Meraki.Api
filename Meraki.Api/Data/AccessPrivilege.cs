namespace Meraki.Api.Data;

/// <summary>
/// The privilege of the dashboard or SAML administrator on a network, e.g. 'full', 'read-only', 'guest-ambassador',
/// 'monitor-only', 'switchport', 'switch-port-manager', 'ssid-admin', 'port-tags' or a custom role
/// ('custom-role:&lt;id&gt;' or 'custom-role:&lt;id&gt;:&lt;name&gt;').
/// Any value the API returns is kept and written back unchanged, so values not listed here do not fail deserialization.
/// </summary>
[JsonConverter(typeof(AccessPrivilegeJsonConverter))]
public readonly record struct AccessPrivilege
{
	/// <summary>
	/// Creates a network access value from the raw API string
	/// </summary>
	/// <param name="value">The raw API string, e.g. "full" or "custom-role:123:Example Role"</param>
	public AccessPrivilege(string value)
	{
		Value = value ?? throw new ArgumentNullException(nameof(value));
	}

	/// <summary>
	/// "full"
	/// </summary>
	public static AccessPrivilege Full { get; } = new("full");

	/// <summary>
	/// "read-only"
	/// </summary>
	public static AccessPrivilege ReadOnly { get; } = new("read-only");

	/// <summary>
	/// "guest-ambassador"
	/// </summary>
	public static AccessPrivilege GuestAmbassador { get; } = new("guest-ambassador");

	/// <summary>
	/// "monitor-only"
	/// </summary>
	public static AccessPrivilege MonitorOnly { get; } = new("monitor-only");

	/// <summary>
	/// "switchport"
	/// </summary>
	public static AccessPrivilege Switchport { get; } = new("switchport");

	/// <summary>
	/// "switch-port-manager"
	/// </summary>
	public static AccessPrivilege SwitchPortManager { get; } = new("switch-port-manager");

	/// <summary>
	/// "ssid-admin"
	/// </summary>
	public static AccessPrivilege Ssidadmin { get; } = new("ssid-admin");

	/// <summary>
	/// "port-tags"
	/// </summary>
	public static AccessPrivilege Porttags { get; } = new("port-tags");

	/// <summary>
	/// The bare "custom-role" literal. Custom roles are normally returned with an id, see <see cref="IsCustomRole"/>.
	/// </summary>
	public static AccessPrivilege Customrole { get; } = new("custom-role");

	/// <summary>
	/// The raw API string. Null only for the default instance.
	/// </summary>
	public string Value { get; }

	/// <summary>
	/// Whether this is a custom role, "custom-role:&lt;id&gt;" or "custom-role:&lt;id&gt;:&lt;name&gt;"
	/// </summary>
	public bool IsCustomRole => CustomRole.TryParse(Value, out _, out _);

	/// <summary>
	/// The custom role id, or null if this is not a custom role
	/// </summary>
	public string? CustomRoleId => CustomRole.TryParse(Value, out var id, out _) ? id : null;

	/// <summary>
	/// The custom role name, or null if this is not a custom role or the value has no name
	/// </summary>
	public string? CustomRoleName => CustomRole.TryParse(Value, out _, out var name) ? name : null;

	/// <summary>
	/// Returns the raw API string
	/// </summary>
	public override string ToString() => Value ?? string.Empty;
}

/// <summary>
/// Reads and writes <see cref="AccessPrivilege"/> as a plain JSON string
/// </summary>
internal sealed class AccessPrivilegeJsonConverter : StringValueJsonConverter<AccessPrivilege>
{
	/// <inheritdoc />
	protected override AccessPrivilege Create(string value) => new(value);

	/// <inheritdoc />
	protected override string? GetValue(AccessPrivilege value) => value.Value;
}
