namespace Meraki.Api.Data;

/// <summary>
/// Quality retention profile
/// </summary>
[DataContract]
public class CameraQualityRetentionProfile : CameraQualityRetentionProfileCreateUpdateRequest
{
	/// <summary>
	/// Id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Network id
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "networkId")]
	public string NetworkId { get; set; } = string.Empty;

	/// <summary>
	/// Video quality settings applied to all Axis cameras
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "axisVideoQuality")]
	public string? AxisVideoQuality { get; set; }
}
