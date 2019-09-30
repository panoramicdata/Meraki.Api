using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A license claim
	/// </summary>
	[DataContract]
	public class LicenseClaim
	{
		/// <summary>
		/// Key
		/// </summary>
		[DataMember(Name = "key")]
		public string Key { get; set; } = string.Empty;

		/// <summary>
		/// Mode
		/// </summary>
		[DataMember(Name = "mode")]
		public string Mode { get; set; } = string.Empty;
	}
}