namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsInventoryOrders
{
	/// <summary>
	/// Claim an order by the secure unique order claim number, the order claim id
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="organizationInventoryOrdersClaimRequest"></param>
	/// <param name="cancellationToken"></param>
	/// <returns></returns>
	[ApiOperationId("claimOrganizationInventoryOrders")]
	[Post("/organizations/{organizationId}/inventory/orders/claim")]
	Task<OrganizationInventoryOrdersClaimResponse> ClaimOrganizationInventoryOrdersAsync(
		string organizationId,
		[Body] OrganizationInventoryOrdersClaimRequest organizationInventoryOrdersClaimRequest,
		CancellationToken cancellationToken = default
	);
}
