using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

[DataContract]
public class OrganizationAlertRecipients
{
	/// <summary>
	/// Emails
	/// </summary>
	[DataMember(Name = "emails")]
	public List<string> Emails { get; set; } = new();

	/// <summary>
	/// HTTP server ids
	/// </summary>
	[DataMember(Name = "httpServerIds")]
	public List<string> HttpServerIds { get; set; } = new();
}
