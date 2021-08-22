using System.Diagnostics;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// An organization
	/// </summary>
	[DataContract]
	[DebuggerDisplay("{" + nameof(Name) + "}")]
	public class Organization : NamedIdentifiedItem
	{
		/// <summary>
		/// The URL
		/// </summary>
		[DataMember]
		public string Url { get; set; } = default!;
	}
}