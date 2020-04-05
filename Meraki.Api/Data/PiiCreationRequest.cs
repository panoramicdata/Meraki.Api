using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// CreateNetworkPiiRequest
	/// </summary>
	[DataContract]
	public partial class PiiCreationRequest
	{
		/// <summary>
		/// Gets or Sets Type
		/// </summary>
		[DataMember(Name = "type", EmitDefaultValue = false)]
		public PiiType Type { get; set; }

		/// <summary>
		/// The datasets related to the provided key that should be deleted. Only applies to \&quot;delete\&quot; requests. The value \&quot;all\&quot; will be expanded to all datasets applicable to this type. The datasets by applicable to each type are: mac (usage, events, traffic), email (users, loginAttempts), username (users, loginAttempts), bluetoothMac (client, connectivity), smDeviceId (device), smUserId (user)
		/// </summary>
		/// <value>The datasets related to the provided key that should be deleted. Only applies to \&quot;delete\&quot; requests. The value \&quot;all\&quot; will be expanded to all datasets applicable to this type. The datasets by applicable to each type are: mac (usage, events, traffic), email (users, loginAttempts), username (users, loginAttempts), bluetoothMac (client, connectivity), smDeviceId (device), smUserId (user)</value>
		[DataMember(Name = "datasets", EmitDefaultValue = false)]
		public List<string> Datasets { get; set; } = null!;

		/// <summary>
		/// The username of a network log in. Only applies to \&quot;delete\&quot; requests.
		/// </summary>
		/// <value>The username of a network log in. Only applies to \&quot;delete\&quot; requests.</value>
		[DataMember(Name = "username", EmitDefaultValue = false)]
		public string Username { get; set; } = null!;

		/// <summary>
		/// The email of a network user account. Only applies to \&quot;delete\&quot; requests.
		/// </summary>
		/// <value>The email of a network user account. Only applies to \&quot;delete\&quot; requests.</value>
		[DataMember(Name = "email", EmitDefaultValue = false)]
		public string Email { get; set; } = null!;

		/// <summary>
		/// The MAC of a network client device. Applies to both \&quot;restrict processing\&quot; and \&quot;delete\&quot; requests.
		/// </summary>
		/// <value>The MAC of a network client device. Applies to both \&quot;restrict processing\&quot; and \&quot;delete\&quot; requests.</value>
		[DataMember(Name = "mac", EmitDefaultValue = false)]
		public string Mac { get; set; } = null!;

		/// <summary>
		/// The sm_device_id of a Systems Manager device. The only way to \&quot;restrict processing\&quot; or \&quot;delete\&quot; a Systems Manager device. Must include \&quot;device\&quot; in the dataset for a \&quot;delete\&quot; request to destroy the device.
		/// </summary>
		/// <value>The sm_device_id of a Systems Manager device. The only way to \&quot;restrict processing\&quot; or \&quot;delete\&quot; a Systems Manager device. Must include \&quot;device\&quot; in the dataset for a \&quot;delete\&quot; request to destroy the device.</value>
		[DataMember(Name = "smDeviceId", EmitDefaultValue = false)]
		public string SmDeviceId { get; set; } = null!;

		/// <summary>
		/// The sm_user_id of a Systems Manager user. The only way to \&quot;restrict processing\&quot; or \&quot;delete\&quot; a Systems Manager user. Must include \&quot;user\&quot; in the dataset for a \&quot;delete\&quot; request to destroy the user.
		/// </summary>
		/// <value>The sm_user_id of a Systems Manager user. The only way to \&quot;restrict processing\&quot; or \&quot;delete\&quot; a Systems Manager user. Must include \&quot;user\&quot; in the dataset for a \&quot;delete\&quot; request to destroy the user.</value>
		[DataMember(Name = "smUserId", EmitDefaultValue = false)]
		public string SmUserId { get; set; } = null!;
	}
}
