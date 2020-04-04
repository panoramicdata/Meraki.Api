using System;using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A change log entry
	/// </summary>
	[DataContract]
	public class ChangeLogEntry
	{
		/// <summary>
		/// The Timestamp
		/// </summary>
		[DataMember(Name = "ts")]
		public DateTime TimeStamp { get; set; }

		/// <summary>
		/// The admin name
		/// </summary>
		[DataMember(Name = "adminName")]
		public string AdminName { get; set; } = default!;

		/// <summary>
		/// The admin email address
		/// </summary>
		[DataMember(Name = "adminEmail")]
		public string AdminEmail { get; set; } = default!;

		/// <summary>
		/// The admin id
		/// </summary>
		[DataMember(Name = "adminId")]
		public string AdminId { get; set; } = default!;

		/// <summary>
		/// The page
		/// </summary>
		[DataMember(Name = "page")]
		public string Page { get; set; } = default!;

		/// <summary>
		/// The label
		/// </summary>
		[DataMember(Name = "label")]
		public string Label { get; set; } = default!;

		/// <summary>
		/// The old value
		/// </summary>
		[DataMember(Name = "oldValue")]
		public string OldValue { get; set; } = default!;

		/// <summary>
		/// The new value
		/// </summary>
		[DataMember(Name = "newValue")]
		public string NewValue { get; set; } = default!;

		public override string ToString() => Label;
	}
}