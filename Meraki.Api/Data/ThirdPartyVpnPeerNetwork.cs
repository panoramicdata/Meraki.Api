namespace Meraki.Api.Data;

/// <summary>
/// Peer Network
/// </summary>
[DataContract]
public class ThirdPartyVpnPeerNetwork
{
	/// <summary>
	/// [optional] A list of network Names.Supported only for MX 19.1 and above.The order of items matches the order of IDs.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "names")]
	public List<string>? Names { get; set; }

	/// <summary>
	/// [optional] A list of network IDs.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "ids")]
	public List<string>? Ids { get; set; }
}
