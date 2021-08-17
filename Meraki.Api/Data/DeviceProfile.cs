using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Device profile
	/// </summary>
	[DataContract]
	public class DeviceProfile
	{
		/// <summary>
		/// Device id
		/// </summary>
		[DataMember(Name = "deviceId")]
		public string DeviceId { get; set; } = string.Empty;

		/// <summary>
		/// Id
		/// </summary>
		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;

		/// <summary>
		/// Is encrypted
		/// </summary>
		[DataMember(Name = "isEncrypted")]
		public bool IsEncrypted { get; set; }

		/// <summary>
		/// Is managed
		/// </summary>
		[DataMember(Name = "isManaged")]
		public bool IsManaged { get; set; }

		/// <summary>
		/// Profile data
		/// </summary>
		[DataMember(Name = "profileData")]
		public List<string> ProfileData { get; set; } = new();

		/// <summary>
		/// Profile identifier
		/// </summary>
		[DataMember(Name = "profileIdentifier")]
		public string ProfileIdentifier { get; set; } = string.Empty;

		/// <summary>
		/// Name
		/// </summary>
		[DataMember(Name = "name")]
		public string Name { get; set; } = string.Empty;

		/// <summary>
		/// Version
		/// </summary>
		[DataMember(Name = "version")]
		public string Version { get; set; } = string.Empty;
	}
}
