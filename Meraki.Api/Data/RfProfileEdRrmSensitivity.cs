namespace Meraki.Api.Data;

/// <summary>
/// Energy detect sensitivity settings - Undocumented, observed in live API responses only
/// </summary>
[DataContract]
public class RfProfileEdRrmSensitivity
{
	/// <summary>
	/// The energy detect threshold
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "threshold")]
	public int? Threshold { get; set; }
}
