using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Floor plan
	/// </summary>
	[DataContract]
	public class FloorPlan
	{
		/// <summary>
		/// Floor plan id
		/// </summary>
		[DataMember(Name = "floorPlanId")]
		public string FloorPlanId { get; set; } = string.Empty;

		/// <summary>
		/// Image URL
		/// </summary>
		[DataMember(Name = "imageUrl")]
		public string ImageUrl { get; set; } = string.Empty;

		/// <summary>
		/// Image URL expires at
		/// </summary>
		[DataMember(Name = "imageUrlExpiresAt")]
		public string ImageUrlExpiresAt { get; set; } = string.Empty;

		/// <summary>
		/// Image extension
		/// </summary>
		[DataMember(Name = "imageExtension")]
		public string ImageExtension { get; set; } = string.Empty;

		/// <summary>
		/// Image MD5
		/// </summary>
		[DataMember(Name = "imageMd5")]
		public string ImageMd5 { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Devices
		/// </summary>
		[DataMember(Name = "devices")]
		public List<Device> Devices { get; set; } = new();

		/// <summary>
		/// Width
		/// </summary>
		[DataMember(Name = "width")]
		public int Width { get; set; }

		/// <summary>
		/// Height
		/// </summary>
		[DataMember(Name = "height")]
		public int Height { get; set; }

		/// <summary>
		/// Center
		/// </summary>
		[DataMember(Name = "center")]
		public GeoLocation Center { get; set; } = new();

		/// <summary>
		/// Bottom left corner
		/// </summary>
		[DataMember(Name = "bottomLeftCorner")]
		public GeoLocation BottomLeftCorner { get; set; } = new();

		/// <summary>
		/// Bottom right corner
		/// </summary>
		[DataMember(Name = "bottomRightCorner")]
		public GeoLocation BottomRightCorner { get; set; } = new();

		/// <summary>
		/// Top left corner
		/// </summary>
		[DataMember(Name = "topLeftCorner")]
		public GeoLocation TopLeftCorner { get; set; } = new();

		/// <summary>
		/// Top right corner
		/// </summary>
		[DataMember(Name = "topRightCorner")]
		public GeoLocation TopRightCorner { get; set; } = new();
	}
}
