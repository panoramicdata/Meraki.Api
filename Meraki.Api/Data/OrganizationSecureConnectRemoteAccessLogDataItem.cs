namespace Meraki.Api.Data;

/// <summary>
/// List the events logged by remote access.
/// </summary>
[DataContract]
public class OrganizationSecureConnectRemoteAccessLogDataItem
{
	/// <summary>
	/// Connected timestamp
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "connecttimestamp")]
	public int ConnectTimestamp { get; set; }

	/// <summary>
	/// Timestamp
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "timestamp")]
	public int Timestamp { get; set; }

	/// <summary>
	/// List of AnyConnect Roaming Security module versions.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "anyconnectversion")]
	public string AnyConnectVersion { get; set; } = string.Empty;

	/// <summary>
	/// Type of connection event.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "connectionevent")]
	public string ConnectionEvent { get; set; } = string.Empty;

	/// <summary>
	/// Ip address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "internalip")]
	public string InternalIP { get; set; } = string.Empty;

	/// <summary>
	/// List of OS versions
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "osversion")]
	public string OsVersion { get; set; } = string.Empty;

	/// <summary>
	/// Connected reason
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "reason")]
	public string Reason { get; set; } = string.Empty;

	/// <summary>
	/// Reasons for connection failure
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "failedReasons")]
	public List<string> FailedReasons { get; set; } = [];

	/// <summary>
	/// List of identites details
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "identities")]
	public List<OrganizationSecureConnectRemoteAccessLogDataItemIdentity> Identities { get; set; } = [];
}
