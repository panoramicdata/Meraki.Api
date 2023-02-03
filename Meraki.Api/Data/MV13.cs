namespace Meraki.Api.Data;

/// <summary>
/// Quality and resolution for MV02 camera models.
/// </summary>
[DataContract]
public class MV13
{
	/// <summary>
	/// Gets or Sets Quality
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "quality")]
	public CameraQuality Quality { get; set; }

	/// <summary>
	/// Gets or Sets Resolution
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "resolution")]
	public MV13Resolution Resolution { get; set; }
}
