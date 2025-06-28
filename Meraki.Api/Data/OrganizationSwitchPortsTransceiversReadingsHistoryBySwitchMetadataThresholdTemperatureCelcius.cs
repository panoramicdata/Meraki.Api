namespace Meraki.Api.Data;

/// <summary>
/// Thresholds for the temperature in celsius of the port
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdTemperatureCelcius
{
	/// <summary>
	/// Error thresholds for the temperature in celsius of the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "error")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdTemperatureCelciusError Error { get; set; } = new();

	/// <summary>
	/// Warning thresholds for the temperature in celsius of the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "warning")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdTemperatureCelciusWarning Warning { get; set; } = new();

}
