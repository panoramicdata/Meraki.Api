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
		// Optimized: Use direct switch statement instead of reflection
		// This is much faster as it avoids reflection overhead
		if (value is ApiRegion apiRegion)
		{
			return apiRegion switch
			{
				ApiRegion.Default => "meraki.com",
				ApiRegion.China => "meraki.cn",
				ApiRegion.Canada => "meraki.ca",
				ApiRegion.India => "meraki.in",
				ApiRegion.Government => "gov-meraki.com",
				_ => string.Empty
			};
		}

		// Fallback to reflection for unknown enum types
		var type = value.GetType();
		var field = type.GetField(value.ToString());
		var attribute = (MerakiApiDomainAttribute?)field?
			.GetCustomAttributes(typeof(MerakiApiDomainAttribute), false)?
			.FirstOrDefault();
		return attribute?.MerakiApiDomain ?? string.Empty;
	}
}