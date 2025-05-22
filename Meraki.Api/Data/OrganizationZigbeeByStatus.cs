namespace Meraki.Api.Data;

/// <summary>
/// Status Stats
/// </summary>
[DataContract]
public class OrganizationZigbeeByStatus
{
	/// <summary>
	/// Dormant Door locks
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "dormant")]
	public int Dormant { get; set; }

	/// <summary>
	/// Offline Door locks
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "offline")]
	public int Offline { get; set; }

	/// <summary>
	/// Online Door locks
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "online")]
	public int Online { get; set; }
}