namespace Meraki.Api.Data;

/// <summary>
/// SsidUpdateRequestLocalAuthFallbackServerCaCertificate
/// </summary>
[DataContract]
public class SsidUpdateRequestLocalAuthFallbackServerCaCertificate
{
	/// <summary>
	/// The contents of the Server CA Certificate. Must be in PEM or DER format.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "contents")]
	public string? Contents { get; set; }

}
