namespace Meraki.Api.Sections.Products.Wireless;

/// <summary>
/// Provides access to wireless radio API endpoints
/// </summary>
public class WirelessRadioSection
{
	/// <summary>
	/// Return the manually configured radio settings overrides of a device, which take precedence over RF profiles.
	/// </summary>

	public IWirelessRadioSettings Settings { get; internal set; } = null!;
}
