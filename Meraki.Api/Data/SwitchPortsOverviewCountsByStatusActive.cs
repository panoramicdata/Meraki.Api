namespace Meraki.Api.Data;

/// <summary>
/// Switch Ports Overview Counts By Status Active
/// </summary>
[DataContract]
public class SwitchPortsOverviewCountsByStatusActive
{
	/// <summary>
	/// The count data for active ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }

	/// <summary>
	/// The active count data, indexed by media type (RJ45 or SFP)
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "byMediaAndLinkSpeed")]
	public SwitchPortsOverviewCountsByStatusActiveByMediaAndLinkSpeed ByMediaAndLinkSpeed { get; set; } = new();
}
