using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkBluetoothSettings
	/// </summary>
	[DataContract]
	public class NetworkBluetoothSettings
	{
		/// <summary>
		/// Whether APs will scan for Bluetooth enabled clients. (true, false)
		/// </summary>
		/// <value>Whether APs will scan for Bluetooth enabled clients. (true, false)</value>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "scanningEnabled")]
		public bool ScanningEnabled { get; set; }

		/// <summary>
		/// Whether APs will advertise beacons. (true, false)
		/// </summary>
		/// <value>Whether APs will advertise beacons. (true, false)</value>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "advertisingEnabled")]
		public bool AdvertisingEnabled { get; set; }

		/// <summary>
		/// The UUID to be used in the beacon identifier.
		/// </summary>
		/// <value>The UUID to be used in the beacon identifier.</value>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "uuid")]
		public string Uuid { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets MajorMinorAssignmentMode
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "majorMinorAssignmentMode")]
		public MajorMinorAssignmentMode MajorMinorAssignmentMode { get; set; }

		/// <summary>
		/// The major number to be used in the beacon identifier. Only valid in &#39;Non-unique&#39; mode.
		/// </summary>
		/// <value>The major number to be used in the beacon identifier. Only valid in &#39;Non-unique&#39; mode.</value>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "major")]
		public int? Major { get; set; }

		/// <summary>
		/// The minor number to be used in the beacon identifier. Only valid in &#39;Non-unique&#39; mode.
		/// </summary>
		/// <value>The minor number to be used in the beacon identifier. Only valid in &#39;Non-unique&#39; mode.</value>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "minor")]
		public int? Minor { get; set; }
	}
}
