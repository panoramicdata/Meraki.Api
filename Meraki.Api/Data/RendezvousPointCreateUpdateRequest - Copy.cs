namespace Meraki.Api.Data;

/// <summary>
/// The VRF with PIM enabled L3 interface
/// </summary>
[DataContract]
public class RendezvousPointVrf
{
	/// <summary>
	/// The name of the VRF
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

}
