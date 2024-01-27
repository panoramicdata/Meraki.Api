namespace RefitClassSourceGenerator;

public class RefitClassAttribute(Type interfaceType) : Attribute
{
	public Type InterfaceType { get; } = interfaceType;
}
