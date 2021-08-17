using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Value
	/// </summary>
	[DataContract]
	public partial class TrafficFiltersValue
	{
		/// <summary>
		/// Protocol
		/// </summary>
		[DataMember(Name = "protocol")]
		public string? Protocol { get; set; }

		/// <summary>
		/// Source
		/// </summary>
		[DataMember(Name = "source")]
		public ValueSource? Source { get; set; }

		/// <summary>
		/// Destination
		/// </summary>
		[DataMember(Name = "destination")]
		public ValueSource? Destination { get; set; }

		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public string? Id { get; set; }
	}
}
