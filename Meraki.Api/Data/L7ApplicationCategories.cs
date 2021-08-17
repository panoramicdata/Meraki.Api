using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// L7 Application categories
	/// </summary>
	[DataContract]
	public class L7ApplicationCategories
	{
		/// <summary>
		/// Application categories
		/// </summary>
		[DataMember(Name = "applicationCategories")]
		public List<ApplicationCategories> ApplicationCategories { get; set; } = new();
	}
}
