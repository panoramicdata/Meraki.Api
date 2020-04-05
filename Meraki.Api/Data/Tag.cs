using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// Tag
	/// </summary>
	[DataContract]
	public partial class Tag
	{
		/// <summary>
		/// The name of the tag
		/// </summary>
		/// <value>The name of the tag</value>
		[DataMember(Name = "tag", EmitDefaultValue = false)]
		public string TagText { get; set; } = null!;

		/// <summary>
		/// The privilege of the dashboard administrator on the tag
		/// </summary>
		/// <value>The privilege of the dashboard administrator on the tag</value>
		[DataMember(Name = "access", EmitDefaultValue = false)]
		public string Access { get; set; } = null!;
	}
}
