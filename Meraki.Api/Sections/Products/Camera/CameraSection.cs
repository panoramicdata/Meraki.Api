namespace Meraki.Api.Sections.Products.Camera;

public partial class CameraSection
{
	[RefitPromoteCalls]
	internal ICamera Camera { get; set; } = null!;
	public CameraAnalyticsSection Analytics { get; internal set; } = new();
	public ICameraQualityAndRetention QualityAndRetention { get; internal set; } = null!;
	public CameraSenseSection Sense { get; internal set; } = new();
	public CameraVideoSection Video { get; internal set; } = new();
	public ICameraVideoLink VideoLink { get; internal set; } = null!;
	public ICameraWirelessProfiles WirelessProfiles { get; internal set; } = null!;
	public ICameraQualityAndRetentionProfiles QualityAndRetentionProfiles { get; internal set; } = null!;
	public ICameraSchedules Schedules { get; internal set; } = null!;
	public CameraOnboardingSection Onbording { get; internal set; } = new();
}
