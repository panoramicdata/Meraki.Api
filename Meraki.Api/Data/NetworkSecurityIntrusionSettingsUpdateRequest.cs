using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSecurityIntrusionSettings
	/// </summary>
	[DataContract]
	public class NetworkSecurityIntrusionSettingsUpdateRequest
	{
		/// <summary>
		/// Gets or Sets Mode
		/// </summary>
		[DataMember(Name = "mode")]
		public PreventionDetectionDisbledMode Mode { get; set; }

		/// <summary>
		/// Gets or Sets IdsRulesets
		/// </summary>
		[DataMember(Name = "idsRulesets")]
		public IdsRuleset IdsRulesets { get; set; }

		/// <summary>
		/// Gets or Sets ProtectedNetworks
		/// </summary>
		[DataMember(Name = "protectedNetworks")]
		public ProtectedNetworks ProtectedNetworks { get; set; } = new();
	}
}
