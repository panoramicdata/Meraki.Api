namespace Meraki.Api.Data;

/// <summary>
/// Warning thresholds for the temperature in celsius of the port
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdTemperatureCelciusWarning
{
	/// <summary>
	/// The value in celsius at or below which the temperature is considered to be in a warning state
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "lower")]
	public int Lower { get; set; }

	/// <summary>
	/// The value in celsius at or above which the temperature is considered to be in a warning state
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "upper")]
	public int Upper { get; set; }
}