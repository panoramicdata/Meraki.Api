namespace Meraki.Api.Data;

/// <summary>
/// Height information for a device on a floor plan
/// </summary>
[DataContract]
public class FloorplanDeviceHeight
{
	/// <summary>
	/// Height above the floor in meters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "aboveFloor")]
	public object? AboveFloor { get; set; }
}
