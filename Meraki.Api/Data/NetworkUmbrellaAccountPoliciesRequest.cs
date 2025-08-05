namespace Meraki.Api.Data;

/// <summary>
/// Network Umbrella Account Policies Request
/// </summary>
[DataContract]
public class NetworkUmbrellaAccountPoliciesRequest
{
	/// <summary>
	/// Array of umbrella policy IDs
	/// </summary>
	[DataMember(Name = "policyIds")]
	public List<string> PolicyIds { get; set; } = [];
}
