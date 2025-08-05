namespace Meraki.Api.Sections.SecureConnect;
public class SecureConnectSection
{
	public SecureConnectDeploymentsSection Deployments { get; internal set; } = new();
	public SecureConnectPoliciesSection Policies { get; internal set; } = new();
}
