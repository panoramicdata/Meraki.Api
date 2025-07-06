namespace Meraki.Api.Data;

/// <summary>
/// Network Umbrella Account Exclude Domains Request
/// </summary>
[DataContract]
public class NetworkUmbrellaAccountExcludeDomainsRequest
{
	/// <summary>
	/// Array of domain names
	/// </summary>
	[DataMember(Name = "domains")]
	public List<string> Domains { get; set; } = [];
}
