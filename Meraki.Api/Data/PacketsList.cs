namespace Meraki.Api.Data;

/// <summary>
/// Packets statuses
/// </summary>
[DataContract]
public class PacketsList
{
	/// <summary>
	/// Port id
	/// </summary>
	[DataMember(Name = "portId")]
	public string PortId { get; set; } = string.Empty;

	/// <summary>
	/// Packets
	/// </summary>
	[DataMember(Name = "packets")]
	public List<Packets> Packets { get; set; } = new();
}
