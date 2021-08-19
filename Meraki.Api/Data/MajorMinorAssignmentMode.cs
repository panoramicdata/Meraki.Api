using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace Meraki.Api.Data
{
	/// <summary>
	/// The way major and minor number should be assigned to nodes in the network. ('Unique', 'Non-unique')
	/// </summary>
	/// <value>The way major and minor number should be assigned to nodes in the network. ('Unique', 'Non-unique')</value>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MajorMinorAssignmentMode
	{
		/// <summary>
		/// Enum Unique for "Unique"
		/// </summary>
		[EnumMember(Value = "Unique")]
		Unique,

		/// <summary>
		/// Enum Nonunique for "Non-unique"
		/// </summary>
		[EnumMember(Value = "Non-unique")]
		Nonunique
	}
}
