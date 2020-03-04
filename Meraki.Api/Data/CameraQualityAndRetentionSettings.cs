using System.Runtime.Serialization;

namespace Meraki.Api.Data
{

	/// <summary>
	/// Camera quality and retention settings
	/// </summary>
	[DataContract]
	public class CameraQualityAndRetentionSettings
	{
		/// <summary>
		/// Whether motion-based retention is enabled
		/// </summary>
		[DataMember(Name = "motionBasedRetentionEnabled")]
		public bool MotionBasedRetentionEnabled { get; set; }

		/// <summary>
		/// Whether audio recording is enabled
		/// </summary>
		[DataMember(Name = "audioRecordingEnabled")]
		public bool AudioRecordingEnabled { get; set; }

		/// <summary>
		/// Whether restricted bandwidth mode is enabled
		/// </summary>
		[DataMember(Name = "restrictedBandwidthModeEnabled")]
		public bool RestrictedBandwidthModeEnabled { get; set; }

		/// <summary>
		/// The profile id
		/// </summary>
		[DataMember(Name = "motionBasedRetentionEnabled")]
		public string ProfileId { get; set; } = string.Empty;

		/// <summary>
		/// The quality level
		/// </summary>
		[DataMember(Name = "quality")]
		public string Quality { get; set; } = string.Empty;

		/// <summary>
		/// The resolution
		/// </summary>
		[DataMember(Name = "resolution")]
		public int Resolution { get; set; }
	}
}