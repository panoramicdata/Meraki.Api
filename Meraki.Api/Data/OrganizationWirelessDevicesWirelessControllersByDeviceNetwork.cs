namespace Meraki.Api.Data;

/// <summary>
/// Catalyst access point network
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesWirelessControllersByDeviceNetwork
{
	/// <summary>
	/// Catalyst access point network ID 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}