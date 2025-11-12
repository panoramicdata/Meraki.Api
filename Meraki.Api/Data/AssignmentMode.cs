namespace Meraki.Api.Data;

/// <summary>
/// Assignment Mode
/// </summary>
[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum AssignmentMode
{
	/// <summary>
	/// Eui64
	/// </summary>
	[EnumMember(Value = "eui-64")]
	Eui64 = 1,


	/// <summary>
	/// Static
	/// </summary>
	[EnumMember(Value = "static")]
	Static
}
