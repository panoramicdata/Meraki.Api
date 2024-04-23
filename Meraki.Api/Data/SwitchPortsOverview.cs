namespace Meraki.Api.Data;

/// <summary>
/// Switch Ports Overview
/// </summary>
[DataContract]
public class SwitchPortsOverview
{
	/// <summary>
	/// The count data of all ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "counts")]
	public SwitchPortsOverviewCounts Counts { get; set; } = new();
}
