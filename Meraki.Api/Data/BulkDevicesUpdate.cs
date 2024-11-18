namespace Meraki.Api.Data;

/// <summary>
/// Updating device details (currently only used for Catalyst devices)
/// </summary>
[DataContract]
public class BulkDevicesUpdate
{
	/// <summary>
	/// A list of serials of devices to update
	/// </summary>
	[ApiAccess(ApiAccess.Update)]
	[DataMember(Name = "serials")]
	public List<string> Serials { get; set; } = [];

	/// <summary>
	/// An array of details
	/// </summary>
	[ApiAccess(ApiAccess.Update)]
	[DataMember(Name = "details")]
	public List<BulkDevicesUpdateDetail> Details { get; set; } = [];
}
