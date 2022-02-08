namespace Meraki.Api.Data;

/// <summary>
/// CreateOrganizationBrandingPolicy
/// </summary>
[DataContract]
public class BrandingPolicy : NamedItem
{
	/// <summary>
	/// The Id of the Branding Policy
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "brandingPolicyId")]
	public string BrandingPolicyId { get; set; } = string.Empty;

	/// <summary>
	/// Boolean indicating whether this policy is enabled.
	/// </summary>
	/// <value>Boolean indicating whether this policy is enabled.</value>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// Gets or Sets AdminSettings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "adminSettings")]
	public AdminSettings AdminSettings { get; set; } = null!;

	/// <summary>
	/// Gets or Sets HelpSettings
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "helpSettings")]
	public HelpSettings HelpSettings { get; set; } = null!;
}
