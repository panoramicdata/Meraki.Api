namespace Meraki.Api.Sections.Products.Sm;

/// <summary>
/// Provides access to sm users API endpoints
/// </summary>

// Codacy analyses each file on its own, so it cannot see the other parts of this class and reports
// 'partial' as gratuitous (S2333). That is a false positive: the remaining part is emitted by
// RefitClassSourceGenerator.
#pragma warning disable S2333
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
#pragma warning restore S2333
