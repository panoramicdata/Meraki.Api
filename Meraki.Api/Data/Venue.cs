using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Venue
	/// </summary>
	[DataContract]
	public class Venue
	{
		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Type
		/// </summary>
		[DataMember(Name = "type")]
		public string Type { get; set; } = string.Empty;
	}
}
