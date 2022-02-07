namespace Meraki.ApiChecker.Extensions;
public static class TypeExtension
{
	public static List<string> GetNonGenericType(this Type type)
	{
		var types = new List<string>();

		if (!type.IsGenericType)
		{
			// It's not a generic type, so we assume the FullName is the actual ReturnType that we are interested in
			types.AddRange(GetMerakiTypesForType(type));
		}
		else
		{
			var typeDefinition = type.GetGenericTypeDefinition();
			// Is it a Task<> of something?
			if (typeDefinition == typeof(Task<>))
			{
				// YES - unwrap it
				var nestedType = type.GetGenericArguments()[0];

				// call self with the unwrapped Type
				types.AddRange(GetNonGenericType(nestedType));
			}

			// Is it a List<> of something?
			if (typeDefinition == typeof(List<>) || typeDefinition == typeof(IEnumerable<>))
			{
				// YES - unwrap it
				typeDefinition = type.GetGenericArguments()[0];
			}

			// We believe we have reached the Meraki Type we are interested in
			types.AddRange(GetMerakiTypesForType(typeDefinition));
		}
		return types;
	}

	private static List<string> GetMerakiTypesForType(Type type)
	{
		var types = new List<string>();
		if (type.Namespace?.StartsWith("Meraki.Api.Data") == true)
		{
			types.Add(type.FullName!);

			// Get type of each Property
			foreach (var property in type.GetProperties())
			{
				types.AddRange(property.PropertyType.GetNonGenericType());
			}
		}

		return types;
	}
}
