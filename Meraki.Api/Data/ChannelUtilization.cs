using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Channel utilization
	/// </summary>
	[DataContract]
	public class ChannelUtilization
	{
		/// <summary>
		/// Serial
		/// </summary>
		[DataMember(Name = "serial")]
		public string Serial { get; set; } = string.Empty;

		/// <summary>
		/// Model
		/// </summary>
		[DataMember(Name = "model")]
		public string Model { get; set; } = string.Empty;

		/// <summary>
		/// Tags
		/// </summary>
		[DataMember(Name = "tags")]
		public List<string> Tags { get; set; } = new();

		/// <summary>
		/// Wifi0
		/// </summary>
		[DataMember(Name = "wifi0")]
		public List<Wifi> Wifi0 { get; set; } = new();

		/// <summary>
		/// Wifi1
		/// </summary>
		[DataMember(Name = "wifi1")]
		public List<Wifi> Wifi1 { get; set; } = new();
	}
}
