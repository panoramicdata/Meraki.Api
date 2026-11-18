namespace Meraki.Api;

/// <summary>
/// How to handle a response string that matches no member of the enum it is read into
/// </summary>
public enum UnknownEnumValueHandling
{
	/// <summary>
	/// Fail the whole call with a <see cref="JsonSerializationException"/>
	/// </summary>
	Throw = 1,

	/// <summary>
	/// Log a warning naming the property and the raw value, then read null for a nullable enum
	/// and the first declared member for a non-nullable one
	/// </summary>
	UseDefault = 2
}
