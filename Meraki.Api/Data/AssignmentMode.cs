namespace Meraki.Api.Data;

/// <summary>
/// Assignment Mode
/// </summary>
[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum AssignmentMode
{
	[EnumMember(Value = "eui-64")]
	/// <summary>
	/// Eui64
	/// </summary>
	Eui64 = 1,

	[EnumMember(Value = "static")]
	/// <summary>
	/// Static
	/// </summary>
	Static
}
