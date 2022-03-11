namespace Meraki.Api.Data;

/// <summary>
/// InventoryReleaseResponse
/// </summary>
[DataContract]
public class OrganizationInventoryReleaseResponse
{
	/// <summary>
	/// Serials of the devices that should be released
	/// </summary>
	/// <value>Serials of the devices that should be released</value>
	[DataMember(Name = "serials")]
	public List<string>? Serials { get; set; }
}
