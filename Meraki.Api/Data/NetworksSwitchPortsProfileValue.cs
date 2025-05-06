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
	[ApiAccess(ApiAccess.Create)]
	public string? Id { get; set; }

	/// <summary>
	/// The name of network / associated node group
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.Create)]
	public string? Name { get; set; }
}
