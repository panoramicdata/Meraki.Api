namespace Meraki.Api.Data;

/// <summary>
/// Splash image
/// </summary>
[DataContract]
public class SplashImage
{
	/// <summary>
	/// The extension of the image file.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "extension")]
	public string? Extension { get; set; }

	/// <summary>
	/// The MD5 value of the image file. Setting this to null will remove the image from the splash page.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "md5")]
	public string? Md5 { get; set; }
}
