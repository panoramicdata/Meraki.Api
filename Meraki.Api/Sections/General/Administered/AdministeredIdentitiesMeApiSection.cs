using Meraki.Api.Interfaces.General.Administered;

namespace Meraki.Api.Sections.General.Administered;

/// <summary>
/// Provides access to administered identities me api API endpoints
/// </summary>
public class AdministeredIdentitiesMeApiSection
{
	/// <summary>
	/// List the non-sensitive metadata associated with the API keys that belong to the user
	/// </summary>

	public IAdministeredIdentitiesMeApiKeys Keys { get; internal set; } = null!;
}
