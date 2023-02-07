namespace Meraki.Api.Data;

/// <summary>
/// Properties describing the custom logo attached to the branding policy.
/// </summary>
[DataContract]
public class BrandingPolicyCustomLogo
{
	/// <summary>
	/// The file contents (a base 64 encoded string) of your new logo.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "contents")]
	public string? Contents { get; set; }

	/// <summary>
	/// The format of the encoded contents. Supported formats are 'png', 'gif', and jpg'. Note that all images are saved as PNG files, regardless of the format they are uploaded in.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "format")]
	public string? Format { get; set; }

	/// <summary>
	/// Whether or not there is a custom logo enabled.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// Properties for setting the image.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "image")]
	public object? Image { get; set; }
}
