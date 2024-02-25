namespace Meraki.Api.Data;

/// <summary>
/// Camera Boundaries Lines
/// </summary>
[DataContract]
public class CameraBoundariesLines
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
	/// Configured line boundaries of the camera
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "boundaries")]
	public CameraBoundariesLinesBoundaries Boundaries { get; set; } = new();
}
