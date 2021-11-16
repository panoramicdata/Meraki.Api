namespace Meraki.Api.Sections.Products.Sm;

public partial class SmUsersSection
{
	[RefitPromoteCalls]
	internal ISmUsers Users { get; set; } = null!;
	public ISmUsersDeviceProfiles DeviceProfiles { get; internal set; } = null!;
	public ISmUsersSoftwares Softwares { get; internal set; } = null!;
}