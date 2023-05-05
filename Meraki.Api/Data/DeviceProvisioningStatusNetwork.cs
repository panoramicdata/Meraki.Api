namespace Meraki.Api.Data;

[DataContract]
public class DeviceProvisioningStatusNetwork
{
	/// <summary>
	/// ID for the network containing the device
	/// </summary>
	[DataMember(Name = "id")]
	public string? Id { get; set; }

}
