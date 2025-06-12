namespace Meraki.Api.Data;

/// <summary>
/// The triggered sensor alert profile
/// </summary>
[DataContract]
public class OrganizationsSensorAlertProfile
{
	/// <summary>
	/// ID of the sensor alert profile.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;

	/// <summary>
	/// Name of the sensor alert profile.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Triggered alert condition for the sensor alert.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "condition")]
	public OrganizationsSensorAlertProfileCondition Condition { get; set; } = new();
}
