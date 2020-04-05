using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The longitude and latitude of the top left corner of your floor plan.
	/// </summary>
	[DataContract]
	public partial class TopLeftCorner
	{
		/// <summary>
		/// Latitude
		/// </summary>
		/// <value>Latitude</value>
		[DataMember(Name = "lat", EmitDefaultValue = false)]
		public double? Lat { get; set; }
		/// <summary>
		/// Longitude
		/// </summary>
		/// <value>Longitude</value>
		[DataMember(Name = "lng", EmitDefaultValue = false)]
		public double? Lng { get; set; }
	}
}
