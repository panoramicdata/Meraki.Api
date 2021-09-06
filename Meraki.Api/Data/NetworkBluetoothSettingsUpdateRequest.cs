using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkBluetoothSettings
	/// </summary>
	[DataContract]
	public class NetworkBluetoothSettingsUpdateRequest
	{
		/// <summary>
		/// Whether APs will scan for Bluetooth enabled clients. (true, false)
		/// </summary>
		/// <value>Whether APs will scan for Bluetooth enabled clients. (true, false)</value>
		[DataMember(Name = "scanningEnabled", EmitDefaultValue = false)]
		public bool? ScanningEnabled { get; set; }
		/// <summary>
		/// Whether APs will advertise beacons. (true, false)
		/// </summary>
		/// <value>Whether APs will advertise beacons. (true, false)</value>
		[DataMember(Name = "advertisingEnabled", EmitDefaultValue = false)]
		public bool? AdvertisingEnabled { get; set; }
		/// <summary>
		/// The UUID to be used in the beacon identifier.
		/// </summary>
		/// <value>The UUID to be used in the beacon identifier.</value>
		[DataMember(Name = "uuid", EmitDefaultValue = false)]
		public string Uuid { get; set; } = string.Empty;
		/// <summary>
		/// Gets or Sets MajorMinorAssignmentMode
		/// </summary>
		[DataMember(Name = "majorMinorAssignmentMode", EmitDefaultValue = false)]
		public MajorMinorAssignmentMode MajorMinorAssignmentMode { get; set; }
		/// <summary>
		/// The major number to be used in the beacon identifier. Only valid in &#39;Non-unique&#39; mode.
		/// </summary>
		/// <value>The major number to be used in the beacon identifier. Only valid in &#39;Non-unique&#39; mode.</value>
		[DataMember(Name = "major", EmitDefaultValue = false)]
		public int? Major { get; set; }
		/// <summary>
		/// The minor number to be used in the beacon identifier. Only valid in &#39;Non-unique&#39; mode.
		/// </summary>
		/// <value>The minor number to be used in the beacon identifier. Only valid in &#39;Non-unique&#39; mode.</value>
		[DataMember(Name = "minor", EmitDefaultValue = false)]
		public int? Minor { get; set; }
	}
}
