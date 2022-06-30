namespace Meraki.Api.Data;

/// <summary>
/// The EoGRE concentrator's settings
/// </summary>
public class GreConcentrator
{
	/// <summary>
	/// The EoGRE concentrator's IP or FQDN. This param is required when ipAssignmentMode is 'Ethernet over GRE'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "host")]
	public string Host { get; set; } = string.Empty;
}