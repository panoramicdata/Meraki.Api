namespace Meraki.Api.Data;

/// <summary>
/// Task Type
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum TaskType
{
	/// <summary>
	/// Analysis
	/// </summary>
	[EnumMember(Value = "analysis")]
	Analysis,

	/// <summary>
	/// Chain of Thought
	/// </summary>
	[EnumMember(Value = "chain_of_thought")]
	ChainOfThought,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "highlighting")]
	Highlighting,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "summary")]
	Summary,

	/// <summary>
	/// 
	/// </summary>
	[EnumMember(Value = "title")]
	Title
}