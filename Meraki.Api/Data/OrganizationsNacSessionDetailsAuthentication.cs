namespace Meraki.Api.Data;

/// <summary>
/// Authentication details
/// </summary>
[DataContract]
public class OrganizationsNacSessionDetailsAuthentication
{
	/// <summary>
	/// Authentication Latency in msec
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "latency")]
	public int Latency { get; set; }

	/// <summary>
	/// Authentication Method
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "method")]
	public string Method { get; set; } = string.Empty;

	/// <summary>
	/// Authentication Policy
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "policy")]
	public string Policy { get; set; } = string.Empty;

	/// <summary>
	/// Authentication Protocol
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "protocol")]
	public string Protocol { get; set; } = string.Empty;

	/// <summary>
	/// Endpoint Certificate used for Authentication
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "endpointCertificate")]
	public OrganizationsNacSessionDetailsAuthenticationEndpointCertificate EndpointCertificate { get; set; } = new();
}
