using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Warm spare config
	/// </summary>
	[DataContract]
	public class SwitchWarmSpare : SwitchWarmSpareUpdateRequest
	{
		/// <summary>
		/// Primary serial
		/// </summary>
		[ApiAccess(ApiAccess.Read)]
		[DataMember(Name = "primarySerial")]
		public string PrimarySerial { get; set; } = string.Empty;
	}
}
