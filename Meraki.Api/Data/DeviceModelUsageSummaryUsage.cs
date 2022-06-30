namespace Meraki.Api.Data;

[DataContract]
public class DeviceModelUsageSummaryUsage
{
	/// <summary>
	/// Total
	/// </summary>
	[DataMember(Name = "total")]
	public int Total { get; set; }

	/// <summary>
	/// Average
	/// </summary>
	[DataMember(Name = "average")]
	public int Average { get; set; }
}
