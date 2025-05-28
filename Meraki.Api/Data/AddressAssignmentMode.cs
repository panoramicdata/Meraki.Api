namespace Meraki.Api.Data;

/// <summary>
/// Address Assignment Mode
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum AddressAssignmentMode
{
	/// <summary>
	/// Dynamic
	/// </summary>
	[EnumMember(Value = "dynamic")]
	Dynamic,

	/// <summary>
	/// Static
	/// </summary>
	[EnumMember(Value = "static")]
	Static
}