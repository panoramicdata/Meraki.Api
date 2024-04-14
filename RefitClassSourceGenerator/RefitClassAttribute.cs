namespace RefitClassSourceGenerator;

[AttributeUsage(AttributeTargets.Class)]
public class RefitClassAttribute(Type interfaceType) : Attribute
{
	public Type InterfaceType { get; } = interfaceType;
}
