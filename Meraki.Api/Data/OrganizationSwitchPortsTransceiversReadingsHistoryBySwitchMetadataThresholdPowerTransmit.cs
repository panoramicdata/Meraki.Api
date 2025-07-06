namespace Meraki.Api.Data;

/// <summary>
/// Thresholds for the power transmitted by the port
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdPowerTransmit
{
	/// <summary>
	/// Error thresholds for the power transmitted by the port
	/// </summary>
	[DataMember(Name = "error")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdPowerTransmitError Error { get; set; } = new();

	/// <summary>
	/// Warning thresholds for the power transmitted by the port
	/// </summary>
	[DataMember(Name = "warning")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdPowerTransmitWarning Warning { get; set; } = new();
}
