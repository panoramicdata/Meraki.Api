namespace Meraki.Api.Data;

/// <summary>
/// Reading for the 'current' metric. This will only be present if the 'metric' property equals 'current'.
/// </summary>
[DataContract]
public class OrganizationsSensorAlertTriggerCurrent
{
	/// <summary>
	/// Electrical current reading in amperes.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "draw")]
	public int Draw { get; set; }
}