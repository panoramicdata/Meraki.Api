namespace RefitClassSourceGenerator;

/// <summary>
/// Attribute to associate a class with a Refit interface type for source generation.
/// </summary>
[AttributeUsage(AttributeTargets.Class)]
public class RefitClassAttribute(Type interfaceType) : Attribute
{
	public Type InterfaceType { get; } = interfaceType;
}
