namespace Meraki.Api.Data;

/// <summary>
/// Restrictions
/// </summary>
[DataContract]
public class Restrictions
{
	/// <summary>
	/// MyRestriction
	/// </summary>
	[DataMember(Name = "myRestriction")]
	public MyRestriction MyRestriction { get; set; } = new();
}
