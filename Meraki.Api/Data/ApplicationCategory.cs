using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Application categories
	/// </summary>
	[DataContract]
	public class ApplicationCategory
	{
		/// <summary>
		/// Id
		/// </summary>
		[ApiAccess(ApiAccess.Read)]
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[ApiAccess(ApiAccess.Read)]
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Applications
		/// </summary>
		[ApiAccess(ApiAccess.Read)]
		[DataMember(Name = "applications")]
		public List<Application> Applications { get; set; } = new();
	}
}
