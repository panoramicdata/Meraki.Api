using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Rule12
/// </summary>
[DataContract]
public class SwitchAccessControlListRule
{
	/// <summary>
	/// Description of the rule (optional).
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "comment")]
	public string Comment { get; set; } = null!;

	/// <summary>
	/// Gets or Sets Policy
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "policy")]
	public AllowOrDeny Policy { get; set; }

	/// <summary>
	/// Gets or Sets IpVersion
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ipVersion")]
	public IpVersion IpVersion { get; set; }

	/// <summary>
	/// Gets or Sets Protocol
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "protocol")]
	public TcpUdpAnyProtocol Protocol { get; set; }

	/// <summary>
	/// Source IP address (in IP or CIDR notation) or 'any'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "srcCidr")]
	public string SourceCidr { get; set; } = string.Empty;

	/// <summary>
	/// Source port. Must be in the range  of 1-65535 or 'any'. Default is 'any'
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "srcPort")]
	public string SourcePort { get; set; } = string.Empty;

	/// <summary>
	/// Destination IP address (in IP or CIDR notation) or 'any'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dstCidr")]
	public string DestinationCidr { get; set; } = string.Empty;

	/// <summary>
	/// Destination port. Must be in the range of 1-65535 or 'any'. Default is 'any'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "dstPort")]
	public string DestinationPort { get; set; } = string.Empty;

	/// <summary>
	/// Incoming traffic VLAN. Must be in the range of 1-4095 or 'any'. Default is 'any'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "vlan")]
	public string Vlan { get; set; } = string.Empty;
}
