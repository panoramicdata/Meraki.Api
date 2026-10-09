namespace Meraki.Api.Data;

/// <summary>
/// Appearance settings for a branding policy - Undocumented, observed in responses only
/// </summary>
[DataContract]
public class BrandingPolicyAppearance
{
	/// <summary>
	/// The Dashboard menu theme, for example 'light'. A string rather than an enum, as the full set of values is not documented.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dashboardMenuTheme")]
	public string? DashboardMenuTheme { get; set; }
}
