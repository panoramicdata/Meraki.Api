using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// UpdateNetworkSmTargetGroup
	/// </summary>
	[DataContract]
	public partial class SmTargetGroupUpdateRequest
	{
		/// <summary>
		/// The name of this target group
		/// </summary>
		/// <value>The name of this target group</value>
		[DataMember(Name = "name", EmitDefaultValue = false)]
		public string Name { get; set; }
		/// <summary>
		/// The scope and tag options of the target group. Comma separated values beginning with one of withAny, withAll, withoutAny, withoutAll, all, none, followed by tags. Default to none if empty.
		/// </summary>
		/// <value>The scope and tag options of the target group. Comma separated values beginning with one of withAny, withAll, withoutAny, withoutAll, all, none, followed by tags. Default to none if empty.</value>
		[DataMember(Name = "scope", EmitDefaultValue = false)]
		public string Scope { get; set; }
	}
}
