using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSmDevicesTags
	/// </summary>
	[DataContract]
	public partial class SmDevicesTagsUpdateRequest
	{
		/// <summary>
		/// The wifiMacs of the devices to be modified.
		/// </summary>
		/// <value>The wifiMacs of the devices to be modified.</value>
		[DataMember(Name = "wifiMacs", EmitDefaultValue = false)]
		public string WifiMacs { get; set; } = string.Empty;

		/// <summary>
		/// The ids of the devices to be modified.
		/// </summary>
		/// <value>The ids of the devices to be modified.</value>
		[DataMember(Name = "ids", EmitDefaultValue = false)]
		public string Ids { get; set; } = string.Empty;

		/// <summary>
		/// The serials of the devices to be modified.
		/// </summary>
		/// <value>The serials of the devices to be modified.</value>
		[DataMember(Name = "serials", EmitDefaultValue = false)]
		public string Serials { get; set; } = string.Empty;

		/// <summary>
		/// The scope (one of all, none, withAny, withAll, withoutAny, or withoutAll) and a set of tags of the devices to be modified.
		/// </summary>
		/// <value>The scope (one of all, none, withAny, withAll, withoutAny, or withoutAll) and a set of tags of the devices to be modified.</value>
		[DataMember(Name = "scope", EmitDefaultValue = false)]
		public string Scope { get; set; } = string.Empty;

		/// <summary>
		/// The tags to be added, deleted, or updated.
		/// </summary>
		/// <value>The tags to be added, deleted, or updated.</value>
		[DataMember(Name = "tags", EmitDefaultValue = false)]
		public List<string> Tags { get; set; } = new();

		/// <summary>
		/// One of add, delete, or update. Only devices that have been modified will be returned.
		/// </summary>
		/// <value>One of add, delete, or update. Only devices that have been modified will be returned.</value>
		[DataMember(Name = "updateAction", EmitDefaultValue = false)]
		public string UpdateAction { get; set; } = string.Empty;
	}
}
