using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The longitude and latitude of the bottom left corner of your floor plan.
	/// </summary>
	[DataContract]
	public partial class BottomLeftCorner
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
