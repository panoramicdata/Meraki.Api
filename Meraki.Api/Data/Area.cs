using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// OSPF area
	/// </summary>
	[DataContract]
	public class Area
	{
		/// <summary>
		/// OSPF area ID
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "areaId")]
		public string AreaId { get; set; } = string.Empty;

		/// <summary>
		/// Name of the OSPF area
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "areaName")]
		public string AreaName { get; set; } = string.Empty;

		/// <summary>
		/// Area types in OSPF. Must be one of: ["normal", "stub", "nssa"]
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "areaType")]
		public AreaType AreaType { get; set; }
	}
}