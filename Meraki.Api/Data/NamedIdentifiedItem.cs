using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A named, identified item
	/// </summary>
	[DataContract]
	public abstract class NamedIdentifiedItem : IdentifiedItem
	{
		/// <summary>
		/// The name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = default!;
	}
}