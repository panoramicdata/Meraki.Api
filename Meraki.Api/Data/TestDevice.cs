namespace Meraki.Api.Data;

[DataContract]
	/// <summary>
	/// Test Device
	/// </summary>
public class TestDevice
{
	[DataMember(Name = "serial")]
	/// <summary>
	/// Gets the serial
	/// </summary>
	public string Serial { get; set; }
	
	[DataMember(Name = "model")]
	/// <summary>
	/// Returns the MV Sense object detection model list for the given camera
	/// </summary>
	public string Model { get; set; }
	
	[DataMember(Name = "name")]
	/// <summary>
	/// Gets the name
	/// </summary>
	public string Name { get; set; }
}
