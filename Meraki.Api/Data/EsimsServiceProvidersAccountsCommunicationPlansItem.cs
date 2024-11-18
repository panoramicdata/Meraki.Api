namespace Meraki.Api.Data;

/// <summary>
/// Esims Service Providers Accounts Communication Plans Item
/// </summary>
[DataContract]
public class EsimsServiceProvidersAccountsCommunicationPlansItem
{
	/// <summary>
	///	Account ID of plans to be fetched
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "accountId")]
	public string AccountId { get; set; } = string.Empty;

	/// <summary>
	/// Communication plan name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = string.Empty;

	/// <summary>
	/// Available APNs
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "apns")]
	public List<EsimsServiceProvidersAccountsCommunicationPlansItemApn> Apns { get; set; } = [];
}
