namespace Meraki.Api.Data;

/// <summary>
/// Access points associated with Wireless LAN controllers
/// </summary>
[DataContract]
public class OrganizationWirelessControllerConnectionsItem
{
	/// <summary>
	/// Access points cloud ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Associated wireless LAN controller
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "controller")]
	public OrganizationWirelessControllerConnectionsItemController Controller { get; set; } = new();

	/// <summary>
	/// Access points network
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "network")]
	public OrganizationWirelessControllerConnectionsItemNetwork Network { get; set; } = new();
}
