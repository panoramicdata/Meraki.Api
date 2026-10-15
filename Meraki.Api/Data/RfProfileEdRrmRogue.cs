namespace Meraki.Api.Data;

/// <summary>
/// Rogue signal handling settings for energy detect RRM - Undocumented, observed in live API responses only
/// </summary>
[DataContract]
public class RfProfileEdRrmRogue
{
	/// <summary>
	/// How rogue signals contribute to the energy detect measurement
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "contribution")]
	public RfProfileEdRrmRogueContribution? Contribution { get; set; }
}
