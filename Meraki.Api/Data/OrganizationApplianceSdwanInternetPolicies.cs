namespace Meraki.Api.Data;

/// <summary>
/// Organization Appliance SD-WAN Internet Policies
/// </summary>
[DataContract]
public class OrganizationApplianceSdwanInternetPolicies
{
	/// <summary>
	/// policies with respective traffic filters for an MX network
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "wanTrafficUplinkPreferences")]
	public List<OrganizationApplianceSdwanInternetPoliciesPreference> WanTrafficUplinkPreferences { get; set; } = [];
}
