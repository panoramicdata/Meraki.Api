namespace Meraki.Api.Data;

/// <summary>
/// UpdateNetworkStaticRoute
/// </summary>
[DataContract]
public class StaticRouteUpdateRequest : StaticRouteCreationRequest
{
	/// <summary>
	/// The enabled state of the static route
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// The DHCP fixed IP assignments on the static route. This should be an object that contains mappings from MAC addresses to objects that themselves each contain \&quot;ip\&quot; and \&quot;name\&quot; string fields. See the sample request/response for more details.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "fixedIpAssignments")]
	public Dictionary<string, StaticRouteFixedIpAssignment>? FixedIpAssignments { get; set; }

	/// <summary>
	/// The DHCP reserved IP ranges on the static route
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "reservedIpRanges")]
	public List<ReservedIpRange>? ReservedIpRanges { get; set; }
}
