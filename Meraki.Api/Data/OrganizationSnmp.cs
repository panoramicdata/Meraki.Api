namespace Meraki.Api.Data;

/// <summary>
/// UpdateOrganizationSnmp
/// </summary>
[DataContract]
public class OrganizationSnmp
{
	/// <summary>
	/// Boolean indicating whether SNMP version 2c is enabled for the organization.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "v2cEnabled")]
	public bool V2cEnabled { get; set; }

	/// <summary>
	/// The v2 community string
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "v2CommunityString")]
	public string? V2CommunityString { get; set; }

	/// <summary>
	/// Boolean indicating whether SNMP version 3 is enabled for the organization.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "v3Enabled")]
	public bool V3Enabled { get; set; }

	/// <summary>
	/// The v3 User
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "v3User")]
	public string? V3User { get; set; }

	/// <summary>
	/// Gets or Sets V3AuthMode
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "v3AuthMode")]
	public SnmpV3AuthMode V3AuthMode { get; set; }

	/// <summary>
	/// Gets or Sets V3PrivMode
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "v3PrivMode")]
	public SnmpV3PrivMode V3PrivMode { get; set; }

	/// <summary>
	/// The list of IPv4 addresses that are allowed to access the SNMP server.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "peerIps")]
	public List<string> PeerIps { get; set; } = [];

	/// <summary>
	/// The Hostname
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "hostname")]
	public string Hostname { get; set; } = string.Empty;

	/// <summary>
	/// The Port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "port")]
	public int Port { get; set; }
}
