namespace Meraki.Api.Data;

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
	[ApiForeignKey(typeof(ProductType))]
	[ApiAccess(ApiAccess.Read)]
	public override List<ProductType> ProductTypes { get; set; } = [];
}
