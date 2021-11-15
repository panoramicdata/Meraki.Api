using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Camera zone
/// </summary>
[DataContract]
public class CameraZone
{
	/// <summary>
	/// Id
	/// </summary>
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Type
	/// </summary>
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Label
	/// </summary>
	[DataMember(Name = "label")]
	public string Label { get; set; } = string.Empty;

	/// <summary>
	/// Region of interest
	/// </summary>
	[DataMember(Name = "regionOfInterest")]
	public RegionOfInterest RegionOfInterest { get; set; } = new();
}
