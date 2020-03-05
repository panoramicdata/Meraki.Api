using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A named, identified item
	/// </summary>
	public abstract class NamedIdentifiedItem : IdentifiedItem
	{
		/// <summary>
		/// The name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;
	}
}