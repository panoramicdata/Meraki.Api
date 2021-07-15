using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkHttpServer
	/// </summary>
	[DataContract]
	public partial class HttpServerUpdateRequest
	{
		/// <summary>
		/// A name for easy reference to the HTTP server
		/// </summary>
		/// <value>A name for easy reference to the HTTP server</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; } = string.Empty;
		/// <summary>
		/// The URL of the HTTP server
		/// </summary>
		/// <value>The URL of the HTTP server</value>
		[DataMember(Name = "url", EmitDefaultValue = false)]
		public string Url { get; set; } = string.Empty;
		/// <summary>
		/// A shared secret that will be included in POSTs sent to the HTTP server. This secret can be used to verify that the request was sent by Meraki.
		/// </summary>
		/// <value>A shared secret that will be included in POSTs sent to the HTTP server. This secret can be used to verify that the request was sent by Meraki.</value>
		[DataMember(Name = "sharedSecret", EmitDefaultValue = false)]
		public string SharedSecret { get; set; } = string.Empty;
	}
}
