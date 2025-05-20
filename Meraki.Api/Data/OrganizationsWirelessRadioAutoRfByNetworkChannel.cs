namespace Meraki.Api.Data;

/// <summary>
/// Channel settings
/// </summary>
[DataContract]
public class OrganizationsWirelessRadioAutoRfByNetworkChannel
{
	/// <summary>
	/// Channel avoidance settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "avoidance")]
	public OrganizationsWirelessRadioAutoRfByNetworkChannelAvoidance Avoidance { get; set; } = new();
}
