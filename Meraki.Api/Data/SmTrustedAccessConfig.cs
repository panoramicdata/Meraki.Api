namespace Meraki.Api.Data;
/// <summary>
/// Sm Trusted Access
/// </summary>
public class SmTrustedAccessConfig : NamedIdentifiedItem
{
	/// <summary>
	/// SSID Name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ssidName")]
	public string? SsidName { get; set; }

	/// <summary>
	/// Scope
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "scope")]
	public string? Scope { get; set; }

	/// <summary>
	/// Tags
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public List<string>? Tags { get; set; }

	/// <summary>
	/// Access Start At
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "accessStartAt")]
	public DateTime? AccessStartAt { get; set; }

	/// <summary>
	/// Access End At
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "accessEndAt")]
	public DateTime? AccessEndAt { get; set; }

	/// <summary>
	/// Send Email Notifications
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sendExpirationEmails")]
	public bool? SendExpirationEmails { get; set; }

	/// <summary>
	/// Time before access expiration reminder email sends
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "notifyTimeBeforeAccessEnds")]
	public int? NotifyTimeBeforeAccessEnds { get; set; }

	/// <summary>
	/// Optional email text
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "additionalEmailText")]
	public string? AdditionalEmailText { get; set; }
}
