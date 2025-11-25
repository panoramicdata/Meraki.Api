namespace Meraki.Api.Data;

/// <summary>
/// Push topic reference for profiles
/// </summary>
[DataContract]
public class PushTopicReference
{
	/// <summary>
	/// The topic ID (e.g., organizationDevicesAvailabilitiesChangeHistory, organizationConfigurationChanges)
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "id")]
	public string? Id { get; set; }
}
