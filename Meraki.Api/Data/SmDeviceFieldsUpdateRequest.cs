using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSmDeviceFields
	/// </summary>
	[DataContract]
	public partial class SmDeviceFieldsUpdateRequest
	{
		/// <summary>
		/// The wifiMac of the device to be modified.
		/// </summary>
		/// <value>The wifiMac of the device to be modified.</value>
		[DataMember(Name = "wifiMac", EmitDefaultValue = false)]
		public string WifiMac { get; set; }
		/// <summary>
		/// The id of the device to be modified.
		/// </summary>
		/// <value>The id of the device to be modified.</value>
		[DataMember(Name = "id", EmitDefaultValue = false)]
		public string Id { get; set; }
		/// <summary>
		/// The serial of the device to be modified.
		/// </summary>
		/// <value>The serial of the device to be modified.</value>
		[DataMember(Name = "serial", EmitDefaultValue = false)]
		public string Serial { get; set; }
		/// <summary>
		/// Gets or Sets DeviceFields
		/// </summary>
		[DataMember(Name = "deviceFields", EmitDefaultValue = false)]
		public DeviceFields DeviceFields { get; set; }
	}
}
