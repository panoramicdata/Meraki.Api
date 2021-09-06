using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Current version
	/// </summary>
	[DataContract]
	public class Version
	{
		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public int Id { get; set; } = 0;

		/// <summary>
		/// Firmware
		/// </summary>
		[DataMember(Name = "firmware")]
		public string Firmware { get; set; } = string.Empty;

		/// <summary>
		/// Short name
		/// </summary>
		[DataMember(Name = "shortName")]
		public string ShortName { get; set; } = string.Empty;

		/// <summary>
		/// Release type
		/// </summary>
		[DataMember(Name = "releaseType")]
		public string ReleaseType { get; set; } = string.Empty;
	}
}
