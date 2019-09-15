using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// RadiusServer
	/// </summary>
	[DataContract]
	public class RadiusServer
	{
		/// <summary>
		/// The host
		/// </summary>
		[DataMember(Name = "host")]
		public string Host { get; set; } = string.Empty;

		/// <summary>
		/// The port
		/// </summary>
		[DataMember(Name = "port")]
		public int Port { get; set; }
	}
}