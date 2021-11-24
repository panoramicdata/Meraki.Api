namespace Meraki.Api.Data;

/// <summary>
/// Subnet
/// </summary>
[DataContract]
public class CellularGatewaySubnet
{
	/// <summary>
	/// Serial
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "serial")]
	public string Serial { get; set; } = string.Empty;

	/// <summary>
	/// Name
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Appliance ip
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "applianceIp")]
	public string ApplianceIp { get; set; } = string.Empty;

	/// <summary>
	/// Subnet
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "subnet")]
	public string Subnet { get; set; } = string.Empty;
}
