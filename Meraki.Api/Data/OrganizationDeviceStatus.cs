using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// An organization device status
	/// </summary>
	[DataContract]
	public class OrganizationDeviceStatus : NamedItem
	{
		/// <summary>
		/// serial
		/// </summary>
		[DataMember(Name = "serial")]
		public string Serial { get; set; } = string.Empty;

		/// <summary>
		/// mac
		/// </summary>
		[DataMember(Name = "mac")]
		public string Mac { get; set; } = string.Empty;

		/// <summary>
		/// publicIp
		/// </summary>
		[DataMember(Name = "publicIp")]
		public string PublicIp { get; set; } = string.Empty;

		/// <summary>
		/// networkId
		/// </summary>
		[DataMember(Name = "networkId")]
		public string NetworkId { get; set; } = string.Empty;

		/// <summary>
		/// status
		/// </summary>
		[DataMember(Name = "status")]
		public string Status { get; set; } = string.Empty;

		/// <summary>
		/// lastReportedAt
		/// </summary>
		[DataMember(Name = "lastReportedAt")]
		public string LastReportedAt { get; set; } = string.Empty;

		/// <summary>
		/// lanIp
		/// </summary>
		[DataMember(Name = "lanIp")]
		public string LanIp { get; set; } = string.Empty;

		/// <summary>
		/// usingCellularFailover
		/// </summary>
		[DataMember(Name = "usingCellularFailover")]
		public bool? UsingCellularFailover { get; set; }

		/// <summary>
		/// wan1Ip
		/// </summary>
		[DataMember(Name = "wan1Ip")]
		public string Wan1Ip { get; set; } = string.Empty;

		/// <summary>
		/// wan2Ip
		/// </summary>
		[DataMember(Name = "wan2Ip")]
		public string Wan2Ip { get; set; } = string.Empty;
	}
}