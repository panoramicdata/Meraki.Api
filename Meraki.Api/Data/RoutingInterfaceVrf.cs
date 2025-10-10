namespace Meraki.Api.Data;

/// <summary>
/// Routing interface VRF Settings
/// </summary>
[DataContract]
public class RoutingInterfaceVrf
{
	/// <summary>
	/// The name of the VRF this interface belongs to
	/// </summary>
	[ApiKey]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

}
