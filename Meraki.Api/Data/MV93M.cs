namespace Meraki.Api.Data;

/// <summary>
/// Quality and resolution for MV93M camera models.
/// </summary>
[DataContract]
public class MV93M
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
	public MV93MResolution Resolution { get; set; }
}
