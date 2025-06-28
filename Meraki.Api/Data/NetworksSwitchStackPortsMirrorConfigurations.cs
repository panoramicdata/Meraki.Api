namespace Meraki.Api.Data;

/// <summary>
/// Switch port mirror configurations
/// </summary>
[DataContract]
public class NetworksSwitchStackPortsMirrorConfigurations
{
	/// <summary>
	/// My pretty comment
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "comment")]
	public string Comment { get; set; } = string.Empty;

	/// <summary>
	/// Switch role can be source or destination
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "role")]
	public string Role { get; set; } = string.Empty;

	/// <summary>
	/// Port mirror tags
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "tags")]
	public List<string> Tags { get; set; } = [];

	/// <summary>
	/// Destination port mirror configuration
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "destination")]
	public NetworksSwitchStackPortsMirrorConfigurationsDestination Destination { get; set; } = new();

	/// <summary>
	/// Source port mirror configuration
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "source")]
	public NetworksSwitchStackPortsMirrorConfigurationsSource Source { get; set; } = new();
}
