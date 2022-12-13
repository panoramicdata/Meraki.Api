namespace Meraki.Api.Data;

/// <summary>
/// Wireless settings Named Vlans Pool DHCP Monitoring
/// </summary>
[DataContract]
public class WirelessSettingsNamedVlansPoolDhcpMonitoring
{
	/// <summary>
	/// Enabled
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// Duration
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "duration")]
	public int? Duration { get; set; }
}
