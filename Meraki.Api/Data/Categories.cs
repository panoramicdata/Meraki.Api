using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Categories
	/// </summary>
	[DataContract]
	public class Categories
	{
		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		[ApiAccess(ApiAccess.ReadWrite)]
		public string Id { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		[ApiAccess(ApiAccess.ReadWrite)]
		public string Name { get; set; } = string.Empty;
	}
}
