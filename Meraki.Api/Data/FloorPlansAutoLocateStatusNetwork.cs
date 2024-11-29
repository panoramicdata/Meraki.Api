namespace Meraki.Api.Data;

/// <summary>
/// Floor Plan Auto Locate Status Network
/// </summary>
[DataContract]
public class FloorPlansAutoLocateStatusNetwork
{
	/// <summary>
	/// ID for the network containing the floorplan
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

}
