namespace Meraki.Api.Data;

/// <summary>
/// A VRF associated with a site-to-site VPN hub - Undocumented, observed in responses only
/// </summary>
[DataContract]
public class HubVrf
{
	/// <summary>
	/// The VRF ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// The VRF name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}
