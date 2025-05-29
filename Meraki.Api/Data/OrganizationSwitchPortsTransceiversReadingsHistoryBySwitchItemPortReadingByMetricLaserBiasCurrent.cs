namespace Meraki.Api.Data;

/// <summary>
/// Information about the laser bias current of the port
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItemPortReadingByMetricLaserBiasCurrent
{
	/// <summary>
	/// Information about the laser bias current draw of the port, in mA 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "draw")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchItemPortReadingByMetricLaserBiasCurrentDraw Draw { get; set; } = new();
}
