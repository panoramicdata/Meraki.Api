namespace Meraki.Api.Data;

/// <summary>
/// Quality and resolution for MV13M camera models.
/// </summary>
[DataContract]
public class MV13M
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
