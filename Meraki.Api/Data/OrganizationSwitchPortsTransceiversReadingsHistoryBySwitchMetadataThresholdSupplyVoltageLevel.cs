namespace Meraki.Api.Data;

/// <summary>
/// Thresholds for supply voltage level of the port
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdSupplyVoltageLevel
{
	/// <summary>
	/// Error thresholds for supply voltage level of the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "error")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdSupplyVoltageLevelError Error { get; set; } = new();

	/// <summary>
	/// Warning thresholds for supply voltage level of the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "warning")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdSupplyVoltageLevelWarning Warning { get; set; } = new();
}
