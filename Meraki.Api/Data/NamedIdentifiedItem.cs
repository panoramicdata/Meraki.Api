using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	public class NamedIdentifiedItem : IdentifiedItem
	{
		/// <summary>
		/// The name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;
	}
}