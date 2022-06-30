namespace Meraki.Api.Data;

[DataContract]
public class ClientManufacturersSummaryClients
{
	/// <summary>
	/// Counts
	/// </summary>
	[DataMember(Name = "counts")]
	public ClientOverviewCounts Counts { get; set; } = new();
}
