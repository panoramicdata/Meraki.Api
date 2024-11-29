namespace Meraki.Api.Data;

/// <summary>
/// Floor Plans Recalculate Auto Locate Job Request
/// </summary>
[DataContract]
public class FloorPlansRecalculateAutoLocateJobRequest
{
	/// <summary>
	/// The list of devices to publish positions for
	/// </summary>
	[DataMember(Name = "devices")]
	public List<FloorPlansRecalculateAutoLocateJobRequestDevice> Devices { get; set; } = [];
}
