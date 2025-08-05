namespace Meraki.Api.Data;

/// <summary>
/// Reading for the 'water' metric. This will only be present if the 'metric' property equals 'water'.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertTriggerWater
{
	/// <summary>
	/// True if water is detected. 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "present")]
	public bool Present { get; set; }
}