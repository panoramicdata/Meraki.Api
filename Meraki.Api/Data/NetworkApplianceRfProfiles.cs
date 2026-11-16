namespace Meraki.Api.Data;

/// <summary>
/// NetworkApplianceRfProfiles
/// </summary>
[DataContract]
[Obsolete("GET /networks/{networkId}/appliance/rfProfiles returns a bare JSON array, so GetNetworkApplianceRfProfiles now returns List<NetworkApplianceRfProfile>. This type is no longer used and will be removed.")]
public class NetworkApplianceRfProfiles
{
	/// <summary>
	/// RF Profiles
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "assigned")]
	public List<NetworkApplianceRfProfile>? Assigned { get; set; }
}
