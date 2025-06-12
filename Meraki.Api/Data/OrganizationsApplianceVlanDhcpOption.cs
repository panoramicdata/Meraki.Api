namespace Meraki.Api.Data;

/// <summary>
/// DHCP options that will be included in DHCP responses.
/// </summary>
[DataContract]
public class OrganizationsApplianceVlanDhcpOption
{
	/// <summary>
	/// The code for the DHCP option. This should be an integer between 2 and 254.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "code")]
	public string Code { get; set; } = string.Empty;

	/// <summary>
	/// 
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "type")]
	public DhcpOptionType Type { get; set; }

	/// <summary>
	/// The value for the DHCP option
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "value")]
	public string Value { get; set; } = string.Empty;
}