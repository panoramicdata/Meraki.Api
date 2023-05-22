namespace Meraki.Api.Data;

/// <summary>
/// Port statuses of a switch
/// </summary>
[DataContract]
public class SwitchPortsStatusesBySwitchNetwork
{
	/// <summary>
	/// The ID of the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// The name of the network.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}
