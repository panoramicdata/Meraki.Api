namespace Meraki.Api.Data;

/// <summary>
///  Esims Service Providers Item
/// </summary>
[DataContract]
public class EsimsServiceProvidersItem
{
	/// <summary>
	/// Service provider name.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Indicates if service provider is the bootstrap provider.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "isBootstrap")]
	public bool IsBootstrap { get; set; }

	/// <summary>
	/// Service Provider logo data.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "logo")]
	public EsimsServiceProvidersItemLogo Logo { get; set; } = new();

	/// <summary>
	/// Service provider terms.
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "terms")]
	public EsimsServiceProvidersItemTerms Terms { get; set; } = new();
}
