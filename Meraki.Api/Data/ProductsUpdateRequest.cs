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
	public Appliance Appliance { get; set; } = new();

	/// <summary>
	/// Camera
	/// </summary>
	[DataMember(Name = "camera")]
	public Appliance Camera { get; set; } = new();

	/// <summary>
	/// Cellular gateway
	/// </summary>
	[DataMember(Name = "cellularGateway")]
	public Appliance CellularGateway { get; set; } = new();

	/// <summary>
	/// Environmental
	/// </summary>
	[DataMember(Name = "environmental")]
	public Appliance Environmental { get; set; } = new();

	/// <summary>
	/// Switch
	/// </summary>
	[DataMember(Name = "switch")]
	public SwitchUpdate Switch { get; set; } = new();

	/// <summary>
	/// VMX Host
	/// </summary>
	[DataMember(Name = "vmxHost")]
	public Appliance VmxHost { get; set; } = new();

	/// <summary>
	/// Wireless
	/// </summary>
	[DataMember(Name = "wireless")]
	public Appliance Wireless { get; set; } = new();
}
