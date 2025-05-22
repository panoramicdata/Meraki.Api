using static System.Net.WebRequestMethods;
using System;

namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectDestinationListCreateRequest
/// Provide destination information and an optional array of destination objects.
/// Accepts no more than 500 destination objects.
/// If you make an API request on the POST operation that adds a URL on a high-volume domain to a destination list,
/// the operation may succeed (HTTP/200 OK).
/// However, the server returns an error message(HTTP/400 Bad Request) that indicates that the destination is on a high-volume domain.
/// Note: Umbrella does not add URLs that are on high-volume domains to destination lists.Instead, we recommend that you add the domain only.
/// </summary>

[DataContract]
public class SecureConnectDestinationListCreateRequest
{
	/// <summary>
	/// The type of the destination list in the policy.
	/// Set 1 for DNS, 2 for web, and 4 for SAML Bypass.
	/// If the field is not specified, the default value is 1.
	/// default = 1, enum = [1, 2, 4]
	/// </summary>
	[DataMember(Name = "bundleTypeId")]
	public SecureConnectDestinationListBundleType BundleTypeId { get; set; }

	/// <summary>
	/// The type of access for the destination list. enum = ["allow", "block"]
	/// </summary>
	[DataMember(Name = "access")]
	public SecureConnectDestinationListAccess Access { get; set; }

	/// <summary>
	/// The name of the destination list.
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Specifies whether the destination list is a global destination list. There is only one default allow destination list and one default block destination list for an organization.
	/// </summary>
	[DataMember(Name = "isGlobal")]
	public bool IsGlobal { get; set; }

	/// <summary>
	/// The list of destinations.
	/// </summary>
	[DataMember(Name = "destinations")]
	public List<SecureConnectDestinationListDestination>? Destinations { get; set; }
}
