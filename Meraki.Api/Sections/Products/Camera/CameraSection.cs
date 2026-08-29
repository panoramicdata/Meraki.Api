namespace Meraki.Api.Sections.Products.Camera;

/// <summary>
/// Provides access to camera API endpoints
/// </summary>

// Codacy analyses each file on its own, so it cannot see the other parts of this class and reports
// 'partial' as gratuitous (S2333). Both are false positives: the remaining parts are emitted by
// RefitClassSourceGenerator, or live in the sibling MerakiClient files.
#pragma warning disable S2333
public partial class CameraSection
{
	[RefitPromoteCalls]
	internal ICamera Camera { get; set; } = null!;
	/// <summary>
	/// Gets the analytics
	/// </summary>

	public CameraAnalyticsSection Analytics { get; internal set; } = new();
	/// <summary>
	/// Returns all configured area boundaries of cameras
	/// </summary>

	public ICameraBoundaries Boundaries { get; internal set; } = null!;
	/// <summary>
	/// Returns quality and retention settings for the given camera
	/// </summary>

	public ICameraQualityAndRetention QualityAndRetention { get; internal set; } = null!;
	/// <summary>
	/// Creates new role for this organization.
	/// </summary>

	public ICameraRoles Roles { get; internal set; } = null!;
	/// <summary>
	/// Gets the sense
	/// </summary>

	public CameraSenseSection Sense { get; internal set; } = new();
	/// <summary>
	/// Gets the video
	/// </summary>

	public CameraVideoSection Video { get; internal set; } = new();
	/// <summary>
	/// Returns video link to the specified camera
	/// </summary>

	public ICameraVideoLink VideoLink { get; internal set; } = null!;
	/// <summary>
	/// Returns wireless profile assigned to the given camera
	/// </summary>

	public ICameraWirelessProfiles WirelessProfiles { get; internal set; } = null!;
	/// <summary>
	/// List the quality retention profiles for this network
	/// </summary>

	public ICameraQualityAndRetentionProfiles QualityAndRetentionProfiles { get; internal set; } = null!;
	/// <summary>
	/// Returns a list of all camera recording schedules.
	/// </summary>

	public ICameraSchedules Schedules { get; internal set; } = null!;
	/// <summary>
	/// Gets the onbording
	/// </summary>

	public CameraOnboardingSection Onbording { get; internal set; } = new();
}
#pragma warning restore S2333
