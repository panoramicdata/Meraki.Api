using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateNetworkFloorPlan
	/// </summary>
	[DataContract]
	public partial class CreateNetworkFloorPlan
	{
		/// <summary>
		/// The name of your floor plan.
		/// </summary>
		/// <value>The name of your floor plan.</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }
		/// <summary>
		/// Gets or Sets Center
		/// </summary>
		[DataMember(Name = "center", EmitDefaultValue = false)]
		public Center Center { get; set; }
		/// <summary>
		/// Gets or Sets BottomLeftCorner
		/// </summary>
		[DataMember(Name = "bottomLeftCorner", EmitDefaultValue = false)]
		public BottomLeftCorner BottomLeftCorner { get; set; }
		/// <summary>
		/// Gets or Sets BottomRightCorner
		/// </summary>
		[DataMember(Name = "bottomRightCorner", EmitDefaultValue = false)]
		public BottomRightCorner BottomRightCorner { get; set; }
		/// <summary>
		/// Gets or Sets TopLeftCorner
		/// </summary>
		[DataMember(Name = "topLeftCorner", EmitDefaultValue = false)]
		public TopLeftCorner TopLeftCorner { get; set; }
		/// <summary>
		/// Gets or Sets TopRightCorner
		/// </summary>
		[DataMember(Name = "topRightCorner", EmitDefaultValue = false)]
		public TopRightCorner TopRightCorner { get; set; }
		/// <summary>
		/// The file contents (a base 64 encoded string) of your image. Supported formats are PNG, GIF, and JPG. Note that all images are saved as PNG files, regardless of the format they are uploaded in.
		/// </summary>
		/// <value>The file contents (a base 64 encoded string) of your image. Supported formats are PNG, GIF, and JPG. Note that all images are saved as PNG files, regardless of the format they are uploaded in.</value>
		[DataMember(Name = "imageContents", EmitDefaultValue = false)]
		public string ImageContents { get; set; }
	}
}
