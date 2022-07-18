namespace Meraki.Api.Data;

/// <summary>
/// Early Access Feature Opt In Create Request
/// </summary>
[DataContract]
public class EarlyAccessFeatureOptInCreateRequest
{
	/// <summary>
	/// Short name of the early access feature
	/// </summary>
	[DataMember(Name = "shortName")]
	public string ShortName { get; set; } = string.Empty;

	/// <summary>
	/// A list of network IDs to apply the opt-in to
	/// </summary>
	[DataMember(Name = "limitScopeToNetworks")]
	public List<string> LimitScopeToNetworks { get; set; } = new();
}