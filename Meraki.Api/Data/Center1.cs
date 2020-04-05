using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The longitude and latitude of the center of your floor plan. If you want to change the geolocation data of your floor plan, either the &#39;center&#39; or two adjacent corners (e.g. &#39;topLeftCorner&#39; and &#39;bottomLeftCorner&#39;) must be specified. If &#39;center&#39; is specified, the floor plan is placed over that point with no rotation. If two adjacent corners are specified, the floor plan is rotated to line up with the two specified points. The aspect ratio of the floor plan&#39;s image is preserved regardless of which corners/center are specified. (This means if that more than two corners are specified, only two corners may be used to preserve the floor plan&#39;s aspect ratio.). No two points can have the same latitude, longitude pair.
	/// </summary>
	[DataContract]
	public partial class Center1
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
