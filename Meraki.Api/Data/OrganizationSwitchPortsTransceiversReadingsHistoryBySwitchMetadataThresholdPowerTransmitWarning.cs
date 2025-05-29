namespace Meraki.Api.Data;

/// <summary>
/// Warning thresholds for the power transmitted by the port
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdPowerTransmitWarning
{
	/// <summary>
	/// The value in dBm at or below which the transmitted power is considered to be in a warning state
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lower")]
	public int Lower { get; set; }

	/// <summary>
	/// The value in dBm at or above which the transmitted power is considered to be in a warning state
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "upper")]
	public int Upper { get; set; }
}