namespace Meraki.Api.Data;

[DataContract]
public class PerSsidSettings
{
	/// <summary>
	/// Seettings for SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "0")]
	public SsidRadioSetting Ssid0 { get; set; } = new();

	/// <summary>
	/// Seettings for SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "1")]
	public SsidRadioSetting Ssid1 { get; set; } = new();

	/// <summary>
	/// Seettings for SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "2")]
	public SsidRadioSetting Ssid2 { get; set; } = new();

	/// <summary>
	/// Seettings for SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "3")]
	public SsidRadioSetting Ssid3 { get; set; } = new();

	/// <summary>
	/// Seettings for SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "4")]
	public SsidRadioSetting Ssid4 { get; set; } = new();

	/// <summary>
	/// Seettings for SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "5")]
	public SsidRadioSetting Ssid5 { get; set; } = new();

	/// <summary>
	/// Seettings for SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "6")]
	public SsidRadioSetting Ssid6 { get; set; } = new();

	/// <summary>
	/// Seettings for SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "7")]
	public SsidRadioSetting Ssid7 { get; set; } = new();

	/// <summary>
	/// Seettings for SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "8")]
	public SsidRadioSetting Ssid8 { get; set; } = new();

	/// <summary>
	/// Seettings for SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "9")]
	public SsidRadioSetting Ssid9 { get; set; } = new();

	/// <summary>
	/// Seettings for SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "10")]
	public SsidRadioSetting Ssid10 { get; set; } = new();

	/// <summary>
	/// Seettings for SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "11")]
	public SsidRadioSetting Ssid11 { get; set; } = new();

	/// <summary>
	/// Seettings for SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "12")]
	public SsidRadioSetting Ssid12 { get; set; } = new();

	/// <summary>
	/// Seettings for SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "13")]
	public SsidRadioSetting Ssid13 { get; set; } = new();

	/// <summary>
	/// Seettings for SSID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "14")]
	public SsidRadioSetting Ssid14 { get; set; } = new();
}