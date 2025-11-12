namespace Meraki.Api.Data;

/// <summary>
/// Client Manufacturers Summary Clients
/// </summary>
[DataContract]
public class ClientManufacturersSummaryClients
{
	/// <summary>
	/// Counts
	/// </summary>
	[DataMember(Name = "counts")]
	public ClientOverviewCounts Counts { get; set; } = new();
}
