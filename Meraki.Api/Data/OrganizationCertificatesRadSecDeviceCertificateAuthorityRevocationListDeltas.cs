namespace Meraki.Api.Data;

/// <summary>
/// Organization Certificates RadSec Device Certificate Authority Revocation List Deltas
/// </summary>
[DataContract]
public class OrganizationCertificatesRadSecDeviceCertificateAuthorityRevocationListDeltas
{
	/// <summary>
	/// An array containing the PEM encoded contents of a CA's delta certificate revocation list (CRL) - with newlines as "". This array delta CRLs only
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "deltaCrls")]
	public List<string> DeltaCrls { get; set; } = [];
}
