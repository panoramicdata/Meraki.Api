namespace Meraki.Api.Data;

/// <summary>
/// policies with respective traffic filters for an MX network
/// </summary>
public class WanTrafficUplinkPreferencesUpdateRequest
{
	/// <summary>
	/// policies with respective traffic filters for an MX network
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "wanTrafficUplinkPreferences")]
	public List<WanTrafficUplinkPreference> WanTrafficUplinkPreferences { get; set; } = new();
}
