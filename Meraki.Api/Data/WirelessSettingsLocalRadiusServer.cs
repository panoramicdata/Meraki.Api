namespace Meraki.Api.Data;

/// <summary>
/// Local RADIUS server settings for the wireless network
/// </summary>
[DataContract]
public class WirelessSettingsLocalRadiusServer
{
	/// <summary>
	/// The hostname of the local RADIUS server
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}
