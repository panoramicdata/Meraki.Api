namespace Meraki.Api.Data;

/// <summary>
/// An item identified by a long
/// </summary>
public abstract class LongIdentifiedItem
{
	/// <summary>
	/// The id
	/// </summary>
	[DataMember(Name = "id")]
	public long Id { get; set; }
}
