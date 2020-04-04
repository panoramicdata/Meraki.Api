using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// GenerateNetworkCameraSnapshot
	/// </summary>
	[DataContract]
	public partial class CameraSnapshotRequest
	{
		/// <summary>
		/// [optional] The snapshot will be taken from this time on the camera. The timestamp is expected to be in ISO 8601 format. If no timestamp is specified, we will assume current time.
		/// </summary>
		/// <value>[optional] The snapshot will be taken from this time on the camera. The timestamp is expected to be in ISO 8601 format. If no timestamp is specified, we will assume current time.</value>
		[DataMember(Name = "timestamp", EmitDefaultValue = false)]
		public string? Timestamp { get; set; }

		/// <summary>
		/// [optional] If set to \&quot;true\&quot; the snapshot will be taken at full sensor resolution. This will error if used with timestamp.
		/// </summary>
		/// <value>[optional] If set to \&quot;true\&quot; the snapshot will be taken at full sensor resolution. This will error if used with timestamp.</value>
		[DataMember(Name = "fullframe", EmitDefaultValue = false)]
		public bool? Fullframe { get; set; }
	}
}
