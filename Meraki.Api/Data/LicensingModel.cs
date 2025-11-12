namespace Meraki.Api.Data;

/// <summary>
/// Licensing Model
/// </summary>
[DataContract]
public enum LicensingModel
{
	[EnumMember(Value = "co-term")]
	/// <summary>
	/// Co Term
	/// </summary>
	CoTerm = 1,

	[EnumMember(Value = "per-device")]
	/// <summary>
	/// Per Device
	/// </summary>
	PerDevice,

	[EnumMember(Value = "subscription")]
	/// <summary>
	/// Subscription
	/// </summary>
	Subscription,
}
