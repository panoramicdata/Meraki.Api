using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Version to be updated to
	/// </summary>
	[DataContract]
	public partial class VersionUpdate
	{
		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;
	}
}
