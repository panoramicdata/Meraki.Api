namespace Meraki.Api.Data;
/// <summary>
/// Member
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]

public class LinkLayerNodeStackMember
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
	/// Device
	/// </summary>
	[DataMember(Name = "device")]
	public StackDevice Device { get; set; } = new();
}
