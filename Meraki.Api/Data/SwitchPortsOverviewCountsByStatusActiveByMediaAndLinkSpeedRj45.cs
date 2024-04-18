namespace Meraki.Api.Data;

/// <summary>
/// Switch Ports Overview Counts By Status Active By Media Link And Speed RJ45
/// </summary>
[DataContract]
public class SwitchPortsOverviewCountsByStatusActiveByMediaAndLinkSpeedRj45
{
	/// <summary>
	/// The number of active 10 Mbps RJ45 ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "10")]
	public int Rj4510 { get; set; }

	/// <summary>
	/// The number of active 100 Mbps RJ45 ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "100")]
	public int Rj45100 { get; set; }

	/// <summary>
	/// The number of active 1 Gbps RJ45 ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "1000")]
	public int Rj451000 { get; set; }

	/// <summary>
	/// The number of active 10 Gbps RJ45 ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "10000")]
	public int Rj4510000 { get; set; }

	/// <summary>
	/// The number of active 2 Gbps RJ45 ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "2500")]
	public int Rj452500 { get; set; }

	/// <summary>
	/// The number of active 5 Gbps RJ45 ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "5000")]
	public int Rj455000 { get; set; }

	/// <summary>
	/// The total number of active RJ45 ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}
