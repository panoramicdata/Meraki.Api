namespace Meraki.Api.Data;

/// <summary>
/// Update SDWAN internet traffic preferences for an MX network
/// </summary>
public class ApplianceSdwanInternetPoliciesUpdate
{
	/// <summary>
	/// policies with respective traffic filters for an MX network
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "wanTrafficUplinkPreferences")]
	public List<WanTrafficUplinkPreference> wanTrafficUplinkPreferences { get; set; } = new();
}
