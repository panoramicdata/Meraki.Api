namespace Meraki.Api;
/// <summary>
/// A member present in a response that the model being deserialized does not declare,
/// reported through <see cref="MerakiClientOptions.JsonMissingMembersAction"/>
/// </summary>
public sealed record JsonMissingMember
{
	/// <summary>
	/// Initializes a new instance of the JsonMissingMember class
	/// </summary>
	/// <param name="declaringType">The name of the model type that does not declare the member</param>
	/// <param name="memberName">The JSON name of the member</param>
	/// <param name="path">The JSON path of the member within the response</param>
	public JsonMissingMember(string declaringType, string memberName, string path)
	{
		DeclaringType = declaringType;
		MemberName = memberName;
		Path = path;
	}

	/// <summary>
	/// The name of the model type that does not declare the member, e.g. "SiteToSiteVpn".
	/// For a member inside another missing member, this is the type that lacks the outermost
	/// missing member, so it is always a type that exists in this library.
	/// </summary>
	public string DeclaringType { get; }

	/// <summary>
	/// The JSON name of the member, e.g. "publicIp"
	/// </summary>
	public string MemberName { get; }

	/// <summary>
	/// The JSON path of the member within the response, e.g. "natTraversal.publicIp" or "neighbors[1].filter"
	/// </summary>
	public string Path { get; }
}
