using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Examples
	/// </summary>
	[DataContract]
	public class Examples
	{
		/// <summary>
		/// Application/JSON
		/// </summary>
		[DataMember(Name = "application/json")]
		public List<ApplicationJson> ApplicationJson { get; set; } = new();
	}
}
