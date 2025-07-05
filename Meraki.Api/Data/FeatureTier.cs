namespace Meraki.Api.Data;

/// <summary>
/// Feature tier.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum FeatureTier
{
	/// <summary>
	/// Advantage
	/// </summary>
	[EnumMember(Value = "advantage")]
	Advantage,

	/// <summary>
	/// Essentials
	/// </summary>
	[EnumMember(Value = "essentials")]
	Essentials,

	/// <summary>
	/// Premier 
	/// </summary>
	[EnumMember(Value = "premier")]
	Premier
}