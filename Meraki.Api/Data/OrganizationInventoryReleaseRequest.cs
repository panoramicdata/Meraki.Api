namespace Meraki.Api.Data;

/// <summary>
/// InventoryReleaseRequest
/// </summary>
[DataContract]
public class OrganizationInventoryReleaseRequest
{
	/// <summary>
	/// Serials of the devices that should be released
	/// </summary>
	/// <value>Serials of the devices that should be released</value>
	[DataMember(Name = "serials")]
	public List<string> Serials { get; set; } = [];
}
