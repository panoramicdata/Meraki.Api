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
	[ApiAccess(ApiAccess.Read)]
	public string? Id { get; set; }

	/// <summary>
	/// The name of network / associated node group
	/// </summary>
	[DataMember(Name = "name")]
	[ApiAccess(ApiAccess.ReadWrite)]
	public string? Name { get; set; }
}
