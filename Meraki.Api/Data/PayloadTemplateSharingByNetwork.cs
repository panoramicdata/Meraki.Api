namespace Meraki.Api.Data;

/// <summary>
/// Information on network access to the template
/// </summary>
[DataContract]
public class PayloadTemplateSharingByNetwork
{
	/// <summary>
	/// Indicates whether network admins may modify this template
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "adminsCanModify")]
	public bool? AdminsCanModify { get; set; }
	/// <summary>
	/// The IDs of the networks the template is shared with - Undocumented added 2026-09-07
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ids")]
	public List<string>? Ids { get; set; }
}
