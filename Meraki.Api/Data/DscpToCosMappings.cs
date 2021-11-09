using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSwitchSettingsDscpToCosMappings
	/// </summary>
	[DataContract]
	public class DscpToCosMappings
	{
		/// <summary>
		/// An array of DSCP to CoS mappings. An empty array will reset the mappings to default.
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "mappings")]
		public List<DscpToCosMapping> Mappings { get; set; } = new();
	}
}
