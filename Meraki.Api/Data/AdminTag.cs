using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A tag
	/// </summary>
	[DataContract]
	public class AdminTag
	{
		/// <summary>
		/// The tag
		/// </summary>
		[DataMember(Name = "tag")]
		public string Tag { get; set; } = string.Empty;

		/// <summary>
		/// Tag access permissions
		/// </summary>
		[DataMember(Name = "access")]
		public string Access { get; set; } = string.Empty;
	}
}