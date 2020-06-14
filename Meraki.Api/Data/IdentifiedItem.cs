using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// An identified item
	/// </summary>
	[DataContract]
	public abstract class IdentifiedItem
	{
		/// <summary>
		/// The Id
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;
	}
}