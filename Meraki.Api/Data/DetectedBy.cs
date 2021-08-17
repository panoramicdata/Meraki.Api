using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Detected by
	/// </summary>
	[DataContract]
	public class DetectedBy
	{
		/// <summary>
		/// Device
		/// </summary>
		[DataMember(Name = "device")]
		public string Device { get; set; } = string.Empty;

		/// <summary>
		/// RSSI
		/// </summary>
		[DataMember(Name = "rssi")]
		public int Rssi { get; set; }
	}
}
