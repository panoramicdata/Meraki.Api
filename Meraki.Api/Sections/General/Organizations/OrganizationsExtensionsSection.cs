namespace Meraki.Api.Sections.General.Organizations;
public class OrganizationsExtensionsSection
{
	public OrganizationsExtensionsSdwanManagerSection SdwanManager { get; internal set; } = new();

	public IOrganizationsExtensionsThousandEyes ThousandEyes { get; internal set; } = null!;
}
