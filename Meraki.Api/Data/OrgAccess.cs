namespace Meraki.Api.Data;

/// <summary>
/// The privilege of the dashboard administrator on the organization, e.g. 'full', 'read-only', 'enterprise', 'none',
/// 'camera-sensor' or a custom role ('custom-role:&lt;id&gt;:&lt;name&gt;').
/// Any value the API returns is kept and written back unchanged, so values not listed here do not fail deserialization.
/// </summary>
[JsonConverter(typeof(OrgAccessJsonConverter))]
public readonly record struct OrgAccess
{
	/// <summary>
	/// Creates an organization access value from the raw API string
	/// </summary>
	/// <param name="value">The raw API string, e.g. "full" or "custom-role:123:Example Role"</param>
	public OrgAccess(string value)
	{
		Value = value ?? throw new ArgumentNullException(nameof(value));
	}

	/// <summary>
	/// "full"
	/// </summary>
	public static OrgAccess Full { get; } = new("full");

	/// <summary>
	/// "read-only"
	/// </summary>
	public static OrgAccess Readonly { get; } = new("read-only");

	/// <summary>
	/// "enterprise"
	/// </summary>
	public static OrgAccess Enterprise { get; } = new("enterprise");

	/// <summary>
	/// "none"
	/// </summary>
	public static OrgAccess None { get; } = new("none");

	/// <summary>
	/// "camera-sensor"
	/// </summary>
	public static OrgAccess CameraSensor { get; } = new("camera-sensor");

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
/// Reads and writes <see cref="OrgAccess"/> as a plain JSON string
/// </summary>
internal sealed class OrgAccessJsonConverter : StringValueJsonConverter<OrgAccess>
{
	/// <inheritdoc />
	protected override OrgAccess Create(string value) => new(value);

	/// <inheritdoc />
	protected override string? GetValue(OrgAccess value) => value.Value;
}
