namespace Meraki.Api.Data;

/// <summary>
/// Control Direction
/// </summary>
[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum ControlDirection
{
	[EnumMember(Value = "both")]
	/// <summary>
	/// Both
	/// </summary>
	Both = 1,

	[EnumMember(Value = "inbound")]
	/// <summary>
	/// Inbound
	/// </summary>
	Inbound
}
