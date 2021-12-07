namespace Meraki.Api.Data;

/// <summary>
/// Systems Manager sentry enrollment splash settings
/// </summary>
[DataContract]
public class SentryEnrollment
{
	/// <summary>
	/// The strength of the enforcement of selected system types. Must be one of: 'focused', 'click-through', and 'strict'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "strength")]
	public string Strength { get; set; } = string.Empty;

	/// <summary>
	/// The system types that the Sentry enforces. Must be included in: 'iOS, 'Android', 'macOS', and 'Windows'.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "enforcedSystems")]
	public List<string> EnforcedSystems { get; set; } = new();

	/// <summary>
	/// Systems Manager network targeted for sentry enrollment.
	/// </summary>
	[ApiAccess(ApiAccess.ReadUpdate)]
	[DataMember(Name = "systemsManagerNetwork")]
	public SystemsManagerNetwork SystemsManagerNetwork { get; set; } = new();
}