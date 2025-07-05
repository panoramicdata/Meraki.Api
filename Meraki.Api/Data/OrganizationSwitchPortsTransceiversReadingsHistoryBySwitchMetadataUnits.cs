namespace Meraki.Api.Data;

/// <summary>
/// Information about which units each reading is provided in
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataUnits
{
	/// <summary>
	/// The units for the laser bias current values
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "laserBiasCurrent")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataUnitsLaserBiasCurrent LaserBiasCurrent { get; set; } = new();

	/// <summary>
	/// The units for the transmit and receive power values
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "power")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataUnitsPower Power { get; set; } = new();

	/// <summary>
	/// The units for the supply voltage values
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "supplyVoltage")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataUnitsSupplyVoltage SupplyVoltage { get; set; } = new();
}
