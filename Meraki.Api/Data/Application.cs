using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Application
	/// </summary>
	[DataContract]
	public class Application
	{
		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;
	}
}
