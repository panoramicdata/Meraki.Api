using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Warm spare config
	/// </summary>
	[DataContract]
	public class SwitchWarmSpareUpdateRequest
	{
		/// <summary>
		/// Enable or disable warm spare for a switch
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "enabled")]
		public bool Enabled { get; set; }

		/// <summary>
		/// Serial number of the warm spare switch
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "spareSerial")]
		public string SpareSerial { get; set; } = string.Empty;
	}
}
