namespace Meraki.Api.Data;

/// <summary>
/// SsidUpdateRequestLocalAuthFallback
/// </summary>
[DataContract]
public class SsidUpdateRequestLocalAuthFallback
{
	/// <summary>
	/// The duration (in seconds) for which auths are cached. The timeout is measured from the user's most recent non-cached authentication to the network. Between 3600 (1 hour) and 86400 (1 day)
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "cacheTimeout")]
	public int? CacheTimeout { get; set; }

	/// <summary>
	/// If true, MR devices will cache authentication credentials for EAP-TLS or for MAC based authentication.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// The Server CA Certificate used to sign the client certificate.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "serverCaCertificate")]
	public SsidUpdateRequestLocalAuthFallbackServerCaCertificate? ServerCaCertificate { get; set; }
}
