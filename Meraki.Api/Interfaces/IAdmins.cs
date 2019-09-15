using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Admins interface
	/// </summary>
	public interface IAdmins
	{
		/// <summary>
		/// GetAllAsync
		/// </summary>
		/// <param name="organizationId">The organization id</param>
		[Get("/organizations/{organizationId}/admins")]
		Task<List<ApiUsage>> GetAllAsync(
			int organizationId,
			CancellationToken cancellationToken = default);
	}
}
