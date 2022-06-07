namespace Meraki.Api.Data;

/// <summary>
/// Quality of the camera. Can be one of 'Standard', 'Enhanced' or 'High'.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum StandardEnhancedHighQuality
{
	/// <summary>
	/// Enum Standard for "Standard"
	/// </summary>
	[EnumMember(Value = "Standard")]
	Standard,

	/// <summary>
	/// Enum Enhanced for "Enhanced"
	/// </summary>
	[EnumMember(Value = "Enhanced")]
	Enhanced,

	/// <summary>
	/// Enum High for "High"
	/// </summary>
	[EnumMember(Value = "High")]
	High
}