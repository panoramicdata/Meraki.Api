using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Response
	/// </summary>
	[DataContract]
	public class UpdateOnboardingStatusResponse
	{
		/// <summary>
		/// Success
		/// </summary>
		[DataMember(Name = "success")]
		public bool Success { get; set; }
	}
}
