namespace Meraki.Api.Data;

/// <summary>
/// Quality and resolution for MV32 camera models.
/// </summary>
[DataContract]
public class Mv32
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
	public Mv32Resolution Resolution { get; set; }
}
