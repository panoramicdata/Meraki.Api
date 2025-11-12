namespace Meraki.Api.Sections.Products.Switch;

/// <summary>
/// Provides access to switch config templates API endpoints
/// </summary>
public class SwitchConfigTemplatesSection
{
	/// <summary>
	/// List the switch templates for your switch template configuration
	/// </summary>

	public ISwitchProfiles Profiles { get; internal set; } = null!;
}
