namespace Meraki.Api.Data;

/// <summary>
/// Object Identifier Field
/// </summary>
[DataContract]
public class OrganizationsNacSessionDetailsAuthenticationEndpointCertificateExtensionField
{
	/// <summary>
	/// Object Identifier Field Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Object Identifier Field Value
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "value")]
	public string Value { get; set; } = string.Empty;
}