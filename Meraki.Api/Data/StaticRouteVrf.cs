namespace Meraki.Api.Data;

/// <summary>
/// The VRF of an appliance static route - Undocumented, observed in responses only
/// </summary>
[DataContract]
public class StaticRouteVrf
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
