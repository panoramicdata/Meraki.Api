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
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "floorPlanId")]
	public string FloorPlanId { get; set; } = string.Empty;

	/// <summary>
	/// Image URL
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "imageUrl")]
	public string ImageUrl { get; set; } = string.Empty;

	/// <summary>
	/// Image URL expires at
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "imageUrlExpiresAt")]
	public DateTime ImageUrlExpiresAt { get; set; }

	/// <summary>
	/// Image extension
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "imageExtension")]
	public string ImageExtension { get; set; } = string.Empty;

	/// <summary>
	/// Image MD5
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "imageMd5")]
	public string ImageMd5 { get; set; } = string.Empty;

	/// <summary>
	/// Name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Devices
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "devices")]
	public List<Device> Devices { get; set; } = new();

	/// <summary>
	/// Width
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "width")]
	public double Width { get; set; }

	/// <summary>
	/// Height
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "height")]
	public double Height { get; set; }

	/// <summary>
	/// Center
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "center")]
	public GeoLocation Center { get; set; } = new();

	/// <summary>
	/// Bottom left corner
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "bottomLeftCorner")]
	public GeoLocation BottomLeftCorner { get; set; } = new();

	/// <summary>
	/// Bottom right corner
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "bottomRightCorner")]
	public GeoLocation BottomRightCorner { get; set; } = new();

	/// <summary>
	/// Top left corner
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "topLeftCorner")]
	public GeoLocation TopLeftCorner { get; set; } = new();

	/// <summary>
	/// Top right corner
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "topRightCorner")]
	public GeoLocation TopRightCorner { get; set; } = new();
}
