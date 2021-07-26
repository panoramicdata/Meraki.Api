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
	public partial class SwitchUpdate
	{
		/// <summary>
		/// Participate in next beta release?
		/// </summary>
		[DataMember(Name = "participateInNextBetaRelease")]
		public bool ParticipateInNextBetaRelease { get; set; }

		/// <summary>
		/// Next upgrade
		/// </summary>
		[DataMember(Name = "nextUpgrade")]
		public NextUpgradeUpdate NextUpgrade { get; set; } = new();
	}
}
