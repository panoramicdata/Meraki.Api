namespace Meraki.Api.Data;

/// <summary>
/// Channel avoidance settings
/// </summary>
[DataContract]
public class OrganizationsWirelessRadioAutoRfByNetworkChannelAvoidance
{
	/// <summary>
	/// Toggle for enabling or disabling channel avoidance in a network
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }
}