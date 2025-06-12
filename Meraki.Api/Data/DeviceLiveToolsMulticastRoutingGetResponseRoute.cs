namespace Meraki.Api.Data;

/// <summary>
/// Multicast route
/// </summary>
[DataContract]
public class DeviceLiveToolsMulticastRoutingGetResponseRoute
{
	/// <summary>
	/// Group IP address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "group")]
	public string Group { get; set; } = string.Empty;

	/// <summary>
	/// Name of the Virtual Interface traffic is arriving on
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "incomingInterfaceName")]
	public string IncomingInterfaceName { get; set; } = string.Empty;

	/// <summary>
	/// IP address of the rendezvous point
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "rendezvousPoint")]
	public string RendezvousPoint { get; set; } = string.Empty;

	/// <summary>
	/// Source IP or "Any"
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "source")]
	public string Source { get; set; } = string.Empty;

	/// <summary>
	/// List of flags (unordered). enum = ["ASSERTED", "CACHE", "IIF_REG", "NULL_OIF", "PMBR", ...]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "flags")]
	public List<string> Flags { get; set; } = [];

	/// <summary>
	/// Array of outgoing Virtual Interface names
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "outgoingInterfaceNames")]
	public List<string> OutgoingInterfaceNames { get; set; } = [];
}