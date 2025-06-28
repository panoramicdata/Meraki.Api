namespace Meraki.Api.Data;

/// <summary>
/// If custom host or port is specified, this field populates
/// </summary>
[DataContract]
public class OrganizationInsightWebAppSignature
{
	/// <summary>
	/// Custom host name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "host")]
	public string Host { get; set; } = string.Empty;

	/// <summary>
	/// Custom subnet mask
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "net")]
	public string Net { get; set; } = string.Empty;

	/// <summary>
	/// Custom port number
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "port")]
	public string Port { get; set; } = string.Empty;

	/// <summary>
	/// Signature type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "signatureType")]
	public string SignatureType { get; set; } = string.Empty;
}