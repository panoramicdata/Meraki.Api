using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A bluetooth client
	/// </summary>
	[DataContract]
	public class BluetoothClient : NamedIdentifiedItem
	{
		/// <summary>
		/// The MAC address
		/// </summary>
		[DataMember(Name = "mac")]
		public string Mac { get; set; } = default!;

		/// <summary>
		/// The network Id
		/// </summary>
		[DataMember(Name = "networkId")]
		public string NetworkId { get; set; } = default!;

		/// <summary>
		/// The device name
		/// </summary>
		[DataMember(Name = "deviceName")]
		public string DeviceName { get; set; } = default!;

		/// <summary>
		/// The manufacturer
		/// </summary>
		[DataMember(Name = "manufacturer")]
		public string Manufacturer { get; set; } = default!;

		/// <summary>
		/// When it was last seen in seconds since the Epoch
		/// </summary>
		[DataMember(Name = "lastSeen")]
		public int LastSeenTimestampSeeconds { get; set; }

		/// <summary>
		/// The seen-by device MAC address
		/// </summary>
		[DataMember(Name = "seenByDeviceMac")]
		public string SeenByDeviceMac { get; set; } = default!;

		/// <summary>
		/// Whether inSight alert
		/// </summary>
		[DataMember(Name = "inSightAlert")]
		public bool InSightAlert { get; set; }

		/// <summary>
		/// Whether out of sight alert
		/// </summary>
		[DataMember(Name = "outOfSightAlert")]
		public bool OutOfSightAlert { get; set; }

		/// <summary>
		/// The list of associated tags
		/// </summary>
		[DataMember(Name = "tags")]
		public List<string> Tags { get; set; } = new List<string>();
	}
}