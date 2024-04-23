namespace Meraki.Api.Data;

/// <summary>
/// Switch Ports Overview Counts By Status Inactive By Media RJ45
/// </summary>
[DataContract]
public class SwitchPortsOverviewCountsByStatusInactiveByMediaRj45
{
	/// <summary>
	/// The total number of inactive RJ45 ports
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "total")]
	public int Total { get; set; }
}
