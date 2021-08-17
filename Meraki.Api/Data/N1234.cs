using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// N1234
	/// </summary>
	[DataContract]
	public class N1234
	{
		/// <summary>
		/// Macs
		/// </summary>
		[DataMember(Name = "macs")]
		public List<string> Macs { get; set; } = new();

		/// <summary>
		/// Emails
		/// </summary>
		[DataMember(Name = "emails")]
		public List<string> Emails { get; set; } = new();

		/// <summary>
		/// Usernames
		/// </summary>
		[DataMember(Name = "usernames")]
		public List<string> Usernames { get; set; } = new();

		/// <summary>
		/// Serials
		/// </summary>
		[DataMember(Name = "serials")]
		public List<string> Serials { get; set; } = new();

		/// <summary>
		/// IMeis
		/// </summary>
		[DataMember(Name = "imeis")]
		public List<string> Imeis { get; set; } = new();

		/// <summary>
		/// Bluetooth macs
		/// </summary>
		[DataMember(Name = "bluetoothMacs")]
		public List<string> BluetoothMacs { get; set; } = new();
	}
}
