using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	public enum FirewalledServiceAccessType
	{
		/// <summary>
		/// no remote IPs can access the service
		/// </summary>
		[EnumMember(Value = "blocked")]
		Blocked = 1,

		/// <summary>
		/// only allowed IPs can access the service
		/// </summary>
		[EnumMember(Value = "restricted")]
		Restricted,

		/// <summary>
		/// any remote IP can access the service
		/// </summary>
		[EnumMember(Value = "unrestriced")]
		Unrestriced
	}
}