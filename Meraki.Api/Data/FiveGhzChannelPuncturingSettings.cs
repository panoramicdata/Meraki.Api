namespace Meraki.Api.Data;

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