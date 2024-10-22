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
	public Mv63? Mv63 { get; set; }

	/// <summary>
	/// Gets or Sets MV63X
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV63X")]
	public Mv63X? Mv63X { get; set; }

	/// <summary>
	/// Gets or Sets MV73
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV73")]
	public Mv73? Mv73 { get; set; }

	/// <summary>
	/// Gets or Sets MV73M
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV73M")]
	public Mv73? Mv73M { get; set; }

	/// <summary>
	/// Gets or Sets MV73X
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV73X")]
	public Mv73? Mv73X { get; set; }

	/// <summary>
	/// Gets or Sets MV93
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV93")]
	public Mv93? Mv93 { get; set; }

	/// <summary>
	/// Gets or Sets MV93X
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV93X")]
	public Mv93X? Mv93X { get; set; }

	/// <summary>
	/// Gets or Sets MV23
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV23")]
	public Mv23? Mv23 { get; set; }

	/// <summary>
	/// Gets or Sets MV23M
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV23M")]
	public Mv23? Mv23M { get; set; }

	/// <summary>
	/// Gets or Sets MV23X
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV23X")]
	public Mv23? Mv23X { get; set; }

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
	/// Gets or Sets MV13
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV13")]
	public MV13? MV13 { get; set; }

	/// <summary>
	/// Gets or Sets MV13M
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV13M")]
	public MV13M? MV13M { get; set; }

	/// <summary>
	/// Gets or Sets MV33
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV33")]
	public MV33? MV33 { get; set; }

	/// <summary>
	/// Gets or Sets MV33M
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV33M")]
	public MV33M? MV33M { get; set; }

	/// <summary>
	/// Gets or Sets MV22XMV72X
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV22X/MV72X")]
	public Mv22xMv72x? Mv22xMv72x { get; set; }

	/// <summary>
	/// Gets or Sets MV63M
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV63M")]
	public MV63M? MV63M { get; set; }

	/// <summary>
	/// Gets or Sets MV93M
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "MV93M")]
	public MV93M? MV93M { get; set; }
}
