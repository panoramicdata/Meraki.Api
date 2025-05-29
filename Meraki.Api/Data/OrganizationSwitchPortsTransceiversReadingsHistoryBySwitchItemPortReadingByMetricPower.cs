namespace Meraki.Api.Data;

/// <summary>
/// Information about the power transmitted and received by the port
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItemPortReadingByMetricPower
{
	/// <summary>
	/// Information about the power received by the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "receive")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItemPortReadingByMetricPowerReceive Receive { get; set; } = new();

	/// <summary>
	/// Information about the power transmitted by the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "transmit")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItemPortReadingByMetricPowerTransmit Transmit { get; set; } = new();
}
