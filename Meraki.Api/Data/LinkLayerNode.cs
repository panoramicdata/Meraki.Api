namespace Meraki.Api.Data;

/// <summary>
/// Link layer node
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]

public class LinkLayerNode
{
	/// <summary>
	/// Derived id
	/// </summary>
	[DataMember(Name = "derivedId")]
	public string DerivedId { get; set; } = string.Empty;

	/// <summary>
	/// Mac
	/// </summary>
	[DataMember(Name = "mac")]
	public string Mac { get; set; } = string.Empty;

	/// <summary>
	/// Type
	/// </summary>
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// Root
	/// </summary>
	[DataMember(Name = "root")]
	public bool Root { get; set; }

	/// <summary>
	/// Discovered
	/// </summary>
	[DataMember(Name = "discovered")]
	public LinkLayerNodeDiscovered Discovered { get; set; } = new();

	/// <summary>
	/// Stack
	/// </summary>
	[DataMember(Name = "stack")]
	public LinkLayerNodeStack Stack { get; set; } = new();

	/// <summary>
	/// Device
	/// </summary>
	[DataMember(Name = "device")]
	public StackDevice Device { get; set; } = new();
}
