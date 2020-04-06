using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSwitchSettingsMtu
	/// </summary>
	[DataContract]
	public partial class SwitchSettingsMtuUpdateRequest
	{
		/// <summary>
		/// MTU size for the entire network. Default value is 9578.
		/// </summary>
		/// <value>MTU size for the entire network. Default value is 9578.</value>
		[DataMember(Name = "defaultMtuSize", EmitDefaultValue = false)]
		public int? DefaultMtuSize { get; set; }
		/// <summary>
		/// Override MTU size for individual switches or switch profiles. An empty array will clear overrides.
		/// </summary>
		/// <value>Override MTU size for individual switches or switch profiles. An empty array will clear overrides.</value>
		[DataMember(Name = "overrides", EmitDefaultValue = false)]
		public List<ModelOverride> Overrides { get; set; }
	}
}
