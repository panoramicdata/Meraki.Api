using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Traffic filters
	/// </summary>
	[DataContract]
	public partial class TrafficFilters
	{
		/// <summary>
		/// Type
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;

		/// <summary>
		/// Value
		/// </summary>
		[DataMember(Name = "value")]
		public TrafficFiltersValue Value { get; set; } = new();
	}
}
