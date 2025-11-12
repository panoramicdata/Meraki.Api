namespace Meraki.Api.Sections.Products.Appliance;

/// <summary>
/// Provides access to appliance security API endpoints
/// </summary>
public class ApplianceSecuritySection
{
	/// <summary>
	/// Returns all supported intrusion settings for an organization
	/// </summary>

	public IApplianceSecurityIntrusion Intrusion { get; internal set; } = null!;
	/// <summary>
	/// Returns all supported malware settings for an MX network
	/// </summary>

	public IApplianceSecurityMalware Malware { get; internal set; } = null!;
	/// <summary>
	/// List the security events for a network
	/// </summary>

	public IApplianceSecurityEvents Events { get; internal set; } = null!;
}
