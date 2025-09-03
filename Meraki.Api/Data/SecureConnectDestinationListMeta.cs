namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectDestinationListMeta
/// </summary>
[DataContract]
public class SecureConnectDestinationListMeta
{
	/// <summary>
	/// The total number of applications in a destination list. 
	/// Applications are part of the total number of destinations in a destination list.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "applicationCount")]
	public int? ApplicationCount { get; set; }

	/// <summary>
	/// The total number of destinations in a destination list.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "destinationCount")]
	public int? DestinationCount { get; set; }

	/// <summary>
	/// The total number of domains in a destination list.
	/// Domains are part of the total number of destinations in a destination list.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "domainCount")]
	public int? DomainCount { get; set; }

	/// <summary>
	/// The total number of IP addresses in a destination list.
	/// IP addresses are part of the total number of destinations in a destination list.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "ipv4Count")]
	public int? Ipv4Count { get; set; }

	/// <summary>
	/// The total number of URLs in a destination list.
	/// Urls are part of the total number of destinations in a destination list.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "urlCount")]
	public int? UrlCount { get; set; }
}
