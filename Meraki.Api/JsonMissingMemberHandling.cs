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
	/// Read the whole response, collecting every missing member, report them to
	/// <see cref="MerakiClientOptions.JsonMissingMemberAction"/> and
	/// <see cref="MerakiClientOptions.JsonMissingMembersAction"/>, then throw a
	/// <see cref="Exceptions.JsonMissingMembersException"/> listing them all
	/// </summary>
	ThrowOnError = 2,

	/// <summary>
	/// Read the whole response once, collecting every missing member, log a warning and report them to
	/// <see cref="MerakiClientOptions.JsonMissingMemberAction"/> and
	/// <see cref="MerakiClientOptions.JsonMissingMembersAction"/>, then return the object, with every
	/// declared member bound, as the Ignore behavior would
	/// </summary>
	LogWarningOnErrorAndContinue = 3
}
