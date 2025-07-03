namespace Meraki.Api.Data;

/// <summary>
/// Networks Switch Stack Ports Mirror Update Request
/// </summary>
[DataContract]
public class NetworksSwitchStackPortsMirrorUpdateRequest
{
	/// <summary>
	/// My pretty comment (Actually from the documentation!)
	/// </summary>
	[DataMember(Name = "comment")]
	public string? Comment { get; set; }

	/// <summary>
	/// Switch role can be source or destination
	/// </summary>
	[DataMember(Name = "role")]
	public string? Role { get; set; }

	/// <summary>
	/// Port mirror tags
	/// </summary>
	[DataMember(Name = "tags")]
	public List<string>? Tags { get; set; }

	/// <summary>
	/// Destination port Details
	/// </summary>
	[DataMember(Name = "destination")]
	public NetworksSwitchStackPortsMirrorUpdateRequestDestination Destination { get; set; } = new();

	/// <summary>
	/// Source port details
	/// </summary>
	[DataMember(Name = "source")]
	public NetworksSwitchStackPortsMirrorUpdateRequestSource Source { get; set; } = new();
}
