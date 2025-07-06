namespace Meraki.Api.Data;

/// <summary>
/// Thresholds for laser bias current draw of the port
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdLaserBiasCurrentDraw
{
	/// <summary>
	/// Error thresholds for laser bias current draw of the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "error")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdLaserBiasCurrentDrawError Error { get; set; } = new();

	/// <summary>
	/// Warning thresholds for laser bias current draw of the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "warning")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdLaserBiasCurrentDrawWarning Warning { get; set; } = new();
}
