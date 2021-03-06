using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkClientPolicy
	/// </summary>
	[DataContract]
	public partial class ClientPolicyUpdateRequest
	{
		/// <summary>
		/// The policy to assign. Can be &#39;Whitelisted&#39;, &#39;Blocked&#39;, &#39;Normal&#39; or &#39;Group policy&#39;. Required.
		/// </summary>
		/// <value>The policy to assign. Can be &#39;Whitelisted&#39;, &#39;Blocked&#39;, &#39;Normal&#39; or &#39;Group policy&#39;. Required.</value>
		[DataMember(Name = "devicePolicy", EmitDefaultValue = false)]
		public string DevicePolicy { get; set; }
		/// <summary>
		/// [optional] If &#39;devicePolicy&#39; is set to &#39;Group policy&#39; this param is used to specify the group policy ID.
		/// </summary>
		/// <value>[optional] If &#39;devicePolicy&#39; is set to &#39;Group policy&#39; this param is used to specify the group policy ID.</value>
		[DataMember(Name = "groupPolicyId", EmitDefaultValue = false)]
		public string GroupPolicyId { get; set; }
	}
}
