namespace Meraki.Api.Sections.General.Administered;

/// <summary>
/// Provides access to administered API endpoints
/// </summary>
public class AdministeredSection
{
	/// <summary>
	/// Gets the identities
	/// </summary>

	public AdministeredIdentitiesSection Identities { get; internal set; } = new();

	/// <summary>
	/// Gets the licensing
	/// </summary>

	public AdministeredLicensingSection Licensing { get; internal set; } = new();
}
