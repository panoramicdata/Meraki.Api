namespace Meraki.Api.Sections.SecureConnect;
public class SecureConnectSection
{
	public SecureConnectDeploymentsSection Deployments { get; internal set; } = null!;
	public SecureConnectPoliciesSection Policies { get; internal set; } = null!;
}
