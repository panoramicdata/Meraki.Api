namespace Meraki.Api.Data;

/// <summary>
/// Device Appliance Prefixes Delegated Item
/// </summary>
[DataContract]
public class DeviceAppliancePrefixesDelegatedItem
{
	/// <summary>
	/// Origin
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "origin")]
	public DeviceAppliancePrefixesDelegatedItemOrigin Origin { get; set; } = new();

	/// <summary>
	/// Prefix
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "prefix")]
	public string Prefix { get; set; } = string.Empty;

	/// <summary>
	/// Counts
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public DeviceAppliancePrefixesDelegatedItemCounts Counts { get; set; } = new();

	/// <summary>
	/// Method
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "method")]
	public string Method { get; set; } = string.Empty;

	/// <summary>
	/// Description
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "description")]
	public string Description { get; set; } = string.Empty;

	/// <summary>
	/// Is Preferred
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "isPreferred")]
	public bool IsPreferred { get; set; }

	/// <summary>
	/// Expires At
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "expiresAt")]
	public string ExpiresAt { get; set; } = string.Empty;
}
