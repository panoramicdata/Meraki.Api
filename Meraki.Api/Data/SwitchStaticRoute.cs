using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Static route information
	/// </summary>
	[DataContract]
	public class SwitchStaticRoute
	{
		/// <summary>
		/// Static route ip
		/// </summary>
		[DataMember(Name = "staticRouteIp")]
		public string StaticRouteIp { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Subnet
		/// </summary>
		[DataMember(Name = "subnet")]
		public string Subnet { get; set; } = string.Empty;

		/// <summary>
		/// Next hop ip
		/// </summary>
		[DataMember(Name = "nextHopIp")]
		public string NextHopIp { get; set; } = string.Empty;

		/// <summary>
		/// Advertise via ospf enabled
		/// </summary>
		[DataMember(Name = "advertiseViaOspfEnabled")]
		public bool AdvertiseViaOspfEnabled { get; set; }

		/// <summary>
		/// Prefer over ospf routes enabled
		/// </summary>
		[DataMember(Name = "preferOverOspfRoutesEnabled")]
		public bool PreferOverOspfRoutesEnabled { get; set; }
	}
}
