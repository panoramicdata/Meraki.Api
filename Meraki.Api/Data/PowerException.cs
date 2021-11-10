using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// PowerException
	/// </summary>
	[DataContract]
	public class PowerException
	{
		/// <summary>
		/// Serial number of the switch
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "serial")]
		public string Serial { get; set; } = string.Empty;

		/// <summary>
		/// Gets or Sets PowerType
		/// </summary>
		[ApiAccess(ApiAccess.ReadUpdate)]
		[DataMember(Name = "powerType")]
		public PowerType PowerType { get; set; }
	}
}
