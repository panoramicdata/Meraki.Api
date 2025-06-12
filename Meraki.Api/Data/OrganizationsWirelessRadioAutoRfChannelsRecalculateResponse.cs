namespace Meraki.Api.Data;

/// <summary>
/// Organizations Wireless Radio AutoRf Channels Recalculate Response
/// </summary>
[DataContract]
public class OrganizationsWirelessRadioAutoRfChannelsRecalculateResponse
{
	/// <summary>
	/// Estimated time of completion.
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "estimatedCompletedAt")]
	public string EstimatedCompletedAt { get; set; } = string.Empty;
}
