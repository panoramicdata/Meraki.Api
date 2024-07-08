namespace Meraki.Api.Data;

/// <summary>
/// Quality and resolution for MV63M camera models.
/// </summary>
[DataContract]
public class MV63M
{
	/// <summary>
	/// Gets or Sets Quality
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "quality")]
	public StandardEnhancedHighQuality Quality { get; set; }

	/// <summary>
	/// Gets or Sets Resolution
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "resolution")]
	public MV63MResolution Resolution { get; set; }
}
