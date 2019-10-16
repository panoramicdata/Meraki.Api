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
		[DataMember(Name = "switchProfileId")]
		public string Id { get; set; } = string.Empty;

		/// <summary>
		/// The Model
		/// </summary>
		[DataMember(Name = "model")]
		public string Model { get; set; } = string.Empty;
	}
}