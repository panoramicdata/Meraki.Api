using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkTrafficAnalysisSettings
	/// </summary>
	[DataContract]
	public class TrafficAnalysisSettingsUpdateRequest
	{
		/// <summary>
		/// Gets or Sets Mode
		/// </summary>
		[DataMember(Name = "mode", EmitDefaultValue = false)]
		public TrafficAnalysisMode Mode { get; set; } = new();
		/// <summary>
		/// The list of items that make up the custom pie chart for traffic reporting.
		/// </summary>
		/// <value>The list of items that make up the custom pie chart for traffic reporting.</value>
		[DataMember(Name = "customPieChartItems", EmitDefaultValue = false)]
		public List<CustomPieChartItem> CustomPieChartItems { get; set; } = new();
	}
}
