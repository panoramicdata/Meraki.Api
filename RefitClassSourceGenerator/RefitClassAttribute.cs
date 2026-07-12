namespace RefitClassSourceGenerator;

/// <summary>
/// Attribute to associate a class with a Refit interface type for source generation.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public class RefitClassAttribute(Type interfaceType) : Attribute
{
	/// <summary>
	/// The Refit interface type whose members are promoted onto the decorated class by the source generator.
	/// </summary>
	public Type InterfaceType { get; } = interfaceType;
}
