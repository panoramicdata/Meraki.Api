namespace Meraki.Api.Data;

/// <summary>
/// Reading for the 'voltage' metric. This will only be present if the 'metric' property equals 'voltage'.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertTriggerVoltage
{
	/// <summary>
	/// Voltage reading in volts. 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "level")]
	public int Level { get; set; }
}