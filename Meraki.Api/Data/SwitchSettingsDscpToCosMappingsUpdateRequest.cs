using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSwitchSettingsDscpToCosMappings
	/// </summary>
	[DataContract]
	public partial class SwitchSettingsDscpToCosMappingsUpdateRequest
	{
		/// <summary>
		/// An array of DSCP to CoS mappings. An empty array will reset the mappings to default.
		/// </summary>
		/// <value>An array of DSCP to CoS mappings. An empty array will reset the mappings to default.</value>
		[DataMember(Name = "mappings", EmitDefaultValue = false)]
		public List<Mapping> Mappings { get; set; }
	}
}
