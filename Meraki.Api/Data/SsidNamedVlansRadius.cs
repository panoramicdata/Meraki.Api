namespace Meraki.Api.Data;

/// <summary>
/// RADIUS settings. This param is only valid when authMode is 'open-with-radius' and ipAssignmentMode is not 'NAT mode'.
/// </summary>
[DataContract]
public class SsidNamedVlansRadius
{
	/// <summary>
	/// Guest VLAN settings. Used to direct traffic to a guest VLAN when none of the RADIUS servers are reachable or a client receives access-reject from the RADIUS server.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "guestVlan")]
	public SsidNamedVlansRadiusGuestVlan? GuestVlan { get; set; }
}
