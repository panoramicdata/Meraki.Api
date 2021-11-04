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

		/// <summary>
		/// The Id of the Network the Webhook belongs to
		/// </summary>
		[ApiForeignKey(typeof(Network))]
		[ApiAccess(ApiAccess.Read)]
		[DataMember(Name = "networkId")]
		public string NetworkId { get; set; } = string.Empty;

		/// <summary>
		/// The Webhook PayloadTemplate
		/// </summary>
		[ApiAccess(ApiAccess.ReadWrite)]
		[DataMember(Name = "payloadTemplate")]
		public PayloadTemplate? PayloadTemplate { get; set; }
	}
}
