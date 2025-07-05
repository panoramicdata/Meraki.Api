namespace Meraki.Api.Data;

/// <summary>
/// Error thresholds for laser bias current draw of the port
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdLaserBiasCurrentDrawError
{
	/// <summary>
	/// The value in mA at or below which the laser bias current is considered to be in an error state
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lower")]
	public int Lower { get; set; }

	/// <summary>
	/// The value in mA at or above which the laser bias current is considered to be in an error state
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "upper")]
	public int Upper { get; set; }
}