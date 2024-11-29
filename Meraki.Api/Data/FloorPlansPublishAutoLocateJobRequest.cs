namespace Meraki.Api.Data;

/// <summary>
/// Update the status of a finished auto locate job to be published, and update device locations
/// </summary>
[DataContract]
public class FloorPlansPublishAutoLocateJobRequest
{
	/// <summary>
	/// The list of devices to publish positions for
	/// </summary>
	[DataMember(Name = "devices")]
	public List<FloorPlansPublishAutoLocateJobRequestDevice> Devices { get; set; } = [];
}
