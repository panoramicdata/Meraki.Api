namespace Meraki.Api.Data;

/// <summary>
/// InventoryClaimResponse
/// </summary>
[DataContract]
public class OrganizationInventoryClaimResponse
{
	/// <summary>
	/// The numbers of the orders that should be claimed
	/// </summary>
	/// <value>The numbers of the orders that should be claimed</value>
	[DataMember(Name = "orders")]
	public List<string>? Orders { get; set; }

	/// <summary>
	/// The serials of the devices that should be claimed
	/// </summary>
	/// <value>The serials of the devices that should be claimed</value>
	[DataMember(Name = "serials")]
	public List<string>? Serials { get; set; }

	/// <summary>
	/// The licenses that should be claimed
	/// </summary>
	/// <value>The licenses that should be claimed</value>
	[DataMember(Name = "licenses")]
	public List<License>? Licenses { get; set; }
}
