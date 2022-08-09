namespace Meraki.Api.Data;

/// <summary>
/// Billing
/// </summary>
[DataContract]
public class Billing
{
	/// <summary>
	/// Reply to email address
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "replyToEmailAddress")]
	public string? ReplyToEmailAddress { get; set; }

	/// <summary>
	/// Prepaid access fast login enabled
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "prepaidAccessFastLoginEnabled")]
	public bool? PrepaidAccessFastLoginEnabled { get; set; }

	/// <summary>
	/// Free access
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "freeAccess")]
	public FreeAccess? FreeAccess { get; set; }
}
