namespace Meraki.Api;
/// <summary>
/// Json Missing Member Handling
/// </summary>
public enum JsonMissingMemberHandling
{
	/// <summary>
	/// Use the default Newtonsoft Ignore missing members behavior
	/// </summary>
	Ignore = 1,

	/// <summary>
	/// Use the default Newtonsoft Error on missing members behavior
	/// </summary>
	ThrowOnError = 2,

	/// <summary>
	/// Log the issue when a missing member error occurs and then reattempt using the Ignore behavior
	/// </summary>
	LogWarningOnErrorAndContinue = 3
}
