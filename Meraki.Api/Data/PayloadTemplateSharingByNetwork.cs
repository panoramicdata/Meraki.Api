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
	[ApiKey]
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "adminsCanModify")]
	public bool? AdminsCanModify { get; set; }

}
