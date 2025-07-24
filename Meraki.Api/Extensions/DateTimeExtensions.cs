using System.Globalization;

namespace Meraki.Api.Extensions;

/// <summary>
///		Provides extension methods for converting <see cref="DateTime"/> and <see cref="DateTimeOffset"/> objects to a
///		standard Meraki T0/T1 timestamp format.
/// </summary>
/// <remarks>
///		The Meraki T0/T1 timestamp format is represented as a string in the format "yyyy-MM-ddTHH:mm:ssZ", 
///		which corresponds to the ISO 8601 format in UTC.
/// </remarks>
public static class DateTimeExtensions
{
	/// <summary>
	/// Converts a <see cref="DateTime"/> to a standard Meraki T0/T1 timestamp string.
	/// </summary>
	/// <param name="dateTime">The DateTime to convert.</param>
	/// <returns>The Unix timestamp in seconds.</returns>
	public static string ToMerakiT0T1String(this DateTime dateTime)
		=> dateTime.ToString("yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture);

	/// <summary>
	/// Converts a <see cref="DateTimeOffset"/> to a standard Meraki T0/T1 timestamp string.
	/// </summary>
	/// <param name="dateTime">The DateTime to convert.</param>
	/// <returns>The Unix timestamp in seconds.</returns>
	public static string ToMerakiT0T1String(this DateTimeOffset dateTime)
		=> dateTime.ToString("yyyy-MM-ddTHH:mm:ssZ", CultureInfo.InvariantCulture);
}
