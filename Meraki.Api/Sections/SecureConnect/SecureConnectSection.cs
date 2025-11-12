namespace Meraki.Api.Sections.SecureConnect;
/// <summary>
/// Provides access to secure connect API endpoints
/// </summary>
public class SecureConnectSection
{
	/// <summary>
	/// Gets the deployments
	/// </summary>

	public SecureConnectDeploymentsSection Deployments { get; internal set; } = new();
	/// <summary>
	/// Gets the policies
	/// </summary>

	public SecureConnectPoliciesSection Policies { get; internal set; } = new();
}
