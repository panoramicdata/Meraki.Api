namespace Meraki.Api.Data;

/// <summary>
/// Bulk Updated Devices
/// </summary>
[DataContract]
public class BulkUpdatedDevices
{
	/// <summary>
	/// A list of serials of devices updated
	/// </summary>
	[ApiAccess(ApiAccess.Update)]
	[DataMember(Name = "serials")]
	public List<string> Serials { get; set; } = [];

}
