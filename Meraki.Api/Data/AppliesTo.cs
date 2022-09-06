namespace Meraki.Api.Data;

/// <summary>
/// Which kinds of admins this policy applies to. Can be one of 'All organization admins', 'All enterprise admins', 'All network admins', 'All admins of networks...', 'All admins of networks tagged...', 'Specific admins...', 'All admins' or 'All SAML admins'.
/// </summary>
/// <value>Which kinds of admins this policy applies to. Can be one of 'All organization admins', 'All enterprise admins', 'All network admins', 'All admins of networks...', 'All admins of networks tagged...', 'Specific admins...', 'All admins' or 'All SAML admins'.</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum AppliesTo
{
	/// <summary>
	/// All organization admins
	/// </summary>
	[EnumMember(Value = "All organization admins")]
	Allorganizationadmins,

	/// <summary>
	/// All enterprise admins
	/// </summary>
	[EnumMember(Value = "All enterprise admins")]
	Allenterpriseadmins,

	/// <summary>
	/// All network admins
	/// </summary>
	[EnumMember(Value = "All network admins")]
	Allnetworkadmins,

	/// <summary>
	/// All admins of networks...
	/// </summary>
	[EnumMember(Value = "All admins of networks...")]
	Alladminsofnetworks,

	/// <summary>
	/// All admins of networks tagged...
	/// </summary>
	[EnumMember(Value = "All admins of networks tagged...")]
	Alladminsofnetworkstagged,

	/// <summary>
	/// Specific admins...
	/// </summary>
	[EnumMember(Value = "Specific admins...")]
	Specificadmins,

	/// <summary>
	/// All admins
	/// </summary>
	[EnumMember(Value = "All admins")]
	Alladmins,

	/// <summary>
	/// All SAML admins
	/// </summary>
	[EnumMember(Value = "All SAML admins")]
	AllSAMLadmins
}
