namespace Meraki.Api.Data;

/// <summary>
/// No documentation available
/// </summary>
[DataContract]
public class DhcpServerPolicyAlerts
{
	/// <summary>
	/// Whether Email alerts are enabled for the DhcpServerPolicy
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "email")]
	public DhcpServerPolicyAlertEnabledState? Email { get; set; }
}