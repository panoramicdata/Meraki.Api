namespace Meraki.Api.Data;

/// <summary>
/// Video quality and resolution settings for all the camera models.
/// </summary>
[DataContract]
public class VideoSettings
{
	/// <summary>
	/// Gets or Sets MV21MV71
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV21/MV71")]
	public Mv21Mv71 Mv21Mv71 { get; set; } = null!;

	/// <summary>
	/// Gets or Sets MV12MV22MV72
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV12/MV22/MV72")]
	public Mv12Mv22Mv72 Mv12Mv22Mv72 { get; set; } = null!;

	/// <summary>
	/// Gets or Sets MV52
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV52")]
	public Mv52 Mv52 { get; set; } = null!;

	/// <summary>
	/// Gets or Sets MV32
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV32")]
	public Mv32 Mv32 { get; set; } = null!;

	/// <summary>
	/// Gets or Sets MV12WE
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV12WE")]
	public Mv12we Mv12we { get; set; } = null!;

	/// <summary>
	/// Gets or Sets MV22XMV72X
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV22X/MV72X")]
	public Mv22xMv72x Mv22xMv72x { get; set; } = null!;
}
