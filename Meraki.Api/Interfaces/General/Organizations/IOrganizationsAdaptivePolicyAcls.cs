namespace Meraki.Api.Interfaces.General.Organizations;

public interface IOrganizationsAdaptivePolicyAcls
{
	/// <summary>
	/// List adaptive policy ACLs in a organization
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	[Get("/organizations/{organizationId}/adaptivePolicy/acls")]
	Task<List<AdaptivePolicyAcl>> GetOrganizationAdaptivePolicyAclsAsync(
		[AliasAs("organizationId")] string organizationId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Creates new adaptive policy ACL
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="acls">Body for creating an ACL</param>
	[Post("/organizations/{organizationId}/adaptivePolicy/acls")]
	Task<List<AdaptivePolicyAcl>> CreateOrganizationAdaptivePolicyAclAsync(
		[AliasAs("organizationId")] string organizationId,
		[Body] AdaptivePolicyAcl acls,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Returns the adaptive policy ACL information
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="aclId">The ACL id</param>
	[Get("/organizations/{organizationId}/adaptivePolicy/acls/{aclId}")]
	Task<AdaptivePolicyAcl> GetOrganizationAdaptivePolicyAclAsync(
		string organizationId,
		string aclId,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Returns the adaptive policy ACL information
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="aclId">The ACL id</param>
	/// <param name="acls">Body for returning ACL information</param>
	[Put("/organizations/{organizationId}/adaptivePolicy/acls/{aclId}")]
	Task<AdaptivePolicyAcl> UpdateOrganizationAdaptivePolicyAclAsync(
		string organizationId,
		string aclId,
		[Body] AdaptivePolicyAcl acls,
		CancellationToken cancellationToken = default);

	/// <summary>
	/// Deletes the specified adaptive policy ACL. Note this adaptive policy ACL will also be removed from policies using it.
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="organizationId">The organization id</param>
	/// <param name="aclId">The ACL id</param>
	[Delete("/organizations/{organizationId}/adaptivePolicy/acls/{aclId}")]
	Task DeleteOrganizationAdaptivePolicyAclAsync(
		string organizationId,
		string aclId,
		CancellationToken cancellationToken = default);
}
