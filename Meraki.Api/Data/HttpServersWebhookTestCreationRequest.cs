using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateNetworkHttpServersWebhookTest
	/// </summary>
	[DataContract]
	public class HttpServersWebhookTestCreationRequest
	{
		/// <summary>
		/// The URL where the test webhook will be sent
		/// </summary>
		/// <value>The URL where the test webhook will be sent</value>
		[DataMember(Name = "url")]
		public string Url { get; set; } = null!;
	}
}
