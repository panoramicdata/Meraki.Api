using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A reserved IP range
	/// </summary>
	[DataContract]
	public class ReservedIpRange
	{
		/// <summary>
		/// Start IP
		/// </summary>
		[DataMember(Name = "start")]
		public string Start { get; set; } = string.Empty;

		/// <summary>
		/// End IP
		/// </summary>
		[DataMember(Name = "end")]
		public string End { get; set; } = string.Empty;

		/// <summary>
		/// Comment
		/// </summary>
		[DataMember(Name = "comment")]
		public string Comment { get; set; } = string.Empty;
	}

}