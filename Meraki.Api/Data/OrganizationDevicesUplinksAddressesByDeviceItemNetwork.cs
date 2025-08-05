namespace Meraki.Api.Data;

/// <summary>
/// Network info.
/// </summary>
[DataContract]
public class OrganizationDevicesUplinksAddressesByDeviceItemNetwork
{
	/// <summary>
	/// ID for the network containing the device.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}