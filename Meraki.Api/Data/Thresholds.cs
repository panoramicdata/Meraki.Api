using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Thresholds
	/// </summary>
	[DataContract]
	public class Thresholds
	{
		/// <summary>
		/// Type
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;

		/// <summary>
		/// By network
		/// </summary>
		[DataMember(Name = "byNetwork")]
		public List<ByNetworks> ByNetwork { get; set; } = new();
	}
}
