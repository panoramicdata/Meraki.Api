namespace Meraki.Api.Data;

/// <summary>
/// Five Ghz Channel Puncturing
/// </summary>
[DataContract]
public class FiveGhzChannelPuncturingSettings
{
	/// <summary>
	/// Undocumented
	/// </summary>
	[ApiAccess(ApiAccess.ReadWrite)]
	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }
}
