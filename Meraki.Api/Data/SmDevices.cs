using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// SM Devices
	/// </summary>
	[DataContract]
	public class SmDevices
	{
		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Tags
		/// </summary>
		[DataMember(Name = "tags")]
		public List<string> Tags { get; set; } = new();

		/// <summary>
		/// SSID
		/// </summary>
		[DataMember(Name = "ssid")]
		public string Ssid { get; set; } = string.Empty;

		/// <summary>
		/// Wifi mac
		/// </summary>
		[DataMember(Name = "wifiMac")]
		public string WifiMac { get; set; } = string.Empty;

		/// <summary>
		/// OS Name
		/// </summary>
		[DataMember(Name = "osName")]
		public string OsName { get; set; } = string.Empty;

		/// <summary>
		/// System model
		/// </summary>
		[DataMember(Name = "systemModel")]
		public string SystemModel { get; set; } = string.Empty;

		/// <summary>
		/// UUID
		/// </summary>
		[DataMember(Name = "uuid")]
		public string Uuid { get; set; } = string.Empty;

		/// <summary>
		/// Serial number
		/// </summary>
		[DataMember(Name = "serialNumber")]
		public string SerialNumber { get; set; } = string.Empty;

		/// <summary>
		/// Serial
		/// </summary>
		[DataMember(Name = "serial")]
		public string Serial { get; set; } = string.Empty;

		/// <summary>
		/// Ip
		/// </summary>
		[DataMember(Name = "ip")]
		public string Ip { get; set; } = string.Empty;

		/// <summary>
		/// Notes
		/// </summary>
		[DataMember(Name = "notes")]
		public string Notes { get; set; } = string.Empty;
	}
}
