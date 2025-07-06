namespace Meraki.Api.Data;

/// <summary>
/// Endpoint Certificate Public Key
/// </summary>
[DataContract]
public class OrganizationsNacSessionDetailsAuthenticationEndpointCertificatePublicKey
{
	/// <summary>
	/// Algorithm
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "algorithm")]
	public string Algorithm { get; set; } = string.Empty;

	/// <summary>
	/// Public Key
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "body")]
	public string Body { get; set; } = string.Empty;

	/// <summary>
	/// Exponent
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "exponent")]
	public string Exponent { get; set; } = string.Empty;

	/// <summary>
	/// Parameters
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "parameters")]
	public string Parameters { get; set; } = string.Empty;

	/// <summary>
	/// Signature
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "signature")]
	public string Signature { get; set; } = string.Empty;

	/// <summary>
	/// Key Size
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "size")]
	public string Size { get; set; } = string.Empty;

	/// <summary>
	/// Key Usage
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "usage")]
	public string Usage { get; set; } = string.Empty;
}