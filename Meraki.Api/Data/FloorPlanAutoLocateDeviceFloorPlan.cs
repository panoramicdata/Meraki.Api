namespace Meraki.Api.Data;

/// <summary>
/// Floor Plan Auto Locate Device Floor Plan
/// </summary>
[DataContract]
public class FloorPlansAutoLocateDeviceFloorPlan
{
	/// <summary>
	/// Floor plan ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Floor plan name - This property name is in line with the documentation despite not looking correct
	/// This property has also been added as 'name' to avoid expected deserialisation errors in the future.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Floor plan name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
