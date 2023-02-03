namespace Meraki.Api.Data;

/// <summary>
/// Quality and resolution for MV33 camera models.
/// </summary>
[DataContract]
public class MV33
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
	public MV33Resolution Resolution { get; set; }
}
