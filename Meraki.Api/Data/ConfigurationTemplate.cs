using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// An configuration template
	/// </summary>
	[DataContract]
	public class ConfigurationTemplate : NamedItem
	{
		/// <summary>
		/// The name
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;
	}
}