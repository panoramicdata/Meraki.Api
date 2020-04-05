using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// PowerException
	/// </summary>
	[DataContract]
	public partial class PowerException
	{
		/// <summary>
		/// Serial number of the switch
		/// </summary>
		/// <value>Serial number of the switch</value>
		[DataMember(Name = "serial", EmitDefaultValue = false)]
		public string Serial { get; set; }
		/// <summary>
		/// Gets or Sets PowerType
		/// </summary>
		[DataMember(Name = "powerType", EmitDefaultValue = false)]
		public PowerType PowerType { get; set; }
	}
}
