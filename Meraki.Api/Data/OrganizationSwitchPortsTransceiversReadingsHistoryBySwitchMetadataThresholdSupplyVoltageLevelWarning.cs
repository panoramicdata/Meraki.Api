namespace Meraki.Api.Data;

/// <summary>
/// Warning thresholds for supply voltage level of the port
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdSupplyVoltageLevelWarning
{
	/// <summary>
	/// The value in volts at or below which the supply voltage is considered to be in a warning state
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lower")]
	public int Lower { get; set; }

	/// <summary>
	/// The value in volts at or above which the supply voltage is considered to be in a warning state
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "upper")]
	public int Upper { get; set; }
}