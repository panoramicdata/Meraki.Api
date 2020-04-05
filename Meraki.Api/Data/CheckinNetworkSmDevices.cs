using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CheckinNetworkSmDevices
	/// </summary>
	[DataContract]
	public partial class CheckinNetworkSmDevices
	{
		/// <summary>
		/// The wifiMacs of the devices to be checked-in.
		/// </summary>
		/// <value>The wifiMacs of the devices to be checked-in.</value>
		[DataMember(Name = "wifiMacs", EmitDefaultValue = false)]
		public string WifiMacs { get; set; }
		/// <summary>
		/// The ids of the devices to be checked-in.
		/// </summary>
		/// <value>The ids of the devices to be checked-in.</value>
		[DataMember(Name = "ids", EmitDefaultValue = false)]
		public string Ids { get; set; }
		/// <summary>
		/// The serials of the devices to be checked-in.
		/// </summary>
		/// <value>The serials of the devices to be checked-in.</value>
		[DataMember(Name = "serials", EmitDefaultValue = false)]
		public string Serials { get; set; }
		/// <summary>
		/// The scope (one of all, none, withAny, withAll, withoutAny, or withoutAll) and a set of tags of the devices to be checked-in.
		/// </summary>
		/// <value>The scope (one of all, none, withAny, withAll, withoutAny, or withoutAll) and a set of tags of the devices to be checked-in.</value>
		[DataMember(Name = "scope", EmitDefaultValue = false)]
		public string Scope { get; set; }
	}
}
