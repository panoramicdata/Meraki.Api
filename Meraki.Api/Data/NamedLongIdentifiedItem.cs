using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A named item identified by a long
	/// </summary>
	public abstract class NamedLongIdentifiedItem : LongIdentifiedItem
	{
		/// <summary>
		/// The name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;
	}
}