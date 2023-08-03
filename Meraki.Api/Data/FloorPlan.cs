namespace Meraki.Api.Data;

/// <summary>
/// Floor plan
/// </summary>
[DataContract]
public class FloorPlan
{
	/// <summary>
	/// Floor plan id
	/// </summary>
	[ApiKey]
	[DataMember(Name = "floorPlanId")]
	public string FloorPlanId { get; set; } = string.Empty;

	/// <summary>
	/// Image URL
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "imageUrl")]
	public string? ImageUrl { get; set; }

	/// <summary>
	/// Image URL expires at
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "imageUrlExpiresAt")]
	public DateTime? ImageUrlExpiresAt { get; set; }

	/// <summary>
	/// Image extension
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "imageExtension")]
	public string? ImageExtension { get; set; }

	/// <summary>
	/// Image MD5
	/// We set this as a read update as we want to be able to store this even though we can't send it back
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "imageMd5")]
	public string? ImageMd5 { get; set; }

	/// <summary>
	/// Name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }

	/// <summary>
	/// Devices
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "devices")]
	public List<FloorplanDevice>? Devices { get; set; }

	/// <summary>
	/// Width
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "width")]
	public double? Width { get; set; }

	/// <summary>
	/// Height
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "height")]
	public double? Height { get; set; }

	/// <summary>
	/// The longitude and latitude of the center of your floor plan. If you want to change the geolocation data of your floor plan,
	/// either the 'center' or two adjacent corners (e.g. 'topLeftCorner' and 'bottomLeftCorner') must be specified.
	/// If 'center' is specified, the floor plan is placed over that point with no rotation.
	/// If two adjacent corners are specified, the floor plan is rotated to line up with the two specified points.
	/// The aspect ratio of the floor plan's image is preserved regardless of which corners/center are specified.
	/// (This means if that more than two corners are specified, only two corners may be used to preserve the floor plan's aspect ratio.).
	/// No two points can have the same latitude, longitude pair.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "center")]
	public GeoLocation? Center { get; set; }

	/// <summary>
	/// The longitude and latitude of the bottom left corner of your floor plan.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "bottomLeftCorner")]
	public GeoLocation? BottomLeftCorner { get; set; }

	/// <summary>
	/// The longitude and latitude of the bottom right corner of your floor plan.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "bottomRightCorner")]
	public GeoLocation? BottomRightCorner { get; set; }

	/// <summary>
	/// The longitude and latitude of the top left corner of your floor plan.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "topLeftCorner")]
	public GeoLocation? TopLeftCorner { get; set; }

	/// <summary>
	/// The longitude and latitude of the top right corner of your floor plan.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "topRightCorner")]
	public GeoLocation? TopRightCorner { get; set; }
}
