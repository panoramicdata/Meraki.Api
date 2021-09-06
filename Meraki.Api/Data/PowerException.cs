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
		/// <value>Serial number of the switch</value>
		[DataMember(Name = "serial")]
		public string Serial { get; set; } = string.Empty;
		/// <summary>
		/// Gets or Sets PowerType
		/// </summary>
		[DataMember(Name = "powerType")]
		public PowerType PowerType { get; set; }
	}
}
