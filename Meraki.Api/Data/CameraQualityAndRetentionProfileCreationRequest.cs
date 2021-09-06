using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateNetworkCameraQualityRetentionProfile
	/// </summary>
	[DataContract]
	public class CameraQualityAndRetentionProfileCreationRequest
	{
		/// <summary>
		/// The name of the new profile. Must be unique. This parameter is required.
		/// </summary>
		/// <value>The name of the new profile. Must be unique. This parameter is required.</value>
		[DataMember(Name = "name")]
		public string Name { get; set; } = null!;

		/// <summary>
		/// Deletes footage older than 3 days in which no motion was detected. Can be either true or false. Defaults to false.
		/// </summary>
		/// <value>Deletes footage older than 3 days in which no motion was detected. Can be either true or false. Defaults to false.</value>
		[DataMember(Name = "motionBasedRetentionEnabled")]
		public bool? MotionBasedRetentionEnabled { get; set; }

		/// <summary>
		/// Disable features that require additional bandwidth such as Motion Recap. Can be either true or false. Defaults to false.
		/// </summary>
		/// <value>Disable features that require additional bandwidth such as Motion Recap. Can be either true or false. Defaults to false.</value>
		[DataMember(Name = "restrictedBandwidthModeEnabled")]
		public bool? RestrictedBandwidthModeEnabled { get; set; }

		/// <summary>
		/// Whether or not to record audio. Can be either true or false. Defaults to false.
		/// </summary>
		/// <value>Whether or not to record audio. Can be either true or false. Defaults to false.</value>
		[DataMember(Name = "audioRecordingEnabled")]
		public bool? AudioRecordingEnabled { get; set; }

		/// <summary>
		/// Create redundant video backup using Cloud Archive. Can be either true or false. Defaults to false.
		/// </summary>
		/// <value>Create redundant video backup using Cloud Archive. Can be either true or false. Defaults to false.</value>
		[DataMember(Name = "cloudArchiveEnabled")]
		public bool? CloudArchiveEnabled { get; set; }

		/// <summary>
		/// The version of the motion detector that will be used by the camera. Only applies to Gen 2 cameras. Defaults to v2.
		/// </summary>
		/// <value>The version of the motion detector that will be used by the camera. Only applies to Gen 2 cameras. Defaults to v2.</value>
		[DataMember(Name = "motionDetectorVersion")]
		public int? MotionDetectorVersion { get; set; }

		/// <summary>
		/// Schedule for which this camera will record video, or &#39;null&#39; to always record.
		/// </summary>
		/// <value>Schedule for which this camera will record video, or &#39;null&#39; to always record.</value>
		[DataMember(Name = "scheduleId")]
		public string ScheduleId { get; set; } = null!;

		/// <summary>
		/// The maximum number of days for which the data will be stored, or &#39;null&#39; to keep data until storage space runs out. If the former, it can be one of [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 14, 30, 60, 90] days
		/// </summary>
		/// <value>The maximum number of days for which the data will be stored, or &#39;null&#39; to keep data until storage space runs out. If the former, it can be one of [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 14, 30, 60, 90] days</value>
		[DataMember(Name = "maxRetentionDays")]
		public int? MaxRetentionDays { get; set; }

		/// <summary>
		/// Gets or Sets VideoSettings
		/// </summary>
		[DataMember(Name = "videoSettings")]
		public VideoSettings VideoSettings { get; set; } = null!;
	}
}
