using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Zone data
	/// </summary>
	[DataContract]
	public class ZoneData
	{
		/// <summary>
		/// Person
		/// </summary>
		public int Person { get; set; }
	}
}
