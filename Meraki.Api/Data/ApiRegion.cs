namespace Meraki.Api.Data;
public enum ApiRegion
{
	/// <summary>
	/// The default region for the Meraki Dashboard API
	/// This uses the "api.meraki.com" endpoint
	/// </summary>
	[MerakiApiDomain("meraki.com")]
	Default = 0,

	/// <summary>
	/// The China region for the Meraki Dashboard API
	/// This uses the "api.meraki.cn" endpoint
	/// </summary>
	[MerakiApiDomain("meraki.cn")]
	China = 1,

	/// <summary>
	/// The Canada region for the Meraki Dashboard API
	/// This uses the "api.meraki.ca" endpoint
	/// </summary>
	[MerakiApiDomain("meraki.ca")]
	Canada = 2,

	/// <summary>
	/// The India region for the Meraki Dashboard API
	/// This uses the "api.meraki.in" endpoint
	/// </summary>
	[MerakiApiDomain("meraki.in")]
	India = 3,

	/// <summary>
	/// The Government region for the Meraki Dashboard API
	/// This uses the "api.gov-meraki.com" endpoint
	/// </summary>
	[MerakiApiDomain("gov-meraki.com")]
	Government = 4
}
