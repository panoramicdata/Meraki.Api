namespace Meraki.Api.Sections.Products.Sm;

public class SmSection
{
	public ISmApnsCert ApnsCert { get; internal set; } = null!;
	public SmDevicesSection Devices { get; internal set; } = new();
	public ISmTargetGroups TargetGroups { get; internal set; } = null!;
	public ISmProfiles Profiles { get; internal set; } = null!;
	public ISmUserAccessDevices UserAccessDevices { get; internal set; } = null!;
	public SmUsersSection Users { get; internal set; } = new();
	public ISmVppAccounts VppAccounts { get; internal set; } = null!;
}
