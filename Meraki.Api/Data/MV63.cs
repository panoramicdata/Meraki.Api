namespace Meraki.Api.Data;

/// <summary>
/// Quality and resolution for MV63X camera models.
/// </summary>
[DataContract]
public class Mv63
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
	public Mv63Resolution Resolution { get; set; }
}
