namespace Meraki.Api.Data;

/// <summary>
/// Sensor Command Createdby
/// </summary>
[DataContract]
public class SensorCommandCreatedby
{
	/// <summary>
	/// ID of the admin
	/// </summary>
	[DataMember(Name = "adminId")]
	public string AdminId { get; set; } = string.Empty;

	/// <summary>
	/// Email of the admin
	/// </summary>
	[DataMember(Name = "email")]
	public string Email { get; set; } = string.Empty;

	/// <summary>
	/// Name of the admin
	/// </summary>
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
