using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateNetworkHttpServersWebhookTest
	/// </summary>
	[DataContract]
	public partial class HttpServersWebhookTestCreationRequest
	{
		/// <summary>
		/// The URL where the test webhook will be sent
		/// </summary>
		/// <value>The URL where the test webhook will be sent</value>
		[DataMember(Name = "url", EmitDefaultValue = false)]
		public string Url { get; set; } = null!;
	}
}
