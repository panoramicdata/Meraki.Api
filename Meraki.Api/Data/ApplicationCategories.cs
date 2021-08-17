using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Application categories
	/// </summary>
	[DataContract]
	public class ApplicationCategories
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

		/// <summary>
		/// Applications
		/// </summary>
		[DataMember(Name = "applications")]
		public List<Application> Applications { get; set; } = new();
	}
}
