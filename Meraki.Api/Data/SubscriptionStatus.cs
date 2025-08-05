namespace Meraki.Api.Data;

/// <summary>
/// Subscription Status
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum SubscriptionStatus
{
	/// <summary>
	/// Inactive
	/// </summary>
	[EnumMember(Value = "inactive")]
	Inactive,

	/// <summary>
	/// Active
	/// </summary>
	[EnumMember(Value = "active")]
	Active,

	/// <summary>
	/// Out of compliance
	/// </summary>
	[EnumMember(Value = "out_of_compliance")]
	OutOfCompliance,

	/// <summary>
	/// Expired
	/// </summary>
	[EnumMember(Value = "expired")]
	Expired,

	/// <summary>
	/// Canceled
	/// </summary>
	[EnumMember(Value = "canceled")]
	Canceled
}