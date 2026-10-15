namespace Meraki.Api.Data;

/// <summary>
/// Rogue signal contribution settings for energy detect RRM - Undocumented, observed in live API responses only
/// </summary>
[DataContract]
public class RfProfileEdRrmRogueContribution
{
	/// <summary>
	/// Whether rogue signals contribute to the energy detect measurement
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
