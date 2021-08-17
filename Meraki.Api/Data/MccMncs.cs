using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Mcc Mncs
	/// </summary>
	[DataContract]
	public class MccMncs
	{
		/// <summary>
		/// Mcc
		/// </summary>
		[DataMember(Name = "mcc")]
		public string Mcc { get; set; } = string.Empty;

		/// <summary>
		/// Mnc
		/// </summary>
		[DataMember(Name = "mnc")]
		public string Mnc { get; set; } = string.Empty;
	}
}
