using Meraki.Api.Attributes;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// A named, identified item
	/// </summary>
	[DebuggerDisplay($"{{{nameof(Name)}}} ({{{nameof(Id)}}})")]
	[DataContract]
	public abstract class NamedIdentifiedItem : IdentifiedItem
	{
		/// <summary>
		/// The name
		/// </summary>
		[DataMember(Name = "name")]
		[ApiAccess(ApiAccess.ReadWrite)]
		public string Name { get; set; } = default!;
	}
}