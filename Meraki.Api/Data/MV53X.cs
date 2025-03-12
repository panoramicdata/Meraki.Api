namespace Meraki.Api.Data;

/// <summary>
/// Quality and resolution for MV53X camera models.
/// </summary>
[DataContract]
public class Mv53X
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
	public Mv53XResolution Resolution { get; set; }
}
