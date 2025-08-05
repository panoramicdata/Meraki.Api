namespace Meraki.Api.Data;

/// <summary>
/// A device switch port update request to change the PortSchedule ID.
/// </summary>
[DataContract]
public class SwitchPortUpdatePortScheduleIdRequest
{
	/// <summary>
	/// The ID of the port schedule. A value of null will clear the port schedule
	/// </summary>
	[DataMember(Name = "portScheduleId")]
	[JsonProperty(NullValueHandling = NullValueHandling.Include)]
	public string? PortScheduleId { get; set; }
}
