namespace Meraki.Api.Data;

/// <summary>
/// Eapol Key
/// </summary>
[DataContract]
public class EapolKey
{
	/// <summary>
	/// Maximum number of EAPOL key retries.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "retries")]
	public int Retries { get; set; }

	/// <summary>
	/// EAPOL Key timeout in milliseconds.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "timeoutInMs")]
	public int TimeoutInMs { get; set; }
}
