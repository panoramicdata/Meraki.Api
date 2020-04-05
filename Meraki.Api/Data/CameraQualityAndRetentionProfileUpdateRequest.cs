using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateDeviceCameraQualityAndRetentionSettings
	/// </summary>
	[DataContract]
	public partial class CameraQualityAndRetentionProfileUpdateRequest
	{
		/// <summary>
		/// The ID of a quality and retention profile to assign to the camera. The profile&#39;s settings will override all of the per-camera quality and retention settings. If the value of this parameter is null, any existing profile will be unassigned from the camera.
		/// </summary>
		/// <value>The ID of a quality and retention profile to assign to the camera. The profile&#39;s settings will override all of the per-camera quality and retention settings. If the value of this parameter is null, any existing profile will be unassigned from the camera.</value>
		[DataMember(Name = "profileId", EmitDefaultValue = false)]
		public string ProfileId { get; set; } = null!;

		/// <summary>
		/// Boolean indicating if motion-based retention is enabled(true) or disabled(false) on the camera
		/// </summary>
		/// <value>Boolean indicating if motion-based retention is enabled(true) or disabled(false) on the camera</value>
		[DataMember(Name = "motionBasedRetentionEnabled", EmitDefaultValue = false)]
		public bool? MotionBasedRetentionEnabled { get; set; }

		/// <summary>
		/// Boolean indicating if audio recording is enabled(true) or disabled(false) on the camera
		/// </summary>
		/// <value>Boolean indicating if audio recording is enabled(true) or disabled(false) on the camera</value>
		[DataMember(Name = "audioRecordingEnabled", EmitDefaultValue = false)]
		public bool? AudioRecordingEnabled { get; set; }

		/// <summary>
		/// Boolean indicating if restricted bandwidth is enabled(true) or disabled(false) on the camera
		/// </summary>
		/// <value>Boolean indicating if restricted bandwidth is enabled(true) or disabled(false) on the camera</value>
		[DataMember(Name = "restrictedBandwidthModeEnabled", EmitDefaultValue = false)]
		public bool? RestrictedBandwidthModeEnabled { get; set; }

		/// <summary>
		/// Gets or Sets Quality
		/// </summary>
		[DataMember(Name = "quality", EmitDefaultValue = false)]
		public StandardEnhancedHighQuality Quality { get; set; }

		/// <summary>
		/// Gets or Sets Resolution
		/// </summary>
		[DataMember(Name = "resolution", EmitDefaultValue = false)]
		public Resolution Resolution { get; set; }

		/// <summary>
		/// Gets or Sets MotionDetectorVersion
		/// </summary>
		[DataMember(Name = "motionDetectorVersion", EmitDefaultValue = false)]
		public MotionDetectorVersion MotionDetectorVersion { get; set; }
	}
}
