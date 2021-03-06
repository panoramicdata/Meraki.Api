using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// WipeNetworkSmDevice
	/// </summary>
	[DataContract]
	public partial class WipeNetworkSmDevice
	{
		/// <summary>
		/// The wifiMac of the device to be wiped.
		/// </summary>
		/// <value>The wifiMac of the device to be wiped.</value>
		[DataMember(Name = "wifiMac", EmitDefaultValue = false)]
		public string WifiMac { get; set; } = null!;

		/// <summary>
		/// The id of the device to be wiped.
		/// </summary>
		/// <value>The id of the device to be wiped.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; } = null!;

		/// <summary>
		/// The serial of the device to be wiped.
		/// </summary>
		/// <value>The serial of the device to be wiped.</value>
		[DataMember(Name = "serial", EmitDefaultValue = false)]
		public string Serial { get; set; } = null!;

		/// <summary>
		/// The pin number (a six digit value) for wiping a macOS device. Required only for macOS devices.
		/// </summary>
		/// <value>The pin number (a six digit value) for wiping a macOS device. Required only for macOS devices.</value>
		[DataMember(Name = "pin", EmitDefaultValue = false)]
		public int? Pin { get; set; }
	}
}
