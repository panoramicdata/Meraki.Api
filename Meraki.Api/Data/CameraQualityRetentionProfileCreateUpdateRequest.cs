using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateNetworkCameraQualityRetentionProfile
	/// </summary>
	[DataContract]
	public class CameraQualityRetentionProfileCreateUpdateRequest
	{
		/// <summary>
		/// The name of the new profile. Must be unique. This parameter is required.
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "name")]
		public string Name { get; set; } = null!;

		/// <summary>
		/// Deletes footage older than 3 days in which no motion was detected. Can be either true or false. Defaults to false.
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "motionBasedRetentionEnabled")]
		public bool? MotionBasedRetentionEnabled { get; set; }

		/// <summary>
		/// Disable features that require additional bandwidth such as Motion Recap. Can be either true or false. Defaults to false.
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "restrictedBandwidthModeEnabled")]
		public bool? RestrictedBandwidthModeEnabled { get; set; }

		/// <summary>
		/// Whether or not to record audio. Can be either true or false. Defaults to false.
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "audioRecordingEnabled")]
		public bool? AudioRecordingEnabled { get; set; }

		/// <summary>
		/// Create redundant video backup using Cloud Archive. Can be either true or false. Defaults to false.
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "cloudArchiveEnabled")]
		public bool? CloudArchiveEnabled { get; set; }

		/// <summary>
		/// The version of the motion detector that will be used by the camera. Only applies to Gen 2 cameras. Defaults to v2.
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "motionDetectorVersion")]
		public int? MotionDetectorVersion { get; set; }

		/// <summary>
		/// Schedule for which this camera will record video, or &#39;null&#39; to always record.
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "scheduleId")]
		public string ScheduleId { get; set; } = null!;

		/// <summary>
		/// The maximum number of days for which the data will be stored, or &#39;null&#39; to keep data until storage space runs out. If the former, it can be one of [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 14, 30, 60, 90] days
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "maxRetentionDays")]
		public int? MaxRetentionDays { get; set; }

		/// <summary>
		/// Gets or Sets VideoSettings
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "videoSettings")]
		public VideoSettings VideoSettings { get; set; } = null!;
	}
}
