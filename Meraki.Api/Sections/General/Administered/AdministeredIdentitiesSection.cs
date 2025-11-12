namespace Meraki.Api.Sections.General.Administered;

/// <summary>
/// Provides access to administered identities API endpoints
/// </summary>
public class AdministeredIdentitiesSection
{
	/// <summary>
	/// Gets the me
	/// </summary>

	public AdministeredIdentitiesMeSection Me { get; internal set; } = new();
}
