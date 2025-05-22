namespace Meraki.Api.Data;

/// <summary>
/// Region Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum RegionType
{
	/// <summary>
	/// CNHE
	/// </summary>
	[EnumMember(Value = "CNHE")]
	CNHE,

	/// <summary>
	/// CloudHub
	/// </summary>
	[EnumMember(Value = "CloudHub")]
	CloudHub
}