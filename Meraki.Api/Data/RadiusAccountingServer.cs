using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// RadiusAccountingServer
	/// </summary>
	[DataContract]
	public class RadiusAccountingServer
	{
		/// <summary>
		/// IP address to which the APs will send RADIUS accounting messages
		/// </summary>
		/// <value>IP address to which the APs will send RADIUS accounting messages</value>
		[DataMember(Name = "host")]
		public string Host { get; set; } = null!;

		/// <summary>
		/// Port on the RADIUS server that is listening for accounting messages
		/// </summary>
		/// <value>Port on the RADIUS server that is listening for accounting messages</value>
		[DataMember(Name = "port")]
		public int? Port { get; set; }

		/// <summary>
		/// Shared key used to authenticate messages between the APs and RADIUS server
		/// </summary>
		/// <value>Shared key used to authenticate messages between the APs and RADIUS server</value>
		[DataMember(Name = "secret")]
		public string Secret { get; set; } = null!;

		/// <summary>
		/// Radsec enabled
		/// </summary>
		[DataMember(Name = "radsecEnabled")]
		public bool? RadsecEnabled { get; set; }
	}
}
