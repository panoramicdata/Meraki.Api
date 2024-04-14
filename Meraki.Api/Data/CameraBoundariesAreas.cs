namespace Meraki.Api.Data;

/// <summary>
/// Camera Boundaries Areas
/// </summary>
[DataContract]
public class CameraBoundariesAreas
{
	/// <summary>
	/// The network id of the camera
	/// </summary>
	[ApiForeignKey(typeof(Network))]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// The serial number of the camera
	/// </summary>
	[ApiForeignKey(typeof(Device))]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Configured area boundaries of the camera
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "boundaries")]
	public CameraBoundariesAreasBoundaries Boundaries { get; set; } = new();
}
