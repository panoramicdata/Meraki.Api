namespace Meraki.Api.Data;

/// <summary>
/// Switch Ports Overview Counts By Status Inactive By Media
/// </summary>
[DataContract]
public class SwitchPortsOverviewCountsByStatusInactiveByMedia
{
	/// <summary>
	/// The count data for inactive RJ45 ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "rj45")]
	public SwitchPortsOverviewCountsByStatusInactiveByMediaRj45 Rj45 { get; set; } = new();

	/// <summary>
	/// The count data for inactive SFP ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sfp")]
	public SwitchPortsOverviewCountsByStatusInactiveByMediaSfp Sfp { get; set; } = new();
}
