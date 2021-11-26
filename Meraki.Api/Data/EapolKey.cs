namespace Meraki.Api.Data;

[DataContract]
public class EapolKey
{
	/// <summary>
	/// Maximum number of EAPOL key retries.
	/// </summary>
	[ApiAccess(ApiAccess.Update)]
	[DataMember(Name = "retries")]
	public int Retries { get; set; }


	/// <summary>
	/// EAPOL Key timeout in milliseconds.
	/// </summary>
	[ApiAccess(ApiAccess.Update)]
	[DataMember(Name = "timeoutInMs")]
	public int TimeoutInMs { get; set; }
}