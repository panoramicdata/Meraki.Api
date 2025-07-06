namespace Meraki.Api.Data;

/// <summary>
/// FRA settings
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesLatencyByNetworkFra
{
	/// <summary>
	/// Toggle to activate or deactivate FRA in a network, contingent on AI-RRM being enabled.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}