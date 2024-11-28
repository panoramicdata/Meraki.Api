namespace Meraki.Api.Data;

/// <summary>
/// Floor Plans Auto Locate Job Response
/// </summary>
[DataContract]
public class FloorPlansPublishAutoLocateJobResponse
{
	/// <summary>
	/// Status of attempt to publish auto locate job
	/// </summary>
	[DataMember(Name = "success")]
	public bool Success { get; set; }
}
