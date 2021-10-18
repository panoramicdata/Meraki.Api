using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	[DataContract]
	public enum AccessPolicyType
	{
		[EnumMember(Value = "Open")]
		Open = 1,

		[EnumMember(Value = "Custom access policy'")]
		CustomAccessPolicy,

		[EnumMember(Value = "MAC allow list")]
		MacAllowList,

		[EnumMember(Value = "Sticky MAC allow list")]
		StickyMacAllowList
	}
}