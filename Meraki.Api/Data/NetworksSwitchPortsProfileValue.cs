namespace Meraki.Api.Data;

/// <summary>
/// Associated Network
/// </summary>
[DataContract]
public class NetworksSwitchPortsProfileValue
{
	/// <summary>
	/// he ID of the network / associated node group
	/// </summary>
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// The name of network / associated node group
	/// </summary>
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}
