namespace Meraki.Api.Data;

/// <summary>
/// Settings for describing which kinds of admins this policy applies to.
/// </summary>
[DataContract]
public class AdminSettings
{
	/// <summary>
	/// Which kinds of admins this policy applies to. Can be one of 'All organization admins', 'All enterprise admins', 'All network admins', 'All admins of networks...', 'All admins of networks tagged...', 'Specific admins...', 'All admins' or 'All SAML admins'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "appliesTo")]
	public AppliesTo AppliesTo { get; set; }

	/// <summary>
	/// If 'appliesTo' is set to one of 'Specific admins...', 'All admins of networks...' or 'All admins of networks tagged...', then you must specify this 'values' property to provide the set of entities to apply the branding policy to. For 'Specific admins...', specify an array of admin IDs. For 'All admins of networks...', specify an array of network IDs and/or configuration template IDs. For 'All admins of networks tagged...', specify an array of tag names.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "values")]
	public List<string>? Values { get; set; }
}
