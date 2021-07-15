using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSnmpSettings
	/// </summary>
	[DataContract]
	public partial class SnmpSettingsUpdateRequest
	{
		/// <summary>
		/// Gets or Sets Access
		/// </summary>
		[DataMember(Name = "access", EmitDefaultValue = false)]
		public SnmpAccess Access { get; set; }
		/// <summary>
		/// The SNMP community string. Only relevant if &#39;access&#39; is set to &#39;community&#39;.
		/// </summary>
		/// <value>The SNMP community string. Only relevant if &#39;access&#39; is set to &#39;community&#39;.</value>
		[DataMember(Name = "communityString", EmitDefaultValue = false)]
		public string CommunityString { get; set; } = string.Empty;
		/// <summary>
		/// The list of SNMP users. Only relevant if &#39;access&#39; is set to &#39;users&#39;.
		/// </summary>
		/// <value>The list of SNMP users. Only relevant if &#39;access&#39; is set to &#39;users&#39;.</value>
		[DataMember(Name = "users", EmitDefaultValue = false)]
		public List<User> Users { get; set; } = new();
	}
}
