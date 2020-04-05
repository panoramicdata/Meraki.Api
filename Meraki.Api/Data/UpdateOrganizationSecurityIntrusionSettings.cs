using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateOrganizationSecurityIntrusionSettings
	/// </summary>
	[DataContract]
	public partial class UpdateOrganizationSecurityIntrusionSettings
	{
		/// <summary>
		/// Sets a list of specific SNORT® signatures to whitelist
		/// </summary>
		/// <value>Sets a list of specific SNORT® signatures to whitelist</value>
		[DataMember(Name = "whitelistedRules", EmitDefaultValue = false)]
		public List<WhitelistedRule> WhitelistedRules { get; set; }
	}
}
