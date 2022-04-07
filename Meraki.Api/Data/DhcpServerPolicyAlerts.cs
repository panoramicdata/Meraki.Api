namespace Meraki.Api.Data;

/// <summary>
/// additional information/config options for things like alerts/arp inspection
/// </summary>
[DataContract]
public class DhcpServerPolicyAlerts
{
	/// <summary>
	/// Whether Email alerts are enabled for the DhcpServerPolicy
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember]
	public DhcpServerPolicyAlertEnabledState Email { get; set; } = new();
}