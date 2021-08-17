using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Zones
	/// </summary>
	[DataContract]
	public class Zones
	{
		/// <summary>
		/// 0
		/// </summary>
		[DataMember(Name = "0")]
		public ZoneData Zone0 { get; set; } = new();
	}
}
