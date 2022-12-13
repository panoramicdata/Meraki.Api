namespace Meraki.Api.Data;

/// <summary>
/// Secure port settings Client Privacy
/// </summary>
[DataContract]
public class NetworkSettingsClientPrivacy
{
	/// <summary>
	/// Expire Data Older Than
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "expireDataOlderThan")]
	public int? ExpireDataOlderThan { get; set; }

	/// <summary>
	/// Expire Data Before
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "expireDataBefore")]
	public DateTime? ExpireDataBefore { get; set; }
}
