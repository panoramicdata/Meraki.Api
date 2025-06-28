namespace Meraki.Api.Data;

/// <summary>
/// Organization Certificates Update Request
/// </summary>
[DataContract]
public class OrganizationCertificatesUpdateRequest
{
	/// <summary>
	/// Description of a certificate that already exist in your org
	/// </summary>
	[DataMember(Name = "description")]
	public string? Description { get; set; }
}
