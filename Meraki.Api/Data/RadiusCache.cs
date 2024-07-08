namespace Meraki.Api.Data;

/// <summary>
/// Object for RADIUS Cache Settings
/// </summary>
[DataContract]
public class RadiusCache
{
	/// <summary>
	/// If RADIUS caching is enabled, this value dictates how long the cache will remain in the RADIUS server, in hours, to allow network access without authentication
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "timeout")]
	public int? Timeout { get; set; }

	/// <summary>
	/// Enable to cache authorization and authentication responses on the RADIUS server
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
