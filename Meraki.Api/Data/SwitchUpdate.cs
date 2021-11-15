using System.Runtime.Serialization;

namespace Meraki.Api.Data;

/// <summary>
/// Switch
/// </summary>
[DataContract]
public class SwitchUpdate
{
	/// <summary>
	/// Participate in next beta release?
	/// </summary>
	[DataMember(Name = "participateInNextBetaRelease")]
	public bool ParticipateInNextBetaRelease { get; set; }

	/// <summary>
	/// Next upgrade
	/// </summary>
	[DataMember(Name = "nextUpgrade")]
	public NextUpgradeUpdate NextUpgrade { get; set; } = new();
}
