namespace Meraki.Api.Sections.Products.Sm;

/// <summary>
/// Provides access to sm API endpoints
/// </summary>
public class SmSection
{
	/// <summary>
	/// Get the organization's APNS certificate
	/// </summary>

	public ISmApnsCert ApnsCert { get; internal set; } = null!;
	/// <summary>
	/// Return a single device
	/// </summary>

	public SmDevicesSection Devices { get; internal set; } = new();
	/// <summary>
	/// Add a target group
	/// </summary>

	public ISmTargetGroups TargetGroups { get; internal set; } = null!;
	/// <summary>
	/// List all the profiles in the network
	/// </summary>

	public ISmProfiles Profiles { get; internal set; } = null!;
	/// <summary>
	/// List User Access Devices and its Trusted Access Connections
	/// </summary>

	public ISmUserAccessDevices UserAccessDevices { get; internal set; } = null!;
	/// <summary>
	/// Gets the users
	/// </summary>

	public SmUsersSection Users { get; internal set; } = new();
	/// <summary>
	/// List the VPP accounts in the organization
	/// </summary>

	public ISmVppAccounts VppAccounts { get; internal set; } = null!;
}
