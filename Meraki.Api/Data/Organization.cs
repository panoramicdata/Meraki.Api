using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// An organization
	/// </summary>
	[DataContract]
	public class Organization : NamedLongIdentifiedItem
	{
		/// <summary>
		/// The URL
		/// </summary>
		[DataMember]
		public string Url { get; set; } = default!;
	}
}