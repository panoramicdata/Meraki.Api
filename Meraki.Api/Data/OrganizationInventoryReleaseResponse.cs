namespace Meraki.Api.Data;

/// <summary>
/// InventoryReleaseResponse
/// </summary>
[ApiAccessReadOnlyClass]
[DataContract]
public class OrganizationInventoryReleaseResponse
{
	/// <summary>
	/// Serials of the devices that should be released
	/// </summary>
	[DataMember(Name = "serials")]
	public List<string>? Serials { get; set; }
}
