namespace Meraki.Api.Data;

/// <summary>
/// Create or Update Network Switch Routing Multicast Rendezvous Point
/// </summary>
[DataContract]
public class RendezvousPointCreateUpdateRequest
{
	/// <summary>
	/// The IP address of the interface where the RP needs to be created.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "interfaceIp")]
	public string? InterfaceIp { get; set; }

	/// <summary>
	/// 'Any', or the IP address of a multicast group
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "multicastGroup")]
	public string? MulticastGroup { get; set; }

	/// <summary>
	/// The VRF with PIM enabled L3 interface
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "vrf")]
	public RendezvousPointVrf? Vrf { get; set; }
}
