using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	[DataContract]
	public class SecurityCenter
	{

		[DataMember(Name = "isRooted")]
		public bool IsRooted { get; set; }

		[DataMember(Name = "hasAntiVirus")]
		public bool HasAntiVirus { get; set; }

		[DataMember(Name = "antiVirusName")]
		public string AntiVirusName { get; set; } = string.Empty;

		[DataMember(Name = "isFireWallEnabled")]
		public bool IsFireWallEnabled { get; set; }

		[DataMember(Name = "hasFireWallInstalled")]
		public bool HasFireWallInstalled { get; set; }

		[DataMember(Name = "fireWallName")]
		public string FireWallName { get; set; } = string.Empty;

		[DataMember(Name = "isDiskEncrypted")]
		public bool IsDiskEncrypted { get; set; }

		[DataMember(Name = "isAutoLoginDisabled")]
		public bool IsAutoLoginDisabled { get; set; }

		[DataMember(Name = "id")]
		public string Id { get; set; } = string.Empty;

		[DataMember(Name = "runningProcs")]
		public string RunningProcs { get; set; } = string.Empty;
	}
}
