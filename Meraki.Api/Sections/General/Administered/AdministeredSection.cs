namespace Meraki.Api.Sections.General.Administered;

public class AdministeredSection
{
	public AdministeredIdentitiesSection Identities { get; internal set; } = new();

	public AdministeredLicensingSection Licensing { get; internal set; } = new();
}
