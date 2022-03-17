namespace Meraki.Api.Data;
/// <summary>
/// Ends
/// </summary>
[DataContract]

public class LinkLayerLinksEnds
{
	/// <summary>
	/// Node
	/// </summary>
	[DataMember(Name = "node")]
	public LinkLayerNode Node { get; set; } = new();

	/// <summary>
	/// Device
	/// </summary>
	[DataMember(Name = "device")]
	public StackDevice Device { get; set; } = new();

	/// <summary>
	/// Discovered
	/// </summary>
	[DataMember(Name = "discovered")]
	public LinkLayerNodeDiscovered Discovered { get; set; } = new();
}
