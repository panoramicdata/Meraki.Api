namespace Meraki.Api.Data;

/// <summary>
/// Parses the custom role access values returned by the Meraki API, of the form
/// "custom-role:&lt;id&gt;" or "custom-role:&lt;id&gt;:&lt;name&gt;"
/// </summary>
internal static class CustomRole
{
	private const string Prefix = "custom-role:";

	/// <summary>
	/// Attempts to parse a custom role access value.
	/// The name is everything after the second colon, so it may itself contain colons.
	/// </summary>
	/// <param name="value">The raw access value</param>
	/// <param name="id">The custom role id, if the value is a custom role</param>
	/// <param name="name">The custom role name, if present</param>
	/// <returns>Whether the value is a custom role with a non-empty id</returns>
	internal static bool TryParse(string? value, out string? id, out string? name)
	{
		id = null;
		name = null;

		if (value is null || !value.StartsWith(Prefix, StringComparison.Ordinal))
		{
			return false;
		}

		var remainder = value[Prefix.Length..];
		var separatorIndex = remainder.IndexOf(':');
		var parsedId = separatorIndex < 0 ? remainder : remainder[..separatorIndex];
		if (parsedId.Length == 0)
		{
			return false;
		}

		id = parsedId;
		if (separatorIndex >= 0 && separatorIndex < remainder.Length - 1)
		{
			name = remainder[(separatorIndex + 1)..];
		}

		return true;
	}
}
