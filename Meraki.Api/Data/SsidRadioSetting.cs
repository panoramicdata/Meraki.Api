namespace Meraki.Api.Data;

[DataContract]
public class SsidRadioSetting
{
	/// <summary>
	/// Gets or Sets BandOperationMode
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Gets or Sets BandOperationMode
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "bandOperationMode")]
	public BandOperationMode BandOperationMode { get; set; }

	/// <summary>
	/// Steers client to most open band. Can be either true or false. Defaults to true.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "bandSteeringEnabled")]
	public bool BandSteeringEnabled { get; set; }

	/// <summary>
	/// Gets or Sets MinBitrate
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "minBitrate")]
	public MinBitrate MinBitrate { get; set; }
}