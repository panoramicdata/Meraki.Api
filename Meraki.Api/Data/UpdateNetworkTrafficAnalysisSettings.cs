using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkTrafficAnalysisSettings
	/// </summary>
	[DataContract]
	public partial class UpdateNetworkTrafficAnalysisSettings
	{
		/// <summary>
		/// Gets or Sets Mode
		/// </summary>
		[DataMember(Name = "mode", EmitDefaultValue = false)]
		public Mode3 Mode { get; set; }
		/// <summary>
		/// The list of items that make up the custom pie chart for traffic reporting.
		/// </summary>
		/// <value>The list of items that make up the custom pie chart for traffic reporting.</value>
		[DataMember(Name = "customPieChartItems", EmitDefaultValue = false)]
		public List<CustomPieChartItem> CustomPieChartItems { get; set; }
	}
}
