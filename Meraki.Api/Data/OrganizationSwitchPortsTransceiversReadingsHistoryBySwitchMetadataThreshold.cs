namespace Meraki.Api.Data;

/// <summary>
/// Thresholds to be applied to each metric in order to derive error/warning states.
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThreshold
{
	/// <summary>
	/// Unique identifier used to associate readings from the Small Form Factor Pluggable (SFP) module to the appropriate set of thresholds
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "thresholdSetId")]
	public string ThresholdSetId { get; set; } = string.Empty;

	/// <summary>
	/// Minimum/maximum error and warning thresholds for laser bias current readings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "laserBiasCurrent")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdLaserBiasCurrent LaserBiasCurrent { get; set; } = new();

	/// <summary>
	/// Minimum/maximum error and warning thresholds for power readings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "power")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdPower Power { get; set; } = new();

	/// <summary>
	/// Minimum/maximum error and warning thresholds for supply voltage readings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "supplyVoltage")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdSupplyVoltage SupplyVoltage { get; set; } = new();

	/// <summary>
	/// Minimum/maximum error and warning thresholds for temperature readings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "temperature")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdTemperature Temperature { get; set; } = new();
}
