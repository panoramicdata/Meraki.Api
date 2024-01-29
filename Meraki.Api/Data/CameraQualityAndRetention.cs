namespace Meraki.Api.Data;

/// <summary>
/// UpdateDeviceCameraQualityAndRetentionSettings
/// </summary>
[DataContract]
public class CameraQualityAndRetention
{
	/// <summary>
	/// The ID of a quality and retention profile to assign to the camera. The profile's settings will override all of the per-camera quality and retention settings. If the value of this parameter is null, any existing profile will be unassigned from the camera.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "profileId")]
	public string ProfileId { get; set; } = string.Empty;

	/// <summary>
	/// Boolean indicating if motion-based retention is enabled(true) or disabled(false) on the camera
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "motionBasedRetentionEnabled")]
	public bool? MotionBasedRetentionEnabled { get; set; }

	/// <summary>
	/// Boolean indicating if audio recording is enabled(true) or disabled(false) on the camera
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "audioRecordingEnabled")]
	public bool? AudioRecordingEnabled { get; set; }

	/// <summary>
	/// Boolean indicating if restricted bandwidth is enabled(true) or disabled(false) on the camera. This setting does not apply to MV2 cameras.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "restrictedBandwidthModeEnabled")]
	public bool? RestrictedBandwidthModeEnabled { get; set; }

	/// <summary>
	/// Quality of the camera. Can be one of 'Standard', 'High' or 'Enhanced'. Not all qualities are supported by every camera model.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "quality")]
	public CameraQuality? Quality { get; set; }

	/// <summary>
	/// Gets or Sets Resolution
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "resolution")]
	public Resolution? Resolution { get; set; }

	/// <summary>
	/// Gets or Sets MotionDetectorVersion
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "motionDetectorVersion")]
	public MotionDetectorVersion? MotionDetectorVersion { get; set; }
}
