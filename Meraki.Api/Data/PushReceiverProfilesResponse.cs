namespace Meraki.Api.Data;

/// <summary>
/// Paginated response for Push Receiver Profiles
/// </summary>
[DataContract]
public class PushReceiverProfilesResponse : ItemsResponseWithMeta<PushReceiverProfile>
{
	/// <summary>
	/// The list of push receiver profiles
	/// </summary>
	[ApiAccess(ApiAccess.Read)]
	public override List<PushReceiverProfile> Items { get; set; } = [];
}
