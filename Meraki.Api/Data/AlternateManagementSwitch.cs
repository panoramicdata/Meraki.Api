namespace Meraki.Api.Data;

/// <summary>
/// Array of switch serial number and IP assignment. If parameter is present, it cannot have empty body. Note: switches parameter is not applicable for template networks, in other words, do not put 'switches' in the body when updating template networks. Also, an empty 'switches' array will remove all previous assignments
/// </summary>
[DataContract]
public class AlternateManagementSwitch
{
	/// <summary>
	/// Switch alternative management IP. To remove a prior IP setting, provide an empty string
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "alternateManagementIp")]
	public string? AlternateManagementIp { get; set; }

	/// <summary>
	/// Switch serial number
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "serial")]
	public string? Serial { get; set; }

	/// <summary>
	/// Subnet Mask
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "subnetMask")]
	public string? SubnetMask { get; set; }

	/// <summary>
	/// Gateway
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "gateway")]
	public string? Gateway { get; set; }


}
