namespace Meraki.Api.Data;

[DataContract]
public class SplitNetworkResponse
{
	/// <summary>
	/// Resulting networks
	/// </summary>
	[ApiAccess(ApiAccess.Create)]
	[DataMember(Name = "resultingNetworks")]
	public List<Network> ResultingNetworks { get; set; } = [];
}
