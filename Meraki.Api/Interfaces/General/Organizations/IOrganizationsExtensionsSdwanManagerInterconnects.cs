namespace Meraki.Api.Interfaces.General.Organizations;
public interface IOrganizationsExtensionsSdwanManagerInterconnects
{
	/// <summary>
	/// Update name and status of an Interconnect
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId"></param>
	/// <param name="interconnectId"></param>
	/// <param name="request"></param>
	/// <returns></returns>
	[ApiOperationId("updateOrganizationExtensionsSdwanmanagerInterconnect")]
	[Put("/organizations/{organizationId}/extensions/sdwanmanager/interconnects/{interconnectId}")]
	Task<OrganizationExtensionsSdwanManagerInterconnect> UpdateOrganizationExtensionsSdwanmanagerInterconnectAsync(
		string organizationId,
		string interconnectId,
		[Body] OrganizationExtensionsSdwanManagerInterconnectUpdateRequest request
	);
}
