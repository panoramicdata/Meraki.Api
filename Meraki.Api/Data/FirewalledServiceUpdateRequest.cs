using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkFirewalledService
	/// </summary>
	[DataContract]
	public partial class FirewalledServiceUpdateRequest
	{
		/// <summary>
		/// Gets or Sets Access
		/// </summary>
		[DataMember(Name = "access", EmitDefaultValue = false)]
		public Access Access { get; set; }
		/// <summary>
		/// An array of whitelisted IPs that can access the service. This field is required if \&quot;access\&quot; is set to \&quot;restricted\&quot;. Otherwise this field is ignored
		/// </summary>
		/// <value>An array of whitelisted IPs that can access the service. This field is required if \&quot;access\&quot; is set to \&quot;restricted\&quot;. Otherwise this field is ignored</value>
		[DataMember(Name = "allowedIps", EmitDefaultValue = false)]
		public List<string> AllowedIps { get; set; }
	}
}
