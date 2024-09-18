namespace Meraki.Api.Data;

/// <summary>
/// Esims Service Providers Accounts Communication Plans Item Apn
/// </summary>
[DataContract]
public class EsimsServiceProvidersAccountsCommunicationPlansItemApn
{
	/// <summary>
	///	APN name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;
}
