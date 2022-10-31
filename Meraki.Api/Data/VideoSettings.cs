namespace Meraki.Api.Data;

/// <summary>
/// Video quality and resolution settings for all the camera models.
/// </summary>
[DataContract]
public class VideoSettings
{
	/// <summary>
	/// Gets or Sets MV2
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV2")]
	public Mv02? MV2 { get; set; }

	/// <summary>
	/// Gets or Sets MV21MV71
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV21/MV71")]
	public Mv21Mv71? Mv21Mv71 { get; set; }

	/// <summary>
	/// Gets or Sets MV12MV22MV72
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV12/MV22/MV72")]
	public Mv12Mv22Mv72? Mv12Mv22Mv72 { get; set; }

	/// <summary>
	/// Gets or Sets MV52
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV52")]
	public Mv52? Mv52 { get; set; }

	/// <summary>
	/// Gets or Sets MV63
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV63")]
	public Mv63 Mv63 { get; set; } = null!;

	/// <summary>
	/// Gets or Sets MV63X
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV63X")]
	public Mv63X Mv63X { get; set; } = null!;

	/// <summary>
	/// Gets or Sets MV93
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV93")]
	public Mv93 Mv93 { get; set; } = null!;

	/// <summary>
	/// Gets or Sets MV93X
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV93X")]
	public Mv93X Mv93X { get; set; } = null!;

	/// <summary>
	/// Gets or Sets MV32
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV32")]
	public Mv32? Mv32 { get; set; }

	/// <summary>
	/// Gets or Sets MV12WE
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV12WE")]
	public Mv12we? Mv12we { get; set; }

	/// <summary>
	/// Gets or Sets MV22XMV72X
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV22X/MV72X")]
	public Mv22xMv72x? Mv22xMv72x { get; set; }
}
