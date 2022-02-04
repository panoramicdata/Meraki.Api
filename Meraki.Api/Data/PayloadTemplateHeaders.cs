using System;
using System.Collections.Generic;
using System.Text;

namespace Meraki.Api.Data;

/// <summary>
/// Headers
/// </summary>
[DataContract]

public class PayloadTemplateHeaders
{
	/// <summary>
	/// Content type
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "Content-Type")]
	public string ContentType { get; set; } = string.Empty;

	/// <summary>
	/// Accept
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "Accept")]
	public string Accept { get; set; } = string.Empty;

	/// <summary>
	/// Authorization
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "Authorization")]
	public string Authorization { get; set; } = string.Empty;
}
