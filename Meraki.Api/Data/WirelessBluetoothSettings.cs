using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateDeviceWirelessBluetoothSettings
	/// </summary>
	[DataContract]
	public class WirelessBluetoothSettings
	{
		/// <summary>
		/// Desired UUID of the beacon. If the value is set to null it will reset to Dashboard&#39;s automatically generated value.
		/// </summary>
		/// <value>Desired UUID of the beacon. If the value is set to null it will reset to Dashboard&#39;s automatically generated value.</value>
		[DataMember(Name = "uuid")]
		public string Uuid { get; set; } = string.Empty;
		/// <summary>
		/// Desired major value of the beacon. If the value is set to null it will reset to Dashboard&#39;s automatically generated value.
		/// </summary>
		/// <value>Desired major value of the beacon. If the value is set to null it will reset to Dashboard&#39;s automatically generated value.</value>
		[DataMember(Name = "major")]
		public int? Major { get; set; }
		/// <summary>
		/// Desired minor value of the beacon. If the value is set to null it will reset to Dashboard&#39;s automatically generated value.
		/// </summary>
		/// <value>Desired minor value of the beacon. If the value is set to null it will reset to Dashboard&#39;s automatically generated value.</value>
		[DataMember(Name = "minor")]
		public int? Minor { get; set; }
	}
}
