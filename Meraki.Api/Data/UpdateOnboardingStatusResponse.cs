using System.Runtime.Serialization;

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
