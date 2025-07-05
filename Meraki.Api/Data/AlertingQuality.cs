namespace Meraki.Api.Data;

/// <summary>
/// Alerting Quality
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum AlertingQuality
{
	/// <summary>
	/// Fair
	/// </summary>
	[EnumMember(Value = "fair")]
	Fair,
	/// <summary>
	/// Good
	/// </summary>
	[EnumMember(Value = "good")]
	Good,
	/// <summary>
	/// Inadequate
	/// </summary>
	[EnumMember(Value = "inadequate")]
	Inadequate,
	/// <summary>
	/// Poor
	/// </summary>
	[EnumMember(Value = "poor")]
	Poor
}