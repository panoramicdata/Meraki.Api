namespace Meraki.Api.Data;

/// <summary>
/// Quality and resolution for MV63 camera models.
/// </summary>
[DataContract]
public class Mv63X
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
	public Mv63XResolution Resolution { get; set; }
}
