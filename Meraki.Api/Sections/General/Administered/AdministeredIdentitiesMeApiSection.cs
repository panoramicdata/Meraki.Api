using Meraki.Api.Interfaces.General.Administered;

namespace Meraki.Api.Sections.General.Administered;

public class AdministeredIdentitiesMeApiSection
{
	public IAdministeredIdentitiesMeApiKeys Keys { get; internal set; } = null!;
}