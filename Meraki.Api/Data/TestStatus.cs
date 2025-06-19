namespace Meraki.Api.Data;

/// <summary>
/// Test Status
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TestStatus
{
	/// <summary>
	/// Abandoned
	/// </summary>
	[EnumMember(Value = "abandoned")]
	Abandoned,

	/// <summary>
	/// Delivered
	/// </summary>
	[EnumMember(Value = "delivered")]
	Delivered,

	/// <summary>
	/// Enqueued
	/// </summary>
	[EnumMember(Value = "enqueued")]
	Enqueued,

	/// <summary>
	/// Processing
	/// </summary>
	[EnumMember(Value = "processing")]
	Processing,

	/// <summary>
	/// Retrying
	/// </summary>
	[EnumMember(Value = "retrying")]
	Retrying
}