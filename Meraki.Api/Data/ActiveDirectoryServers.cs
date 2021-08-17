using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The Active Directory servers to be used for authentication.
	/// </summary>
	[DataContract]
	public partial class ActiveDirectoryServers
	{
		/// <summary>
		/// (Optional) UDP port the Active Directory server listens on. By default, uses port 3268.
		/// </summary>
		[DataMember(Name = "port")]
		public int? Port { get; set; }

		/// <summary>
		/// IP address of your Active Directory server.
		/// </summary>
		[DataMember(Name = "host")]
		public string Host { get; set; } = string.Empty;
	}
}
