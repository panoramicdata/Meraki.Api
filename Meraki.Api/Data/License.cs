using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// License
	/// </summary>
	[DataContract]
	public partial class License
	{
		/// <summary>
		/// The key of the license
		/// </summary>
		/// <value>The key of the license</value>
		[DataMember(Name = "key", EmitDefaultValue = false)]
		public string? Key { get; set; }
		/// <summary>
		/// Gets or Sets Mode
		/// </summary>
		[DataMember(Name = "mode", EmitDefaultValue = false)]
		public LicenseMode Mode { get; set; }
	}
}
