namespace Meraki.Api.Data;

/// <summary>
/// Switch Ports Overview Counts By Status Active By Media Link And Speed Sfp
/// </summary>
[DataContract]
public class SwitchPortsOverviewCountsByStatusActiveByMediaAndLinkSpeedSfp
{
	/// <summary>
	/// The number of active 100 Mbps SFP ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "100")]
	public int Sfp100 { get; set; }

	/// <summary>
	/// The number of active 1 Gbps SFP ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "1000")]
	public int Sfp1000 { get; set; }

	/// <summary>
	/// The number of active 10 Gbps SFP ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "10000")]
	public int Sfp10000 { get; set; }

	/// <summary>
	/// The number of active 100 Gbps SFP ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "100000")]
	public int Sfp100000 { get; set; }

	/// <summary>
	/// The number of active 20 Gbps SFP ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "20000")]
	public int Sfp20000 { get; set; }

	/// <summary>
	/// The number of active 25 Gbps SFP ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "25000")]
	public int Sfp25000 { get; set; }

	/// <summary>
	/// The number of active 40 Gbps SFP ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "40000")]
	public int Sfp40000 { get; set; }

	/// <summary>
	/// The number of active 50 Gbps SFP ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "50000")]
	public int Sfp50000 { get; set; }

	/// <summary>
	/// The total number of active SFP ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}
