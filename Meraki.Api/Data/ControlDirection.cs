namespace Meraki.Api.Data;

/// <summary>
/// Control Direction
/// </summary>
[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum ControlDirection
{
	/// <summary>
	/// Both
	/// </summary>
	[EnumMember(Value = "both")]
	Both = 1,


	/// <summary>
	/// Inbound
	/// </summary>
	[EnumMember(Value = "inbound")]
	Inbound
}
