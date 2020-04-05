using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The number for the SSID
	/// </summary>
	[DataContract]
	public partial class GeneratedObject
	{
		/// <summary>
		/// Gets or Sets DevicePolicy
		/// </summary>
		[DataMember(Name = "devicePolicy", EmitDefaultValue = false)]
		public DevicePolicy2 DevicePolicy { get; set; }
		/// <summary>
		/// The ID of the desired group policy to apply to the client. Required if &#39;devicePolicy&#39; is set to \&quot;Group policy\&quot;. Otherwise this is ignored.
		/// </summary>
		/// <value>The ID of the desired group policy to apply to the client. Required if &#39;devicePolicy&#39; is set to \&quot;Group policy\&quot;. Otherwise this is ignored.</value>
		[DataMember(Name = "groupPolicyId", EmitDefaultValue = false)]
		public string GroupPolicyId { get; set; }
	}
}
