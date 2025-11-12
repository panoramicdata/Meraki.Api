namespace Meraki.Api.Data;

/// <summary>
/// Device Provisioning Status Network
/// </summary>
[DataContract]
[ApiAccessReadOnlyClass]
public class DeviceProvisioningStatusNetwork
{
	/// <summary>
	/// ID for the network containing the device
	/// </summary>
	[DataMember(Name = "id")]
	public string? Id { get; set; }
}
