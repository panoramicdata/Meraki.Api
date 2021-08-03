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
		public string Host { get; set; } = null!;

		/// <summary>
		/// The port
		/// </summary>
		[DataMember(Name = "port")]
		public int Port { get; set; }

		/// <summary>
		/// Secret
		/// </summary>
		[DataMember(Name = "secret")]
		public string Secret { get; set; } = string.Empty;
	}
}