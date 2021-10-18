using Meraki.Api.Attributes;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// An switch profile
	/// </summary>
	[DataContract]
	public class SwitchProfile : NamedItem
	{
		/// <summary>
		/// The switch profile Id
		/// </summary>
		[ApiAccess(ApiAccess.Read)]
		[ApiKey]
		[DataMember(Name = "switchProfileId")]
		public string Id { get; set; } = string.Empty;

		/// <summary>
		/// The Model
		/// </summary>
		[ApiAccess(ApiAccess.Read)]
		[DataMember(Name = "model")]
		public string Model { get; set; } = string.Empty;
	}
}