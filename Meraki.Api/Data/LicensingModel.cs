namespace Meraki.Api.Data;

[DataContract]
public enum LicensingModel
{
	[EnumMember(Value = "co-term")]
	CoTerm = 1,

	[EnumMember(Value = "per-device")]
	PerDevice,

	[EnumMember(Value = "subscription")]
	Subscription,
}