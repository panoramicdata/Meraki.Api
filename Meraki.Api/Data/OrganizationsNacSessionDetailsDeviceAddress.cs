namespace Meraki.Api.Data;

/// <summary>
/// Device IP Address Detail
/// </summary>
[DataContract]
public class OrganizationsNacSessionDetailsDeviceAddress
{
	/// <summary>
	/// Device IP Address
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "address")]
	public string Address { get; set; } = string.Empty;

	/// <summary>
	/// Device IP Address Protocol
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "protocol")]
	public string Protocol { get; set; } = string.Empty;
}