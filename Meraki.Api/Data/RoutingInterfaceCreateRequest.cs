using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Routing interface update request
/// </summary>
[DataContract]
public class RoutingInterfaceCreateRequest : RoutingInterfaceUpdateRequest
{
	/// <summary>
	/// The next hop for any traffic that isn't going to a directly connected subnet or over a static route. This IP address must exist in a subnet with a routed interface.
	/// </summary>
	[ApiAccess(ApiAccess.ReadCreate)]
	[DataMember(Name = "defaultGateway")]
	public string DefaultGateway { get; set; } = string.Empty;
}
