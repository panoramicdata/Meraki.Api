namespace Meraki.Api.Data;

/// <summary>
/// Associated wireless controller
/// </summary>
[DataContract]
public class OrganizationWirelessDevicesWirelessControllersByDeviceController
{
	/// <summary>
	/// Associated wireless controller cloud ID 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;
}