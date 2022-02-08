namespace Meraki.Api.Data;

/// <summary>
/// An organization
/// </summary>
[DataContract]
public class Organization : NamedIdentifiedItem
{
	/// <summary>
	/// Readonly: URL
	/// </summary>
	[DataMember(Name = "url")]
	[ApiAccess(ApiAccess.Read)]
	public string Url { get; set; } = string.Empty;

	/// <summary>
	/// API-specific settings
	/// </summary>
	[DataMember(Name = "api")]
	[ApiAccess(ApiAccess.ReadUpdate)]
	public OrganizationApi Api { get; set; } = new();

	/// <summary>
	/// Licensing details
	/// </summary>
	[DataMember(Name = "licensing")]
	[ApiAccess(ApiAccess.Read)]
	public LicensingInformation Licensing { get; set; } = new();

	/// <summary>
	/// Cloud details
	/// </summary>
	[DataMember(Name = "cloud")]
	[ApiAccess(ApiAccess.Read)]
	public CloudInformation? Cloud { get; set; }
}
