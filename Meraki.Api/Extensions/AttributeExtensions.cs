namespace Meraki.Api.Extensions;

/// <summary>
/// Extension methods for Attribute
/// </summary>
public static class AttributeExtensions
{
	/// <summary>
	/// Gets the Meraki API domain from an enum value's MerakiApiDomainAttribute
	/// </summary>
	/// <param name="value">The enum value</param>
	/// <returns>The Meraki API domain string, or empty string if not found</returns>
	public static string GetMerakiApiDomain(this Enum value)
	{
		var type = value.GetType();
		var field = type.GetField(value.ToString());
		var attribute = (MerakiApiDomainAttribute?)field?
			.GetCustomAttributes(typeof(MerakiApiDomainAttribute), false)?
			.FirstOrDefault();
		return attribute?.MerakiApiDomain ?? string.Empty;
	}
}