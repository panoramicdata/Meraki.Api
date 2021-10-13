using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Pii Key
	/// </summary>
	[DataContract]
	public class PiiKey
	{
		/// <summary>
		/// The MAC of a network client device or a Systems Manager device
		/// </summary>
		[ApiAccess(ApiAccess.Read)]
		[DataMember(Name = "macs")]
		public List<string> Macs { get; set; } = new();

		/// <summary>
		/// The email of a network user account or a Systems Manager device
		/// </summary>
		[ApiAccess(ApiAccess.Read)]
		[DataMember(Name = "emails")]
		public List<string> Emails { get; set; } = new();

		/// <summary>
		/// The username of a Systems Manager user
		/// </summary>
		[ApiAccess(ApiAccess.Read)]
		[DataMember(Name = "usernames")]
		public List<string> Usernames { get; set; } = new();

		/// <summary>
		/// The serial of a Systems Manager device
		/// </summary>
		[ApiAccess(ApiAccess.Read)]
		[DataMember(Name = "serials")]
		public List<string> Serials { get; set; } = new();

		/// <summary>
		/// The IMEI of a Systems Manager device
		/// </summary>
		[ApiAccess(ApiAccess.Read)]
		[DataMember(Name = "imeis")]
		public List<string> Imeis { get; set; } = new();

		/// <summary>
		/// The MAC of a Bluetooth client
		/// </summary>
		[ApiAccess(ApiAccess.Read)]
		[DataMember(Name = "bluetoothMacs")]
		public List<string> BluetoothMacs { get; set; } = new();
	}
}
