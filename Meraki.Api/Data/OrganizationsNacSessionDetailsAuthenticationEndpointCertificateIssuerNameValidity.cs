namespace Meraki.Api.Data;

/// <summary>
/// Endpoint Certificate Validity Details
/// </summary>
[DataContract]
public class OrganizationsNacSessionDetailsAuthenticationEndpointCertificateIssuerNameValidity
{
	/// <summary>
	/// Endpoint Certificate End Date
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "end")]
	public string End { get; set; } = string.Empty;

	/// <summary>
	/// Endpoint Certificate Start Date
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "start")]
	public string Start { get; set; } = string.Empty;
}