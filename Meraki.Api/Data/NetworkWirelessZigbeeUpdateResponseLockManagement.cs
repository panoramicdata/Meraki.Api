namespace Meraki.Api.Data;

/// <summary>
/// Lock Management Details
/// </summary>
[DataContract]
public class NetworkWirelessZigbeeUpdateResponseLockManagement
{
	/// <summary>
	/// Host address of the system
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	/// Zigbee connectivity status of the management software
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;

	/// <summary>
	/// Login User credentials
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "username")]
	public string Username { get; set; } = string.Empty;
}