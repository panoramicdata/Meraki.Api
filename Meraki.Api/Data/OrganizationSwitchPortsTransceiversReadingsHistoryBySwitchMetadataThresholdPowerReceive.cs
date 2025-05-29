namespace Meraki.Api.Data;

/// <summary>
/// Thresholds for the power received by the port
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdPowerReceive
{
	/// <summary>
	/// Error thresholds for the power received by the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "error")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdPowerReceiveError Error { get; set; } = new();

	/// <summary>
	/// Warning thresholds for the power received by the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "warning")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdPowerReceiveWarning Warning { get; set; } = new();
}
