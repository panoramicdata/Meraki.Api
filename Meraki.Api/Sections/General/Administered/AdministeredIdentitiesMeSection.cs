using Meraki.Api.Interfaces.General.Administered;

namespace Meraki.Api.Sections.General.Administered;

public partial class AdministeredIdentitiesMeSection
{
	[RefitPromoteCalls]
	internal IAdministeredIdentitiesMe Me { get; set; } = null!;
}