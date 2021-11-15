using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkSnmpSettings
/// </summary>
[DataContract]
public class NetworkSnmpSetting
{
	/// <summary>
	/// Gets or Sets Access
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "access")]
	public SnmpAccess Access { get; set; }
	/// <summary>
	/// The SNMP community string. Only relevant if 'access' is set to 'community'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "communityString")]
	public string? CommunityString { get; set; }

	/// <summary>
	/// The list of SNMP users. Only relevant if 'access' is set to 'users'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "users")]
	public List<User> Users { get; set; } = new();
}
