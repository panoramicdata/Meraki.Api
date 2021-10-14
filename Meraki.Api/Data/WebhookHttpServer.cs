using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// HTTP servers
	/// </summary>
	[DataContract]
	public class WebhookHttpServer : NamedIdentifiedItem
	{
		/// <summary>
		/// The URL of the HTTP server
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "url")]
		public string Url { get; set; } = string.Empty;

		/// <summary>
		/// A shared secret that will be included in POSTs sent to the HTTP server. This secret can be used to verify that the request was sent by Meraki.
		/// </summary>
		[ApiAccess(ApiAccess.CreateUpdate)]
		[DataMember(Name = "sharedSecret")]
		public string SharedSecret { get; set; } = string.Empty;
	}
}
