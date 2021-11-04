using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The Webhook PayloadTemplate
	/// </summary>
	[DataContract]
	public class PayloadTemplate : NamedItem
	{
		/// <summary>
		/// The Id of the PayloadTemplate
		/// </summary>
		[ApiKey]
		[ApiAccess(ApiAccess.CreateUpdate)]
		[DataMember(Name = "payloadTemplateId")]
		public string PayloadTemplateId { get; set; } = string.Empty;
	}
}