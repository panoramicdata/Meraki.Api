namespace Meraki.Api.Data;

/// <summary>
/// Region
/// </summary>
[DataContract]
public class OrganizationSecureConnectRegionsDataItem
{
	/// <summary>
	/// Region ID, may not be unique in result set and might be null for a CNHE region that has not been deployed yet
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Region name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The region's type
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public string Type { get; set; } = string.Empty;

	/// <summary>
	/// The datacenter pair for the region
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dcPair")]
	public List<string> DcPair { get; set; } = [];
}