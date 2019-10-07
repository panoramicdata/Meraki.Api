using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// WAN enabled status
	/// </summary>
	[DataContract]
	public enum WanEnabledStatus
	{
		/// <summary>
		/// Enabled
		/// </summary>
		[EnumMember(Value = "enabled")]
		Enabled,

		/// <summary>
		/// Disabled
		/// </summary>
		[EnumMember(Value = "disabled")]
		Disabled,

		/// <summary>
		/// Not configured
		/// </summary>
		[EnumMember(Value = "not configured")]
		NotConfigured
	}
}