using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CustomPieChartItem
	/// </summary>
	[DataContract]
	public class CustomPieChartItem
	{
		/// <summary>
		/// The name of the custom pie chart item.
		/// </summary>
		/// <value>The name of the custom pie chart item.</value>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type")]
		public Type8 Type { get; set; } = new();
		/// <summary>
		/// The value of the custom pie chart item. Valid syntax depends on the signature type of the chart item     (see sample request/response for more details).
		/// </summary>
		/// <value>The value of the custom pie chart item. Valid syntax depends on the signature type of the chart item     (see sample request/response for more details).</value>
		[DataMember(Name = "value")]
		public string Value { get; set; } = string.Empty;
	}
}
