namespace Meraki.Api.Data;

/// <summary>
/// Licensing Model
/// </summary>
[DataContract]
public enum LicensingModel
{
	/// <summary>
	/// Co Term
	/// </summary>
	[EnumMember(Value = "co-term")]
	CoTerm = 1,

	/// <summary>
	/// Per Device
	/// </summary>
	[EnumMember(Value = "per-device")]
	PerDevice,

	/// <summary>
	/// Subscription
	/// </summary>
	[EnumMember(Value = "subscription")]
	Subscription,
}
