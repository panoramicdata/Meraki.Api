using Meraki.Api.Interfaces.SecureConnect.Policies;

namespace Meraki.Api.Sections.SecureConnect;
public class SecureConnectPoliciesSection
{
	public ISecureConnectPoliciesDestinationLists DestinationLists { get; internal set; } = null!;
	public ISecureConnectPoliciesDestinations Destinations { get; internal set; } = null!;
}
