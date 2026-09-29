namespace Meraki.Api.Data;

/// <summary>
/// The current user's network-level permissions
/// </summary>
[DataContract]
public class NetworkStatusSummaryPermissions
{
	/// <summary>
	/// Whether the current user can write to the network
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "canWrite")]
	public bool? CanWrite { get; set; }
}
