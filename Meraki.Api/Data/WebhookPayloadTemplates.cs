using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

/// <summary>
/// Webhook payload templates
/// </summary>
[DataContract]
public class WebhookPayloadTemplates
{
	/// <summary>
	/// Template id
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "payloadTemplateId")]
	public string PayloadTemplateId { get; set; } = string.Empty;

	/// <summary>
	/// Type
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Body
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "body")]
	public string Body { get; set; } = string.Empty;

	/// <summary>
	/// Headers
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "headers")]
	public PayloadTemplateHeaders Headers { get; set; } = new();
}
