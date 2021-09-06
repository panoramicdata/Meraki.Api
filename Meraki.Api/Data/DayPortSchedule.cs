using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A schedule object.
	/// </summary>
	[DataContract]
	public class DayPortSchedule
	{
		/// <summary>
		/// Whether the schedule is active (true) or inactive (false) during the time specified between 'from' and 'to'. Defaults to true.
		/// </summary>
		/// <value>Whether the schedule is active (true) or inactive (false) during the time specified between from and to. Defaults to true.</value>
		[DataMember(Name = "active", EmitDefaultValue = false)]
		public bool Active { get; set; } = true;

		/// <summary>
		/// The time, from 00:00 to 24:00. Must be less than the time specified in to. Defaults to 00:00. Only 30 minute increments are allowed.
		/// </summary>
		/// <value>The time, from 00:00 to 24:00. Must be less than the time specified in to. Defaults to 00:00. Only 30 minute increments are allowed.</value>
		[DataMember(Name = "from", EmitDefaultValue = false)]
		public string From { get; set; } = "00:00";

		/// <summary>
		/// The time, from 00:00 to 24:00. Must be greater than the time specified in from. Defaults to 24:00. Only 30 minute increments are allowed.
		/// </summary>
		/// <value>The time, from 00:00 to 24:00. Must be greater than the time specified in from. Defaults to 24:00. Only 30 minute increments are allowed.</value>
		[DataMember(Name = "to", EmitDefaultValue = false)]
		public string To { get; set; } = "24:00";
	}
}
