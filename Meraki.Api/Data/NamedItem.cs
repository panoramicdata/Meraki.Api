using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Named item
	/// </summary>
	[DataContract]
	public abstract class NamedItem
	{
		/// <summary>
		/// The name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;
	}
}