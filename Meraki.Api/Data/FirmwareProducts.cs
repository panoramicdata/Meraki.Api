namespace Meraki.Api.Data;

/// <summary>
/// Products
/// </summary>
[DataContract]
public class FirmwareProducts
{
	/// <summary>
	/// Appliance
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "appliance")]
	public FirmwareUpgradeProduct Appliance { get; set; } = new();

	/// <summary>
	/// Camera
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "camera")]
	public FirmwareUpgradeProduct Camera { get; set; } = new();

	/// <summary>
	/// CellularGateway
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "cellularGateway")]
	public FirmwareUpgradeProduct CellularGateway { get; set; } = new();

	/// <summary>
	/// environmental
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "environmental")]
	public FirmwareUpgradeProduct Environmental { get; set; } = new();

	/// <summary>
	/// sensor
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "sensor")]
	public FirmwareUpgradeProduct Sensor { get; set; } = new();

	/// <summary>
	/// switch
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "switch")]
	public FirmwareUpgradeProduct Switch { get; set; } = new();

	/// <summary>
	/// vmxHost
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "vmxHost")]
	public FirmwareUpgradeProduct VmxHost { get; set; } = new();

	/// <summary>
	/// wireless
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "wireless")]
	public FirmwareUpgradeProduct Wireless { get; set; } = new();

	/// <summary>
	/// cloudGateway - Deprecated from v1.38
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "cloudGateway")]
	public FirmwareUpgradeProduct CloudGateway { get; set; } = new();

	/// <summary>
	/// switchCatalyst
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "switchCatalyst")]
	public FirmwareUpgradeProduct SwitchCatalyst { get; set; } = new();
}
