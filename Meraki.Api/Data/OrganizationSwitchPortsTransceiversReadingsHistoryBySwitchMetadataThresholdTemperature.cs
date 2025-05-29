namespace Meraki.Api.Data;

/// <summary>
/// Minimum/maximum error and warning thresholds for temperature readings
/// </summary>
[DataContract]
public class OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdTemperature
{
	/// <summary>
	/// Thresholds for the temperature in celsius of the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "celsius")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdTemperatureCelcius Celcius { get; set; } = new();

	/// <summary>
	/// Thresholds for the temperature in fahrenheit of the port
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "fahrenheit")]
	public OrganizationSwitchPortsTransceiversReadingsHistoryBySwitchMetadataThresholdTemperatureFahrenheit Fahrenheit { get; set; } = new();
}
