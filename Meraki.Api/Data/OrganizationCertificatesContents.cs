namespace Meraki.Api.Data;

/// <summary>
/// Organization Certificates Contents
/// </summary>
[DataContract]
public class OrganizationCertificatesContents
{
	/// <summary>
	/// Base 64 cert(s)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "contets")]
	public string Contents { get; set; } = string.Empty;
}
