namespace Meraki.Api.Data;

/// <summary>
/// Login Credentials of on-premises lock management
/// </summary>
[DataContract]
public class NetworkWirelessZigbeeUpdateRequestLockManagement
{
	/// <summary>
	/// Host Address
	/// </summary>
	[DataMember(Name = "address")]
	public string? Address { get; set; }

	/// <summary>
	/// Password
	/// </summary>
	[DataMember(Name = "password")]
	public string? Password { get; set; }

	/// <summary>
	/// Username
	/// </summary>
	[DataMember(Name = "username")]
	public string? Username { get; set; }
}