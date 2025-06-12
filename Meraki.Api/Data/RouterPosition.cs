namespace Meraki.Api.Data;

/// <summary>
/// Router Position 
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum RouterPosition
{
	/// <summary>
	/// BDR
	/// </summary>
	[EnumMember(Value = "BDR")]
	Bdr,

	/// <summary>
	/// DR
	/// </summary>
	[EnumMember(Value = "DR")]
	Dr,

	/// <summary>
	/// Other
	/// </summary>
	[EnumMember(Value = "other")]
	Other
}