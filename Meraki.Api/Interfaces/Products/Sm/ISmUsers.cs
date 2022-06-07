﻿namespace Meraki.Api.Interfaces.Products.Sm;

public interface ISmUsers
{
	/// <summary>
	/// List the owners in an SM network with various specified fields and filters
	/// </summary>
	/// <exception cref="ApiException">Thrown when fails to make API call</exception>
	/// <param name="networkId">The network id</param>
	/// <param name="ids">Filter users by id(s). Multiple ids can be passed in as comma separated values. (optional)</param>
	/// <param name="usernames">Filter users by username(s). Multiple usernames can be passed in as comma separated values. (optional)</param>
	/// <param name="emails">Filter users by email(s). Multiple emails can be passed in as comma separated values. (optional)</param>
	/// <param name="scope">Specifiy a scope (one of all, none, withAny, withAll, withoutAny, withoutAll) and a set of tags as comma separated values. (optional)</param>
	[Get("/networks/{networkId}/sm/users")]
	Task<List<SmNetworkUser>> GetNetworkSmUsersAsync(
		[AliasAs("networkId")] string networkId,
		[AliasAs("ids")] string ids = null!,
		[AliasAs("usernames")] string usernames = null!,
		[AliasAs("emails")] string emails = null!,
		[AliasAs("scope")] string scope = null!,
		CancellationToken cancellationToken = default
		);
}
