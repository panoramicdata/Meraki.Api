using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// AllowedFile
	/// </summary>
	[DataContract]
	public class AllowedFile
	{
		/// <summary>
		/// The file sha256 hash to whitelist
		/// </summary>
		/// <value>The file sha256 hash to whitelist</value>
		[DataMember(Name = "sha256", EmitDefaultValue = false)]
		public string Sha256 { get; set; } = string.Empty;

		/// <summary>
		/// Comment about the whitelisted entity
		/// </summary>
		/// <value>Comment about the whitelisted entity</value>
		[DataMember(Name = "comment", EmitDefaultValue = false)]
		public string Comment { get; set; } = string.Empty;
	}
}