using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Switch
	/// </summary>
	[DataContract]
	public partial class Switch
	{
		/// <summary>
		/// Current version
		/// </summary>
		[DataMember(Name = "currentVersion")]
		public Version CurrentVersion { get; set; } = new();

		/// <summary>
		/// Last upgrade
		/// </summary>
		[DataMember(Name = "lastUpgrade")]
		public LastUpgrade LastUpgrade { get; set; } = new();

		/// <summary>
		/// Next upgrade
		/// </summary>
		[DataMember(Name = "nextUpgrade")]
		public NextUpgrade NextUpgrade { get; set; } = new();

		/// <summary>
		/// Available versions
		/// </summary>
		[DataMember(Name = "availableVersions")]
		public List<Version> AvailableVersions { get; set; } = new();

		/// <summary>
		/// Participate in next beta release?
		/// </summary>
		[DataMember(Name = "participateInNextBetaRelease")]
		public bool ParticipateInNextBetaRelease { get; set; }
	}
}
