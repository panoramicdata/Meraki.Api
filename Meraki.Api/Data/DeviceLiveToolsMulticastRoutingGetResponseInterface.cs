namespace Meraki.Api.Data;

/// <summary>
/// Interface that has PIM enabled
/// </summary>
[DataContract]
public class DeviceLiveToolsMulticastRoutingGetResponseInterface
{
	/// <summary>
	/// Interface IP address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ip")]
	public string Ip { get; set; } = string.Empty;

	/// <summary>
	/// Interface name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Subnet containing the interface
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "subnet")]
	public string Subnet { get; set; } = string.Empty;

	/// <summary>
	/// List of flags (unordered). enum = ["DISABLED", "DOWN", "DR", "DVMRP", "NO-NBR", ...]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "flags")]
	public List<string> Flags { get; set; } = [];

	/// <summary>
	/// Array of PIM Neighbor IP Addresses
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "neighbors")]
	public List<string> Neighbors { get; set; } = [];
}