using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Camera overview
/// </summary>
[DataContract]
public class CameraOverview
{
	/// <summary>
	/// StartTs
	/// </summary>
	[DataMember(Name = "startTs")]
	public string StartTs { get; set; } = string.Empty;

	/// <summary>
	/// EndTs
	/// </summary>
	[DataMember(Name = "endTs")]
	public string EndTs { get; set; } = string.Empty;

	/// <summary>
	/// Zone id
	/// </summary>
	[DataMember(Name = "zoneId")]
	public int ZoneId { get; set; }

	/// <summary>
	/// Entrances
	/// </summary>
	[DataMember(Name = "entrances")]
	public int Entrances { get; set; }

	/// <summary>
	/// Average count
	/// </summary>
	[DataMember(Name = "averageCount")]
	public int AverageCount { get; set; }
}
