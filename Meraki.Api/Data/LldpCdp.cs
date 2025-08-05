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
	public Dictionary<string, LldpCdpPort> Ports { get; set; } = [];

	/// <summary>
	/// The Ports dictionary is returned with keys wan0, wan1, wan2
	/// This is inconsistent with the rest of the API, where the WAN ports are named wan1, wan2, and wan3.
	/// This dictionary is used to map the keys to the correct names.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[JsonIgnore]
	public Dictionary<string, LldpCdpPort> PortsFixed => Ports.ToDictionary(
		p => p.Key switch
		{
			"wan0" => "wan1",
			"wan1" => "wan2",
			"wan2" => "wan3",
			_ => p.Key
		},
		p => p.Value
	);
}
