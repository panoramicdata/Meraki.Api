using Meraki.Api.Attributes;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateNetworkPiiRequest
	/// </summary>
	[DataContract]
	public class PiiRequestCreateRequest
	{
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[ApiAccess(ApiAccess.ReadCreate)]
		[DataMember(Name = "type")]
		public PiiType Type { get; set; }

		/// <summary>
		/// The datasets related to the provided key that should be deleted. Only applies to "delete" requests. The value "all" will be expanded to all datasets applicable to this type. The datasets by applicable to each type are: mac (usage, events, traffic), email (users, loginAttempts), username (users, loginAttempts), bluetoothMac (client, connectivity), smDeviceId (device), smUserId (user)
		/// </summary>
		[ApiAccess(ApiAccess.ReadCreate)]
		[DataMember(Name = "datasets")]
		public List<string>? Datasets { get; set; } = new();

		/// <summary>
		/// The username of a network log in. Only applies to "delete" requests.
		/// </summary>
		[ApiAccess(ApiAccess.Create)]
		[DataMember(Name = "username")]
		public string? Username { get; set; }

		/// <summary>
		/// The email of a network user account. Only applies to "delete" requests.
		/// </summary>
		[ApiAccess(ApiAccess.Create)]
		[DataMember(Name = "email")]
		public string? Email { get; set; }

		/// <summary>
		/// The MAC of a network client device. Applies to both "restrict processing" and "delete" requests.
		/// </summary>
		[ApiAccess(ApiAccess.ReadCreate)]
		[DataMember(Name = "mac")]
		public string Mac { get; set; } = string.Empty;

		/// <summary>
		/// The sm_device_id of a Systems Manager device. The only way to "restrict processing" or "delete" a Systems Manager device. Must include "device" in the dataset for a "delete" request to destroy the device.
		/// </summary>
		[ApiAccess(ApiAccess.Create)]
		[DataMember(Name = "smDeviceId")]
		public string SmDeviceId { get; set; } = string.Empty;

		/// <summary>
		/// The sm_user_id of a Systems Manager user. The only way to "restrict processing" or "delete" a Systems Manager user. Must include "user" in the dataset for a "delete" request to destroy the user.
		/// </summary>
		[ApiAccess(ApiAccess.Create)]
		[DataMember(Name = "smUserId")]
		public string SmUserId { get; set; } = string.Empty;
	}
}
