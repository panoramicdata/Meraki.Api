using System.Diagnostics;

namespace Meraki.Api.Data;

/// <summary>
/// A named, identified item
/// </summary>
[DebuggerDisplay("{" + nameof(Name) + "} ({" + nameof(Id) + "})")]
[DataContract]
public abstract class NamedIdentifiedItem : IdentifiedItem
{
	/// <summary>
	/// The name
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "name")]
	public string Name { get; set; } = default!;
}
