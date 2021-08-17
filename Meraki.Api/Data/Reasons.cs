using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Reasons
	/// </summary>
	[DataContract]
	public partial class Reasons
	{
		/// <summary>
		/// Category
		/// </summary>
		[DataMember(Name = "category")]
		public string Category { get; set; } = string.Empty;

		/// <summary>
		/// Comment
		/// </summary>
		[DataMember(Name = "comment")]
		public string Comment { get; set; } = string.Empty;
	}
}
