namespace Meraki.Api.Data;

/// <summary>
/// Default multicast setting for entire network. IGMP snooping and Flood unknown multicast traffic settings are enabled by default.
/// </summary>
[DataContract]
public class DefaultSettings
{
	/// <summary>
	/// IGMP snooping setting for entire network
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "igmpSnoopingEnabled")]
	public bool IgmpSnoopingEnabled { get; set; }

	/// <summary>
	/// Flood unknown multicast traffic setting for entire network
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "floodUnknownMulticastTrafficEnabled")]
	public bool FloodUnknownMulticastTrafficEnabled { get; set; }
}
