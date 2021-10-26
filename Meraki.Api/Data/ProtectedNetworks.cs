using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Set the included/excluded networks from the intrusion engine (optional - omitting will leave current config unchanged). This is available only in &#39;passthrough&#39; mode
	/// </summary>
	[DataContract]
	public class ProtectedNetworks
	{
		/// <summary>
		/// true/false whether to use special IPv4 addresses: https://tools.ietf.org/html/rfc5735 (required). Default value is true if none currently saved
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "useDefault")]
		public bool? UseDefault { get; set; }

		/// <summary>
		/// list of IP addresses or subnets being protected (required if 'useDefault' is false)
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "includedCidr")]
		public List<string> IncludedCidr { get; set; } = null!;

		/// <summary>
		/// list of IP addresses or subnets being excluded from protection (required if 'useDefault' is false)
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "excludedCidr")]
		public List<string> ExcludedCidr { get; set; } = null!;
	}
}
