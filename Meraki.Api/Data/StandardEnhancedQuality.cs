namespace Meraki.Api.Data;

/// <summary>
/// Quality of the camera. Can be one of 'Standard' or 'Enhanced'.
/// </summary>
/// <value>Quality of the camera. Can be one of 'Standard' or 'Enhanced'.</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum StandardEnhancedQuality
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
	Enhanced
}
