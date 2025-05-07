using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Meraki.Api.Data;

/// <summary>
/// SecureConnectDestinationList
/// </summary>
[DataContract]
public class SecureConnectDestinationList
{
	/// <summary>
	/// The type of the destination list in the policy.
	/// Set 1 for DNS, 2 for web, and 4 for SAML Bypass.
	/// If the field is not specified, the default value is 1.
	/// default = 1, enum = [1, 2, 4]
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "bundleTypeId")]
	public SecureConnectDestinationListBundleType BundleTypeId { get; set; }

	/// <summary>
	/// The date and time when the destination list was created.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public DateTime CreatedAt { get; set; }

	/// <summary>
	/// The unique ID of the destination list.
	/// </summary>
	[ApiKey]
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public int Id { get; set; }

	/// <summary>
	/// The date and time when the destination list was modified.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "modifiedAt")]
	public DateTime modifiedAt { get; set; }

	/// <summary>
	/// The organization ID.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "organizationId")]
	public string OrganizationId { get; set; } = string.Empty;

	/// <summary>
	/// The third-party category ID of the destination list.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "thirdpartyCategoryId")]
	public int ThirdpartyCategoryId { get; set; }

	/// <summary>
	/// The type of access for the destination list. enum = ["allow", "block"]
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "access")]
	public SecureConnectDestinationListAccess Access { get; set; }

	/// <summary>
	/// The name of the destination list.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Specifies whether the destination list is a global destination list. There is only one default allow destination list and one default block destination list for an organization.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "isGlobal")]
	public bool IsGlobal { get; set; }

	/// <summary>
	/// Specifies whether MSP is the default.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "isMspDefault")]
	public bool IsMspDefault { get; set; }

	/// <summary>
	/// Specifies whether the destination list is marked for deletion.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "markedForDeletion")]
	public bool MarkedForDeletion { get; set; }

	/// <summary>
	/// The total number of each type of destination in the destination list. The fields in the meta object are optional.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "meta")]
	public SecureConnectDestinationListMeta Meta { get; set; }
}
