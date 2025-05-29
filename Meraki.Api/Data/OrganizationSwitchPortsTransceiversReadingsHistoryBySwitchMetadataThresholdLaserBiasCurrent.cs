namespace Meraki.Api.Data;

/// <summary>
/// Minimum/maximum error and warning thresholds for laser bias current readings
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdLaserBiasCurrent
{
	/// <summary>
	/// Thresholds for laser bias current draw of the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "draw")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdLaserBiasCurrentDraw Draw { get; set; } = new();
}
