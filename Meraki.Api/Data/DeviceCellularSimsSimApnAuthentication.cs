namespace Meraki.Api.Data;

/// <summary>
/// Device Cellular Sims Apn Authentication
/// </summary>
[DataContract]
public class DeviceCellularSimsSimApnAuthentication
{
	/// <summary>
	/// Password
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "password")]
	public string? Passsword { get; set; }

	/// <summary>
	/// Type
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "type")]
	public string? Type { get; set; }

	/// <summary>
	/// Username
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "username")]
	public string? Username { get; set; }
}
