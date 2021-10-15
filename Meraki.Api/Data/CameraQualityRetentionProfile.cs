using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Quality retention profile
	/// </summary>
	[DataContract]
	public class CameraQualityRetentionProfile
	{
		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;

		/// <summary>
		/// Network id
		/// </summary>
		[DataMember(Name = "networkId")]
		public string NetworkId { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Restricted bandwidth mode enabled
		/// </summary>
		[DataMember(Name = "restrictedBandwidthModeEnabled")]
		public bool RestrictedBandwidthModeEnabled { get; set; }

		/// <summary>
		/// Motion based retention enabled
		/// </summary>
		[DataMember(Name = "motionBasedRetentionEnabled")]
		public bool MotionBasedRetentionEnabled { get; set; }

		/// <summary>
		/// Audio recording enabled
		/// </summary>
		[DataMember(Name = "audioRecordingEnabled")]
		public bool AudioRecordingEnabled { get; set; }

		/// <summary>
		/// Cloud archive enabled
		/// </summary>
		[DataMember(Name = "cloudArchiveEnabled")]
		public bool CloudArchiveEnabled { get; set; }

		/// <summary>
		/// Max retention days
		/// </summary>
		[DataMember(Name = "maxRetentionDays")]
		public int MaxRetentionDays { get; set; }

		/// <summary>
		/// Motion detector version
		/// </summary>
		[DataMember(Name = "motionDetectorVersion")]
		public int MotionDetectorVersion { get; set; }

		/// <summary>
		/// Video settings
		/// </summary>
		[DataMember(Name = "videoSettings")]
		public VideoSettings VideoSettings { get; set; } = new();
	}
}
