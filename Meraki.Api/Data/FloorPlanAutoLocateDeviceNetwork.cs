namespace Meraki.Api.Data;

/// <summary>
/// Floor Plan Auto Locate Device Network
/// </summary>
[DataContract]
public class FloorPlansAutoLocateDeviceNetwork
{
	/// <summary>
	/// ID for the network containing this device
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}
