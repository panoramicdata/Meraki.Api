using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	[DataContract]
	public abstract class IdentifiedItem
	{
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;
	}
}