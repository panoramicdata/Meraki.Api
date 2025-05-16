namespace Meraki.Api.Data;

/// <summary>
/// Device Network
/// </summary>
[DataContract]
public class OrganizationDeviceBootHistoryItemNetwork
{
	/// <summary>
	/// API-formatted network ID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "id")]
	public string Id { get; set; } = string.Empty;
}