namespace Meraki.Api.Data;

/// <summary>
/// Authentication settings between BGP peers.
/// </summary>
[DataContract]
public class NeighborAuthentication
{
	/// <summary>
	/// Password to configure MD5 authentication between BGP peers.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "password")]
	public string? Password { get; set; }

}
