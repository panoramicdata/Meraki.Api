namespace Meraki.Api.Data;

/// <summary>
/// Minimum/maximum error and warning thresholds for supply voltage readings
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdSupplyVoltage
{
	/// <summary>
	/// Thresholds for supply voltage level of the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "level")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdSupplyVoltageLevel Level { get; set; } = new();
}
