namespace Meraki.Api.Data;

/// <summary>
/// Minimize Changes settings
/// </summary>
[DataContract]
public class OrganizationsWirelessRadioAutoRfByNetworkBusyHourMinimizeChanges
{
	/// <summary>
	/// Toggle for enabling or disabling Busy Hour in a network
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}