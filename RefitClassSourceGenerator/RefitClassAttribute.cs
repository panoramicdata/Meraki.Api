using System;

namespace RefitClassSourceGenerator;

public class RefitClassAttribute : Attribute
{
	public RefitClassAttribute(Type interfaceType)
	{
		InterfaceType = interfaceType;
	}

	public Type InterfaceType { get; }
}
