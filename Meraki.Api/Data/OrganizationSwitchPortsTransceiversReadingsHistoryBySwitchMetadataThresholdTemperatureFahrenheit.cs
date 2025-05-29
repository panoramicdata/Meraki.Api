namespace Meraki.Api.Data;

/// <summary>
/// Thresholds for the temperature in fahrenheit of the port
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdTemperatureFahrenheit
{
	/// <summary>
	/// Error thresholds for the temperature in fahrenheit of the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "error")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdTemperatureFahrenheitError Error { get; set; } = new();

	/// <summary>
	/// Warning thresholds for the temperature in fahrenheit of the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "warning")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdTemperatureFahrenheitWarning Warning { get; set; } = new();
}
