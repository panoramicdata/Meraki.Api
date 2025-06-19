namespace Meraki.Api.Data;

/// <summary>
/// Organizations Devices Controller Migration
/// </summary>
[DataContract]
public class OrganizationsDevicesControllerMigration
{
	/// <summary>
	/// The time at which a migration was created
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "createdAt")]
	public string CreatedAt { get; set; } = string.Empty;

	/// <summary>
	/// The time at which the device initiated migration
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "migratedAt")]
	public string MigratedAt { get; set; } = string.Empty;

	/// <summary>
	/// The device serial
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// The migration target destination. enum = ["wirelessController"]
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "target")]
	public string Target { get; set; } = string.Empty;
}
