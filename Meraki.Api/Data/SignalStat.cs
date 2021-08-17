using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Signal stat
	/// </summary>
	[DataContract]
	public partial class SignalStat
	{
		/// <summary>
		/// Rsrp
		/// </summary>
		[DataMember(Name = "rsrp")]
		public string Rsrp { get; set; } = string.Empty;

		/// <summary>
		/// Rsrq
		/// </summary>
		[DataMember(Name = "rsrq")]
		public string Rsrq { get; set; } = string.Empty;
	}
}
