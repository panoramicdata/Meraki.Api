using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// MoveNetworkSmDevices
	/// </summary>
	[DataContract]
	public class MoveNetworkSmDevices
	{
		/// <summary>
		/// The wifiMacs of the devices to be moved.
		/// </summary>
		/// <value>The wifiMacs of the devices to be moved.</value>
		[DataMember(Name = "wifiMacs")]
		public string WifiMacs { get; set; } = null!;

		/// <summary>
		/// The ids of the devices to be moved.
		/// </summary>
		/// <value>The ids of the devices to be moved.</value>
		[DataMember(Name = "ids")]
		public string Ids { get; set; } = null!;

		/// <summary>
		/// The serials of the devices to be moved.
		/// </summary>
		/// <value>The serials of the devices to be moved.</value>
		[DataMember(Name = "serials")]
		public string Serials { get; set; } = null!;

		/// <summary>
		/// The scope (one of all, none, withAny, withAll, withoutAny, or withoutAll) and a set of tags of the devices to be moved.
		/// </summary>
		/// <value>The scope (one of all, none, withAny, withAll, withoutAny, or withoutAll) and a set of tags of the devices to be moved.</value>
		[DataMember(Name = "scope")]
		public string Scope { get; set; } = null!;

		/// <summary>
		/// The new network to which the devices will be moved.
		/// </summary>
		/// <value>The new network to which the devices will be moved.</value>
		[DataMember(Name = "newNetwork")]
		public string NewNetwork { get; set; } = null!;
	}
}
