namespace Meraki.Api.Data;

/// <summary>
/// Organizations Devices Controller Migration Create Request
/// </summary>
[DataContract]
public class OrganizationsDevicesControllerMigrationCreateRequest
{
	/// <summary>
	/// The controller or management mode to which the devices will be migrated. enum = ["wirelessController"]
	/// </summary>
	[DataMember(Name = "target")]
	public string Target { get; set; } = string.Empty;

	/// <summary>
	/// A list of Meraki Serials to migrate
	/// </summary>
	[DataMember(Name = "serials")]
	public List<string> Serials { get; set; } = [];
}
