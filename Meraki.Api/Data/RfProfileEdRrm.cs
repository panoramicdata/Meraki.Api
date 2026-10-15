namespace Meraki.Api.Data;

/// <summary>
/// Energy detect radio resource management settings for an RF profile band - Undocumented, observed in live API responses only
/// </summary>
[DataContract]
public class RfProfileEdRrm
{
	/// <summary>
	/// Whether energy detect RRM is enabled
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	/// <summary>
	/// Energy detect sensitivity settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "sensitivity")]
	public RfProfileEdRrmSensitivity? Sensitivity { get; set; }

	/// <summary>
	/// Rogue signal handling settings
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "rogue")]
	public RfProfileEdRrmRogue? Rogue { get; set; }
}
