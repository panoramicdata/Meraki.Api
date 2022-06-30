namespace Meraki.Api.Data;

[DataContract]
public class ClientOverviewUsage
{
	/// <summary>
	/// Overall
	/// </summary>
	[DataMember(Name = "overall")]
	public ClientOverviewUsageOverall Overall { get; set; } = new();

	/// <summary>
	/// Average
	/// </summary>
	[DataMember(Name = "average")]
	public int Average { get; set; }
}
