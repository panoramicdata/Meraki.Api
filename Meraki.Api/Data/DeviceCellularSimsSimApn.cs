namespace Meraki.Api.Data;

/// <summary>
/// Device Cellular Sims
/// </summary>
[DataContract]
public class DeviceCellularSimsSimApn
{
	/// <summary>
	/// Name
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Is Primary
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "allowedIpTypes")]
	public List<string> AllowedIpTypes { get; set; } = new();

	/// <summary>
	/// A list of Sims
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "authentication")]
	public DeviceCellularSimsSimApnAuthentication? Authentication { get; set; }
}
