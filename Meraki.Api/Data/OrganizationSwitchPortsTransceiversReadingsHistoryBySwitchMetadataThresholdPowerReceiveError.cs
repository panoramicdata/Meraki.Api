namespace Meraki.Api.Data;

/// <summary>
/// Error thresholds for the power received by the port
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdPowerReceiveError
{
	/// <summary>
	/// The value in dBm at or below which the received power is considered to be in an error state
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lower")]
	public int Lower { get; set; }

	/// <summary>
	/// The value in dBm at or above which the received power is considered to be in an error state
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "upper")]
	public int Upper { get; set; }
}