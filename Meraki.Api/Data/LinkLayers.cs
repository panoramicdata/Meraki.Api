namespace Meraki.Api.Data;

/// <summary>
/// Link layers
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class LinkLayers
{
	/// <summary>
	/// Nodes
	/// </summary>
	[DataMember(Name = "nodes")]
	public List<LinkLayerNode> Nodes { get; set; } = [];

	/// <summary>
	/// Links
	/// </summary>
	[DataMember(Name = "links")]
	public List<LinkLayerLinks> Links { get; set; } = [];

	/// <summary>
	/// Errors - No example response as at June 2023
	/// </summary>
	[DataMember(Name = "errors")]
	public List<object> Errors { get; set; } = [];
}
