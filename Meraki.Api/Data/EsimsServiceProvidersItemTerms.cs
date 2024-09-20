namespace Meraki.Api.Data;

/// <summary>
///  Esims Service Providers Item Terms
/// </summary>
[DataContract]
public class EsimsServiceProvidersItemTerms
{
	/// <summary>
	/// URL of service provider's terms.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "content")]
	public string? Content { get; set; }

	/// <summary>
	/// Label for service provider's terms.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "name")]
	public string? Name { get; set; }
}
