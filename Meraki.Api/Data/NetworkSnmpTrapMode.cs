namespace Meraki.Api.Data;

[JsonConverter(typeof(StringEnumConverter))]
public enum NetworkSnmpTrapMode
{
	/// <summary>
	/// Disabled
	/// </summary>
	[EnumMember(Value = "disabled")]
	Disabled,

	/// <summary>
	/// V1 / V2
	/// </summary>
	[EnumMember(Value = "v1/v2c")]
	V1orV2c,

	/// <summary>
	/// V3
	/// </summary>
	[EnumMember(Value = "v3")]
	V3
}
