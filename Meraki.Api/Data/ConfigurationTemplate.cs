using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A configuration template
	/// </summary>
	[DataContract]
	public class ConfigurationTemplate : NetworkOrConfigurationTemplate
	{
		/// <summary>
		/// Product types
		/// </summary>
		[DataMember(Name = "productTypes")]
		[ApiAccess(ApiAccess.Read)]
		public List<ProductType> ProductTypes { get; set; } = new();
	}
}