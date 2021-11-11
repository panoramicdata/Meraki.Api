using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Critical auth settings for when authentication is rejected by the RADIUS server
	/// </summary>
	[DataContract]
	public class CriticalAuth
	{
		/// <summary>
		/// VLAN that clients who use data will be placed on when RADIUS authentication fails. Will be null if hostMode is Multi-Auth
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "dataVlanId")]
		public int DataVlanId { get; set; }

		/// <summary>
		/// VLAN that clients who use voice will be placed on when RADIUS authentication fails. Will be null if hostMode is Multi-Auth
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "voiceVlanId")]
		public int VoiceVlanId { get; set; }

		/// <summary>
		/// Enable to suspend port bounce when RADIUS servers are unreachable
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "suspendPortBounce")]
		public bool SuspendPortBounce { get; set; }
	}
}