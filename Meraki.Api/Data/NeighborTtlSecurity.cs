namespace Meraki.Api.Data;

/// <summary>
/// NeighborTtlSecurity
/// </summary>
[DataContract]
public class NeighborTtlSecurity
{
	/// <summary>
	/// Settings for BGP TTL security to protect BGP peering sessions from forged IP attacks.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}