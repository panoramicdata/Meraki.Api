namespace Meraki.Api.Data;

/// <summary>
/// NeighborIpv6
/// </summary>
[DataContract]
public class NeighborIpv6
{
	/// <summary>
	/// The IPv6 address of the neighbor.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

}
