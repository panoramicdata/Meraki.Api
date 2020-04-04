using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A schedule object.
	/// </summary>
	[DataContract]
	public partial class DayPortSchedule
	{
		/// <summary>
		/// Whether the schedule is active (true) or inactive (false) during the time specified between &#39;from&#39; and &#39;to&#39;. Defaults to true.
		/// </summary>
		/// <value>Whether the schedule is active (true) or inactive (false) during the time specified between &#39;from&#39; and &#39;to&#39;. Defaults to true.</value>
		[DataMember(Name = "active", EmitDefaultValue = false)]
		public bool? Active { get; set; }

		/// <summary>
		/// The time, from &#39;00:00&#39; to &#39;24:00&#39;. Must be less than the time specified in &#39;to&#39;. Defaults to &#39;00:00&#39;. Only 30 minute increments are allowed.
		/// </summary>
		/// <value>The time, from &#39;00:00&#39; to &#39;24:00&#39;. Must be less than the time specified in &#39;to&#39;. Defaults to &#39;00:00&#39;. Only 30 minute increments are allowed.</value>
		[DataMember(Name = "from", EmitDefaultValue = false)]
		public string From { get; set; } = null!;

		/// <summary>
		/// The time, from &#39;00:00&#39; to &#39;24:00&#39;. Must be greater than the time specified in &#39;from&#39;. Defaults to &#39;24:00&#39;. Only 30 minute increments are allowed.
		/// </summary>
		/// <value>The time, from &#39;00:00&#39; to &#39;24:00&#39;. Must be greater than the time specified in &#39;from&#39;. Defaults to &#39;24:00&#39;. Only 30 minute increments are allowed.</value>
		[DataMember(Name = "to", EmitDefaultValue = false)]
		public string To { get; set; } = null!;
	}
}
