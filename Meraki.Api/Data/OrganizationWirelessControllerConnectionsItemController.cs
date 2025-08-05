namespace Meraki.Api.Data;

/// <summary>
/// Associated wireless LAN controller
/// </summary>
[DataContract]
public class OrganizationWirelessControllerConnectionsItemController
{
	/// <summary>
	/// Associated wireless LAN controller cloud ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}