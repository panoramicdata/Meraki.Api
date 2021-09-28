using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateNetworkHttpServer
	/// </summary>
	[DataContract]
	public class HttpServerCreationRequest
	{
		/// <summary>
		/// A name for easy reference to the HTTP server
		/// </summary>
		/// <value>A name for easy reference to the HTTP server</value>
		[DataMember(Name = "name")]
		public string Name { get; set; } = null!;

		/// <summary>
		/// The URL of the HTTP server
		/// </summary>
		/// <value>The URL of the HTTP server</value>
		[DataMember(Name = "url")]
		public string Url { get; set; } = null!;

		/// <summary>
		/// A shared secret that will be included in POSTs sent to the HTTP server. This secret can be used to verify that the request was sent by Meraki.
		/// </summary>
		/// <value>A shared secret that will be included in POSTs sent to the HTTP server. This secret can be used to verify that the request was sent by Meraki.</value>
		[DataMember(Name = "sharedSecret")]
		public string SharedSecret { get; set; } = null!;
	}
}
