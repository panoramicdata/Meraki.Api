namespace Meraki.Api.Data;

/// <summary>
/// Products (update request)
/// </summary>
[DataContract]
public class ProductsUpdateRequest
{
	/// <summary>
	/// Appliance
	/// </summary>
	[DataMember(Name = "appliance")]
	public NetworkFirmwareUpdateRequestProduct? Appliance { get; set; }

	/// <summary>
	/// Camera
	/// </summary>
	[DataMember(Name = "camera")]
	public NetworkFirmwareUpdateRequestProduct? Camera { get; set; }

	/// <summary>
	/// Cellular gateway
	/// </summary>
	[DataMember(Name = "cellularGateway")]
	public NetworkFirmwareUpdateRequestProduct? CellularGateway { get; set; }

	/// <summary>
	/// Environmental
	/// </summary>
	[DataMember(Name = "environmental")]
	public NetworkFirmwareUpdateRequestProduct? Environmental { get; set; }

	/// <summary>
	/// SecureConnect
	/// </summary>
	[DataMember(Name = "secureConnect")]
	public NetworkFirmwareUpdateRequestProduct? SecureConnect { get; set; }

	/// <summary>
	/// Switch
	/// </summary>
	[DataMember(Name = "switch")]
	public SwitchUpdate? Switch { get; set; }

	/// <summary>
	/// VMX Host
	/// </summary>
	[DataMember(Name = "vmxHost")]
	public NetworkFirmwareUpdateRequestProduct? VmxHost { get; set; }

	/// <summary>
	/// Wireless
	/// </summary>
	[DataMember(Name = "wireless")]
	public NetworkFirmwareUpdateRequestProduct? Wireless { get; set; }

	/// <summary>
	/// CloudGateway
	/// </summary>
	[DataMember(Name = "cloudGateway")]
	public NetworkFirmwareUpdateRequestProduct? CloudGateway { get; set; }

	/// <summary>
	/// SwitchCatalyst
	/// </summary>
	[DataMember(Name = "switchCatalyst")]
	public NetworkFirmwareUpdateRequestProduct? SwitchCatalyst { get; set; }
}
