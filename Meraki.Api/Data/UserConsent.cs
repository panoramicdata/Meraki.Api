namespace Meraki.Api.Data;

/// <summary>
/// User consent settings for splash page
/// </summary>
[DataContract]
public class UserConsent
{
	/// <summary>
	/// Whether user consent is required. Undocumented property.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "required")]
	public bool? Required { get; set; }

	/// <summary>
	/// The consent message to display to users. Undocumented property.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "message")]
	public string? Message { get; set; }
}
