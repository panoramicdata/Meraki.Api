namespace Meraki.Api.Data;

/// <summary>
/// Switch Ports Overview Counts By Status Inactive By Media Sfp
/// </summary>
[DataContract]
public class SwitchPortsOverviewCountsByStatusInactiveByMediaSfp
{
	/// <summary>
	/// The total number of inactive SFP ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}
