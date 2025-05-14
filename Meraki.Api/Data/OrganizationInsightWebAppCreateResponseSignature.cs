namespace Meraki.Api.Data;

/// <summary>
/// If custom host or port is specified, this field populates
/// </summary>
[DataContract]
public class OrganizationInsightWebAppCreateResponseSignature
{
	/// <summary>
	/// If custom host or port is specified, this field populates
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "host")]
	public string Host { get; set; } = string.Empty;

	/// <summary>
	/// Signature type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "signatureType")]
	public string SignatureType { get; set; } = string.Empty;
}