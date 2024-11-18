namespace Meraki.Api.Data;

/// <summary>
/// Esims Swap
/// </summary>
[DataContract]
public class OrganizationCellularGatewayEsimSwap
{
	/// <summary>
	///	eSIM EID
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "eid")]
	public string Eid { get; set; } = string.Empty;

	/// <summary>
	///	Target Profile attributes
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "target")]
	public OrganizationCellularGatewayEsimSwapTarget Target { get; set; } = new();
}
