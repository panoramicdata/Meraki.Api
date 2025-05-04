namespace Meraki.Api.Data;

/// <summary>
/// Quality and resolution for MV84X camera models.
/// </summary>
[DataContract]
public class Mv84X
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
	public Mv84xResolution Resolution { get; set; }
}