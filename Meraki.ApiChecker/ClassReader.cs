using Meraki.Api.Attributes;
using System.Reflection;

namespace Meraki.ApiChecker;
public static class ClassReader
{
	internal static Dictionary<string, List<string>> GetDataClasses()
	{
		// Load our data classes
		var apiAssembly = Assembly.Load("Meraki.Api");
		var classes = apiAssembly
			.GetTypes()
			.Where(
				t => t.IsClass
				&& t.Namespace?.StartsWith("Meraki.Api.Data") == true
				).ToList();

		var deficientClasses = new Dictionary<string, List<string>>();

		foreach (var dataClass in classes.OrderBy(c => c.FullName))
		{
			foreach (var property in dataClass.GetProperties())
			{
				var apiAccessAttribute = property.GetCustomAttributes<ApiAccessAttribute>().ToList();
				if (apiAccessAttribute?.Count > 0)
				{
					continue;
				}

				if (!deficientClasses.TryGetValue(dataClass.FullName!, out var existingList))
				{
					// Create a new list for this class
					deficientClasses[dataClass.FullName!]
						= existingList
						= new List<string>();
				}
				// Add the entry to the list
				existingList.Add(property.Name);
			}
		}

		return deficientClasses;
	}
}
