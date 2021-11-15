namespace Meraki.Api.Data;

/// <summary>
/// Camera zone history
/// </summary>
[DataContract]
public class CameraZoneHistory
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
