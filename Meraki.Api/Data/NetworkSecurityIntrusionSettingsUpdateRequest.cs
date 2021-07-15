using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSecurityIntrusionSettings
	/// </summary>
	[DataContract]
	public partial class NetworkSecurityIntrusionSettingsUpdateRequest
	{
		/// <summary>
		/// Gets or Sets Mode
		/// </summary>
		[DataMember(Name = "mode", EmitDefaultValue = false)]
		public PreventionDetectionDisbledMode Mode { get; set; }

		/// <summary>
		/// Gets or Sets IdsRulesets
		/// </summary>
		[DataMember(Name = "idsRulesets", EmitDefaultValue = false)]
		public IdsRuleset IdsRulesets { get; set; }

		/// <summary>
		/// Gets or Sets ProtectedNetworks
		/// </summary>
		[DataMember(Name = "protectedNetworks", EmitDefaultValue = false)]
		public ProtectedNetworks ProtectedNetworks { get; set; } = new();
	}
}
