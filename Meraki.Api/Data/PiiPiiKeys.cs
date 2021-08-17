using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// PII keys
	/// </summary>
	[DataContract]
	public class PiiPiiKeys
	{
		/// <summary>
		/// N_1234
		/// </summary>
		[DataMember(Name = "N_1234")]
		public N1234 N1234 { get; set; } = new();
	}
}
