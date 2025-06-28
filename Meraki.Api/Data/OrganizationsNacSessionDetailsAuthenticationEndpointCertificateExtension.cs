namespace Meraki.Api.Data;

/// <summary>
/// Endpoint Certificate Extension
/// </summary>
[DataContract]
public class OrganizationsNacSessionDetailsAuthenticationEndpointCertificateExtension
{
	/// <summary>
	/// Object Identifier Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Object Identifier
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "oid")]
	public string Oid { get; set; } = string.Empty;

	/// <summary>
	/// Object Identifier Fields
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "fields")]
	public List<OrganizationsNacSessionDetailsAuthenticationEndpointCertificateExtensionField> Fields { get; set; } = [];
}
