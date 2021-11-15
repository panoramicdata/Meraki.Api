using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Firewalled service
/// </summary>
[DataContract]
public class FirewalledService
{
	/// <summary>
	/// Service
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "service")]
	public FirewalledServiceType Service { get; set; }

	/// <summary>
	/// A string indicating the rule for which IPs are allowed to use the specified service.
	/// Acceptable values are "blocked" (no remote IPs can access the service), "restricted"
	/// (only allowed IPs can access the service), and "unrestriced" (any remote IP can access the service). This field is required
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "access")]
	public FirewalledServiceAccessType Access { get; set; }

	/// <summary>
	/// An array of allowed IPs that can access the service. This field is required if "access" is set to "restricted". Otherwise this field is ignored
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "allowedIps")]
	public List<string> AllowedIps { get; set; } = new();
}
