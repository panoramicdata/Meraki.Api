namespace Meraki.Api.Data;

/// <summary>
/// Push API Topic
/// </summary>
[DataContract]
public class PushTopic
{
	/// <summary>
	/// The topic ID (e.g., organizationDevicesAvailabilitiesChangeHistory, organizationConfigurationChanges)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }

	/// <summary>
	/// The topic name
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// The topic description
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "description")]
	public string? Description { get; set; }
}
