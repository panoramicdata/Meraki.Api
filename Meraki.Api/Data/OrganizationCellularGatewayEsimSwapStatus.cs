namespace Meraki.Api.Data;

/// <summary>
/// Esims Swap Statuses
/// </summary>
[DataContract]
public class OrganizationCellularGatewayEsimSwapStatus
{
	/// <summary>
	///	eSIM EID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "eid")]
	public string Eid { get; set; } = string.Empty;

	/// <summary>
	///	eSIM ICCID
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "iccid")]
	public string Iccid { get; set; } = string.Empty;

	/// <summary>
	///	Swap status
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;
}
