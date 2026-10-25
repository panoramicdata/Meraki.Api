namespace Meraki.Api.Data;

/// <summary>
/// NeighborFilter
/// </summary>
[DataContract]
public class NeighborFilter
{
	/// <summary>
	/// Filters routes advertised to an eBGP neighbor. Each entry must be an IPv4 CIDR string (e.g., '10.0.0.0/8' or '10.0.0.5/32').
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "out")]
	public List<string>? Out { get; set; }
}
