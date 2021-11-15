namespace Meraki.Api.Sections.Products.Sm;

public class SmUsersSection
{
	public ISmUsers Users { get; internal set; } = null!;
	public ISmUsersDeviceProfiles DeviceProfiles { get; internal set; } = null!;
	public ISmUsersSoftwares Softwares { get; internal set; } = null!;
}