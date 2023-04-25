namespace Meraki.Api.Data;

/// <summary>
/// Network Switch Routing Multicast Rendezvous Points
/// </summary>
[DataContract]
public class RendezvousPoint : RendezvousPointCreateUpdateRequest
{
	/// <summary>
	/// RendezvousPointId
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "rendezvousPointId")]
	public string? RendezvousPointId { get; set; }

	/// <summary>
	/// Serial
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }

	/// <summary>
	/// InterfaceName
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "interfaceName")]
	public string? InterfaceName { get; set; }

	/// <summary>
	/// Switch Stack ID - Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "switchStackId")]
	public string? SwitchStackId { get; set; }
}
