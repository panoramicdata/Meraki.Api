namespace Meraki.Api.Data;

/// <summary>
/// Early Access Feature Opt In Update Request
/// </summary>
[DataContract]
public class EarlyAccessFeatureOptInUpdateRequest
{
	/// <summary>
	/// A list of network IDs to apply the opt-in to
	/// </summary>
	[DataMember(Name = "limitScopeToNetworks")]
	public List<string> LimitScopeToNetworks { get; set; } = [];
}