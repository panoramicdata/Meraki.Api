using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Webhook test
	/// </summary>
	[DataContract]
	public class WebhookTest
	{
		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;

		/// <summary>
		/// Url
		/// </summary>
		[DataMember(Name = "url")]
		public string Url { get; set; } = string.Empty;

		/// <summary>
		/// Status
		/// </summary>
		[DataMember(Name = "status")]
		public string Status { get; set; } = string.Empty;
	}
}
