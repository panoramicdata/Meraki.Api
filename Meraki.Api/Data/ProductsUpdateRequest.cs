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
	public Appliance? Appliance { get; set; }

	/// <summary>
	/// Camera
	/// </summary>
	[DataMember(Name = "camera")]
	public Appliance? Camera { get; set; }

	/// <summary>
	/// Cellular gateway
	/// </summary>
	[DataMember(Name = "cellularGateway")]
	public Appliance? CellularGateway { get; set; }

	/// <summary>
	/// Environmental
	/// </summary>
	[DataMember(Name = "environmental")]
	public Appliance? Environmental { get; set; }

	/// <summary>
	/// Switch
	/// </summary>
	[DataMember(Name = "switch")]
	public SwitchUpdate? Switch { get; set; }

	/// <summary>
	/// VMX Host
	/// </summary>
	[DataMember(Name = "vmxHost")]
	public Appliance? VmxHost { get; set; }

	/// <summary>
	/// Wireless
	/// </summary>
	[DataMember(Name = "wireless")]
	public Appliance? Wireless { get; set; }

	/// <summary>
	/// CloudGateway
	/// </summary>
	[DataMember(Name = "cloudGateway")]
	public Appliance? CloudGateway { get; set; }

	/// <summary>
	/// SwitchCatalyst
	/// </summary>
	[DataMember(Name = "switchCatalyst")]
	public Appliance? SwitchCatalyst { get; set; }
}
