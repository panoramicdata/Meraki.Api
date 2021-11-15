using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Splash image
/// </summary>
[DataContract]
public class SplashImage
{
	/// <summary>
	/// Extension
	/// </summary>
	[DataMember(Name = "extension")]
	public string Extension { get; set; } = string.Empty;

	/// <summary>
	/// Md5
	/// </summary>
	[DataMember(Name = "md5")]
	public string Md5 { get; set; } = string.Empty;
}
