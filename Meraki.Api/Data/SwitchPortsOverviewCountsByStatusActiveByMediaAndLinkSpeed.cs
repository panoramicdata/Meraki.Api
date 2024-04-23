namespace Meraki.Api.Data;

/// <summary>
/// Switch Ports Overview Counts By Status Active By Media And Link Speed
/// </summary>
[DataContract]
public class SwitchPortsOverviewCountsByStatusActiveByMediaAndLinkSpeed
{
	/// <summary>
	/// The count data for RJ45 ports, indexed by speed in Mb
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "rj45")]
	public SwitchPortsOverviewCountsByStatusActiveByMediaAndLinkSpeedRj45 Rj45 { get; set; } = new();

	/// <summary>
	/// The count data for SFP ports, indexed by speed in Mb
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sfp")]
	public SwitchPortsOverviewCountsByStatusActiveByMediaAndLinkSpeedSfp Sfp { get; set; } = new();
}
