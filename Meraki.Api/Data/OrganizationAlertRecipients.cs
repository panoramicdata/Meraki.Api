using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

[DataContract]
public class OrganizationAlertRecipients
{
	/// <summary>
	/// A list of emails that will receive information about the alert
	/// </summary>
	[DataMember(Name = "emails")]
	public List<string> Emails { get; set; } = new();

	/// <summary>
	/// A list base64 encoded urls of webhook endpoints that will receive information about the alert
	/// </summary>
	[DataMember(Name = "httpServerIds")]
	public List<string> HttpServerIds { get; set; } = new();
}
