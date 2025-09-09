namespace Meraki.Api.Data;

/// <summary>
/// Information about the SLA policy to be applied to the peer
/// </summary>
[DataContract]
public class ThirdPartyVpnPeerSlaPolicy
{
	/// <summary>
	/// The ID of the SLA policy
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }
}
