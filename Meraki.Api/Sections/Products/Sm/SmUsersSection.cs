namespace Meraki.Api.Sections.Products.Sm;

/// <summary>
/// Provides access to sm users API endpoints
/// </summary>

public partial class SmUsersSection
{
	[RefitPromoteCalls]
	internal ISmUsers Users { get; set; } = null!;
	/// <summary>
	/// Get the profiles associated with a user
	/// </summary>

	public ISmUsersDeviceProfiles DeviceProfiles { get; internal set; } = null!;
	/// <summary>
	/// Get a list of softwares associated with a user
	/// </summary>

	public ISmUsersSoftwares Softwares { get; internal set; } = null!;
}
