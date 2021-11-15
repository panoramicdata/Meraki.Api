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
	[ApiAccess(ApiAccess.Read)]
	public override List<ProductType> ProductTypes { get; set; } = new();
}
