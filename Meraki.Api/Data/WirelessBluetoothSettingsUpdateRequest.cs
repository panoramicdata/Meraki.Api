using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateDeviceWirelessBluetoothSettings
	/// </summary>
	[DataContract]
	public partial class WirelessBluetoothSettingsUpdateRequest
	{
		/// <summary>
		/// Desired UUID of the beacon. If the value is set to null it will reset to Dashboard&#39;s automatically generated value.
		/// </summary>
		/// <value>Desired UUID of the beacon. If the value is set to null it will reset to Dashboard&#39;s automatically generated value.</value>
		[DataMember(Name = "uuid", EmitDefaultValue = false)]
		public string Uuid { get; set; }
		/// <summary>
		/// Desired major value of the beacon. If the value is set to null it will reset to Dashboard&#39;s automatically generated value.
		/// </summary>
		/// <value>Desired major value of the beacon. If the value is set to null it will reset to Dashboard&#39;s automatically generated value.</value>
		[DataMember(Name = "major", EmitDefaultValue = false)]
		public int? Major { get; set; }
		/// <summary>
		/// Desired minor value of the beacon. If the value is set to null it will reset to Dashboard&#39;s automatically generated value.
		/// </summary>
		/// <value>Desired minor value of the beacon. If the value is set to null it will reset to Dashboard&#39;s automatically generated value.</value>
		[DataMember(Name = "minor", EmitDefaultValue = false)]
		public int? Minor { get; set; }
	}
}
