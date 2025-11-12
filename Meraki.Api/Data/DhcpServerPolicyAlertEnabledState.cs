namespace Meraki.Api.Data;

/// <summary>
/// Dhcp Server Policy Alert Enabled State
/// </summary>
[DataContract]
public class DhcpServerPolicyAlertEnabledState
{
	/// <summary>
	/// Whether to enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}
