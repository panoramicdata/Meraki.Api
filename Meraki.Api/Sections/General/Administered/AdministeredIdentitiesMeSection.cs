using Meraki.Api.Interfaces.General.Administered;

namespace Meraki.Api.Sections.General.Administered;

/// <summary>
/// Represents the section of the API that provides operations for the current administered identity.
/// </summary>
public partial class AdministeredIdentitiesMeSection
{
	/// <summary>
	/// Gets or sets the API for operations related to the current administered identity.
	/// </summary>
	[RefitPromoteCalls]
	internal IAdministeredIdentitiesMe Me { get; set; } = null!;

	/// <summary>
	/// Gets the api
	/// </summary>
	public AdministeredIdentitiesMeApiSection Api { get; internal set; } = new();
}
