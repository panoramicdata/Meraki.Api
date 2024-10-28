namespace Meraki.Api.Data;

/// <summary>
/// LLDP CDP
/// </summary>
[DataContract]
public class LldpCdp
{
	/// <summary>
	/// Source mac
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sourceMac")]
	public string SourceMac { get; set; } = string.Empty;

	/// <summary>
	/// Mapping of ports to lldp and/or cdp information
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ports")]
	public Dictionary<string, LldpCdpPort> Ports { get; set; } = new();
}
