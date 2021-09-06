using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateNetworkFloorPlan
	/// </summary>
	[DataContract]
	public class FloorPlanCreationRequest
	{
		/// <summary>
		/// The name of your floor plan.
		/// </summary>
		/// <value>The name of your floor plan.</value>
		[DataMember(Name = "name")]
		public string Name { get; set; } = null!;

		/// <summary>
		/// Gets or Sets Center
		/// </summary>
		[DataMember(Name = "center")]
		public GeoLocation Center { get; set; } = null!;

		/// <summary>
		/// Gets or Sets BottomLeftCorner
		/// </summary>
		[DataMember(Name = "bottomLeftCorner")]
		public GeoLocation BottomLeftCorner { get; set; } = null!;

		/// <summary>
		/// Gets or Sets BottomRightCorner
		/// </summary>
		[DataMember(Name = "bottomRightCorner")]
		public GeoLocation BottomRightCorner { get; set; } = null!;

		/// <summary>
		/// Gets or Sets TopLeftCorner
		/// </summary>
		[DataMember(Name = "topLeftCorner")]
		public GeoLocation TopLeftCorner { get; set; } = null!;

		/// <summary>
		/// Gets or Sets TopRightCorner
		/// </summary>
		[DataMember(Name = "topRightCorner")]
		public GeoLocation TopRightCorner { get; set; } = null!;

		/// <summary>
		/// The file contents (a base 64 encoded string) of your image. Supported formats are PNG, GIF, and JPG. Note that all images are saved as PNG files, regardless of the format they are uploaded in.
		/// </summary>
		/// <value>The file contents (a base 64 encoded string) of your image. Supported formats are PNG, GIF, and JPG. Note that all images are saved as PNG files, regardless of the format they are uploaded in.</value>
		[DataMember(Name = "imageContents")]
		public string ImageContents { get; set; } = null!;
	}
}
