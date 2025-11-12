namespace Meraki.Api.Data;

/// <summary>
/// Control Direction
/// </summary>
[DataContract]
[JsonConverter(typeof(StringEnumConverter))]
public enum ControlDirection
{
	[EnumMember(Value = "both")]
	Both = 1,

	[EnumMember(Value = "inbound")]
	Inbound
}
