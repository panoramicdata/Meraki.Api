using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Saml
	/// </summary>
	[DataContract]
	public class Saml
	{
		/// <summary>
		/// Enabled?
		/// </summary>
		[DataMember(Name = "enabled")]
		public bool Enabled { get; set; }
	}
}
