namespace Meraki.Api.Data;

/// <summary>
/// EAP settings for identity requests
/// </summary>
[DataContract]
public class EapolIdentity
{
	/// <summary>
	/// Maximum number of EAP retries.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "retries")]
	public int Retries { get; set; }

	/// <summary>
	/// EAP timeout in seconds.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "timeout")]
	public int Timeout { get; set; }
}