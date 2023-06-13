namespace Meraki.Api.Data;

/// <summary>
/// NetworkApplianceRfProfiles
/// </summary>
[DataContract]
public class NetworkApplianceRfProfiles
{
	/// <summary>
	/// RF Profiles
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "assigned")]
	public List<NetworkApplianceRfProfile>? Assigned { get; set; }
}
