namespace Meraki.Api.Data;

/// <summary>
/// Reading for the 'door' metric. This will only be present if the 'metric' property equals 'door'.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertTriggerDoor
{
	/// <summary>
	/// True if the door is open.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "open")]
	public bool Open { get; set; }
}