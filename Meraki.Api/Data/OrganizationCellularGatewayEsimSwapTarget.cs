namespace Meraki.Api.Data;

/// <summary>
/// Esims Swap Target
/// </summary>
[DataContract]
public class OrganizationCellularGatewayEsimSwapTarget
{
	/// <summary>
	///	ID of the target account; can be the account currently tied to the eSIM
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "accountId")]
	public string AccountId { get; set; } = string.Empty;

	/// <summary>
	///	Name of the target communication plan
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "communicationPlan")]
	public string CommunicationPlan { get; set; } = string.Empty;

	/// <summary>
	///	Name of the target rate plan
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "ratePlan")]
	public string RatePlan { get; set; } = string.Empty;
}
