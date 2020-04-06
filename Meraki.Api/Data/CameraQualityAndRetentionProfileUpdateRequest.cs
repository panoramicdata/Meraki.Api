using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkCameraQualityRetentionProfile
	/// </summary>
	[DataContract]
	public partial class CameraQualityAndRetentionProfileUpdateRequest
	{
		/// <summary>
		/// The name of the new profile. Must be unique.
		/// </summary>
		/// <value>The name of the new profile. Must be unique.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string? Name { get; set; }

		/// <summary>
		/// Deletes footage older than 3 days in which no motion was detected. Can be either true or false. Defaults to false.
		/// </summary>
		/// <value>Deletes footage older than 3 days in which no motion was detected. Can be either true or false. Defaults to false.</value>
		[DataMember(Name = "motionBasedRetentionEnabled", EmitDefaultValue = false)]
		public bool? MotionBasedRetentionEnabled { get; set; }

		/// <summary>
		/// Disable features that require additional bandwidth such as Motion Recap. Can be either true or false. Defaults to false.
		/// </summary>
		/// <value>Disable features that require additional bandwidth such as Motion Recap. Can be either true or false. Defaults to false.</value>
		[DataMember(Name = "restrictedBandwidthModeEnabled", EmitDefaultValue = false)]
		public bool? RestrictedBandwidthModeEnabled { get; set; }

		/// <summary>
		/// Whether or not to record audio. Can be either true or false. Defaults to false.
		/// </summary>
		/// <value>Whether or not to record audio. Can be either true or false. Defaults to false.</value>
		[DataMember(Name = "audioRecordingEnabled", EmitDefaultValue = false)]
		public bool? AudioRecordingEnabled { get; set; }

		/// <summary>
		/// Create redundant video backup using Cloud Archive. Can be either true or false. Defaults to false.
		/// </summary>
		/// <value>Create redundant video backup using Cloud Archive. Can be either true or false. Defaults to false.</value>
		[DataMember(Name = "cloudArchiveEnabled", EmitDefaultValue = false)]
		public bool? CloudArchiveEnabled { get; set; }

		/// <summary>
		/// The version of the motion detector that will be used by the camera. Only applies to Gen 2 cameras. Defaults to v2.
		/// </summary>
		/// <value>The version of the motion detector that will be used by the camera. Only applies to Gen 2 cameras. Defaults to v2.</value>
		[DataMember(Name = "motionDetectorVersion", EmitDefaultValue = false)]
		public int? MotionDetectorVersion { get; set; }

		/// <summary>
		/// Schedule for which this camera will record video, or &#39;null&#39; to always record.
		/// </summary>
		/// <value>Schedule for which this camera will record video, or &#39;null&#39; to always record.</value>
		[DataMember(Name = "scheduleId", EmitDefaultValue = false)]
		public string? ScheduleId { get; set; }

		/// <summary>
		/// The maximum number of days for which the data will be stored, or &#39;null&#39; to keep data until storage space runs out. If the former, it can be one of [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 14, 30, 60, 90] days
		/// </summary>
		/// <value>The maximum number of days for which the data will be stored, or &#39;null&#39; to keep data until storage space runs out. If the former, it can be one of [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 14, 30, 60, 90] days</value>
		[DataMember(Name = "maxRetentionDays", EmitDefaultValue = false)]
		public int? MaxRetentionDays { get; set; }
		/// <summary>
		/// Gets or Sets VideoSettings
		/// </summary>
		[DataMember(Name = "videoSettings", EmitDefaultValue = false)]
		public VideoSettings? VideoSettings { get; set; }
	}
}
