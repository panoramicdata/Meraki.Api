namespace Meraki.Api.Data;

/// <summary>
/// Information on which entities have access to the template
/// </summary>
[DataContract]
public class PayloadTemplateSharing
{
	/// <summary>
	/// Information on network access to the template
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "byNetwork")]
	public PayloadTemplateSharingByNetwork? ByNetwork { get; set; }

}
