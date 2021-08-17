using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Client
	/// </summary>
	[DataContract]
	public class DeviceClient
	{
		/// <summary>
		/// Usage
		/// </summary>
		[DataMember(Name = "usage")]
		public Usage Usage { get; set; } = new();

		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;

		/// <summary>
		/// Description
		/// </summary>
		[DataMember(Name = "description")]
		public string Description { get; set; } = string.Empty;

		/// <summary>
		/// Mac
		/// </summary>
		[DataMember(Name = "mac")]
		public string Mac { get; set; } = string.Empty;

		/// <summary>
		/// Ip
		/// </summary>
		[DataMember(Name = "ip")]
		public string Ip { get; set; } = string.Empty;

		/// <summary>
		/// User
		/// </summary>
		[DataMember(Name = "user")]
		public string User { get; set; } = string.Empty;

		/// <summary>
		/// Vlan
		/// </summary>
		[DataMember(Name = "vlan")]
		public int Vlan { get; set; }

		/// <summary>
		/// Mdns name
		/// </summary>
		[DataMember(Name = "mdnsName")]
		public string MdnsName { get; set; } = string.Empty;

		/// <summary>
		/// Dhcp host name
		/// </summary>
		[DataMember(Name = "dhcpHostname")]
		public string DhcpHostname { get; set; } = string.Empty;
	}
}
