namespace Meraki.Api.Data;

/// <summary>
/// Information
/// </summary>
[DataContract]
public class OrganizationDevicesPowerModuleStatusSlot
{
	/// <summary>
	/// Which slot the AC power supply occupies.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "number")]
	public int Number { get; set; }

	/// <summary>
	/// The power supply unit model.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "model")]
	public string Model { get; set; } = string.Empty;

	/// <summary>
	/// The power supply unit serial number.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Status of the power supply unit. Possible values are: connected, not connected, powering.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public PowerSupplyStatus Status { get; set; }
}
