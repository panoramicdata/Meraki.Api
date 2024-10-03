namespace Meraki.Api.Data;

/// <summary>
/// Network Cellular Gateway Esim Update
/// </summary>
[DataContract]
public class NetworkCellularGatewayEsimUpdate
{
	/// <summary>
	/// Status the eSIM will be updated to
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	[DataMember(Name = "status")]
	public string Status { get; set; } = string.Empty;
}
