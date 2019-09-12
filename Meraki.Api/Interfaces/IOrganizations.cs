using Meraki.Api.Data;
using Refit;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Meraki.Api.Interfaces
{
	/// <summary>
	/// Organizations interface
	/// </summary>
	public interface IOrganizations
	{
		/// <summary>
		/// GetAsync
		/// </summary>
		[Get("/organizations")]
		Task<List<Organization>> GetAllAsync();

		/// <summary>
		/// GetAsync
		/// </summary>
		/// <param name="orgId"></param>
		[Get("/organizations/{orgId}")]
		Task<Organization> GetAsync(int orgId);
	}
}
