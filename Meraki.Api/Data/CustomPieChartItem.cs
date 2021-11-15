namespace Meraki.Api.Data;

/// <summary>
/// CustomPieChartItem
/// </summary>
[DataContract]
public class CustomPieChartItem
{
	/// <summary>
	/// The name of the custom pie chart item.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// The signature type for the custom pie chart item. Can be one of 'host', 'port' or 'ipRange
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "type")]
	public PieChartItemType Type { get; set; }
	/// <summary>
	/// The value of the custom pie chart item. Valid syntax depends on the signature type of the chart item     (see sample request/response for more details).
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "value")]
	public string Value { get; set; } = string.Empty;
}
