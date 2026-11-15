using System.Collections;
using System.Reflection;

namespace Meraki.Api.Test.Data;

internal static class SampleValueFactory
{
	private const int MaxDepth = 3;

	// Models whose property initialiser constructs its own type, so "new T()" overflows the stack.
	public static readonly HashSet<string> Unconstructable = ["FloorPlanBatchDevicesUpdateRequestAssignment"];

	private static readonly Dictionary<Type, Func<object>> _scalars = new()
	{
		[typeof(string)] = () => "sample",
		[typeof(bool)] = () => true,
		[typeof(int)] = () => 7,
		[typeof(long)] = () => 7L,
		[typeof(short)] = () => (short)7,
		[typeof(byte)] = () => (byte)7,
		[typeof(float)] = () => 1.5f,
		[typeof(double)] = () => 1.5d,
		[typeof(decimal)] = () => 1.5m,
		[typeof(Guid)] = () => Guid.Parse("0f8fad5b-d9cb-469f-a165-70867728950e"),
		[typeof(DateTime)] = () => new DateTime(2025, 1, 2, 3, 4, 5, DateTimeKind.Utc),
		[typeof(DateTimeOffset)] = () => new DateTimeOffset(2025, 1, 2, 3, 4, 5, TimeSpan.Zero),
		[typeof(TimeSpan)] = () => TimeSpan.FromMinutes(5),
		[typeof(Uri)] = () => new Uri("https://example.test/"),
		[typeof(object)] = () => "sample"
	};

	public static object? Create(Type type, int depth = 0)
	{
		type = Nullable.GetUnderlyingType(type) ?? type;

		if (_scalars.TryGetValue(type, out var scalar))
		{
			return scalar();
		}

		if (type.IsEnum)
		{
			return Enum.GetValues(type).Cast<object>().LastOrDefault();
		}

		return type.IsArray || typeof(IEnumerable).IsAssignableFrom(type)
			? CreateCollection(type, depth)
			: CreateObject(type, depth);
	}

	public static object? Populate(Type type, int depth = 0)
	{
		if (depth > MaxDepth || type.IsAbstract || Unconstructable.Contains(type.Name) || type.GetConstructor(Type.EmptyTypes) is null)
		{
			return null;
		}

		var instance = Activator.CreateInstance(type)!;
		foreach (var property in WritableProperties(type))
		{
			property.SetValue(instance, Create(property.PropertyType, depth + 1));
		}

		return instance;
	}

	public static IEnumerable<PropertyInfo> WritableProperties(Type type)
		=> type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
			.Where(p => p.CanWrite && p.SetMethod!.IsPublic && p.GetIndexParameters().Length == 0);

	private static object? CreateObject(Type type, int depth)
		=> type.IsClass && !type.IsAbstract && type.Namespace?.StartsWith("Meraki.Api", StringComparison.Ordinal) == true
			? Populate(type, depth)
			: null;

	private static object? CreateCollection(Type type, int depth)
	{
		if (type.IsArray)
		{
			return CreateArray(type.GetElementType()!, depth);
		}

		var arguments = type.IsGenericType ? type.GetGenericArguments() : [typeof(object)];
		return arguments.Length == 2 ? CreateDictionary(arguments, depth) : CreateList(arguments[0], depth);
	}

	private static Array CreateArray(Type elementType, int depth)
	{
		var array = Array.CreateInstance(elementType, 1);
		array.SetValue(Create(elementType, depth + 1), 0);
		return array;
	}

	private static object CreateList(Type elementType, int depth)
	{
		var list = Activator.CreateInstance(typeof(List<>).MakeGenericType(elementType)) as IList ?? throw new InvalidOperationException("List type");
		list.Add(Create(elementType, depth + 1));
		return list;
	}

	private static object CreateDictionary(Type[] arguments, int depth)
	{
		var dictionary = Activator.CreateInstance(typeof(Dictionary<,>).MakeGenericType(arguments)) as IDictionary ?? throw new InvalidOperationException("Dictionary type");
		dictionary.Add(Create(arguments[0], depth + 1)!, Create(arguments[1], depth + 1));
		return dictionary;
	}
}
