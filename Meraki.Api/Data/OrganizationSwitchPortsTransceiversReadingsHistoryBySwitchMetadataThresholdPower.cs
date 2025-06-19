namespace Meraki.Api.Data;

/// <summary>
/// Minimum/maximum error and warning thresholds for power readings
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdPower
{
	/// <summary>
	/// Thresholds for the power received by the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "receive")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdPowerReceive Receive { get; set; } = new();

	/// <summary>
	/// Thresholds for the power transmitted by the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "transmit")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdPowerTransmit Transmit { get; set; } = new();
}
