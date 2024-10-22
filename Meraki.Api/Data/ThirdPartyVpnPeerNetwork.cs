namespace Meraki.Api.Data;

/// <summary>
/// Peer Network
/// </summary>
[DataContract]
public class ThirdPartyVpnPeerNetwork
{
	/// <summary>
	/// Names - Undocumented - 2024-10-22
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "names")]
	public List<string>? Names { get; set; }

	/// <summary>
	/// Ids - Undocumented - 2024-10-22
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ids")]
	public List<string>? Ids { get; set; }
}
