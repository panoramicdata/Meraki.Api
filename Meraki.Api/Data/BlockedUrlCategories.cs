using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Settings for blacklisted URL categories
/// </summary>
[DataContract]
public class BlockedUrlCategories
{
	/// <summary>
	/// Gets or Sets Settings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "settings")]
	public UrlSetting Settings { get; set; }

	/// <summary>
	/// A list of URL categories to block
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "categories")]
	public List<string> Categories { get; set; } = new();
}
