using Meraki.ApiChecker.Data;
using Meraki.ApiChecker.Extensions;
using Meraki.ApiChecker.Models;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Runtime.Serialization;

namespace Meraki.ApiChecker;

// Codacy analyses each file on its own, so it reports 'partial' as gratuitous (S2333) and the static-only parts as S1118. The other parts live in sibling files.
#pragma warning disable S2333, S1118
public static partial class SheetOutput
{
	public static EndpointSet CreateWorksheet(
		OpenApiDocument apiSchema,
		Dictionary<string, List<MethodDetails>>? implementedEndpoints,
		string? tagRestriction)
	{
		var endpointSet = new EndpointSet();

		foreach (var pathKpv in apiSchema.Paths)
		{
			var operations = tagRestriction == null
				? pathKpv.Value.Operations
				: pathKpv.Value.Operations.Where(o => o.Value.Tags.Any(t => t.Name == tagRestriction));

			foreach (var pathOperation in operations)
			{
				AddOperation(endpointSet, implementedEndpoints, pathKpv.Key, pathOperation);
				_ = pathKpv.Value.Operations.Remove(pathOperation);
			}
		}

		return endpointSet;
	}

	/// <summary>
	/// Files one path operation under implemented, duplicated or missing.
	/// </summary>
	private static void AddOperation(
		EndpointSet endpointSet,
		Dictionary<string, List<MethodDetails>>? implementedEndpoints,
		string path,
		KeyValuePair<OperationType, OpenApiOperation> pathOperation)
	{
		var existingImplementations = FindImplementations(implementedEndpoints, path, pathOperation.Key);
		var tags = string.Join(", ", pathOperation.Value.Tags.Select(t => t.Name));

		if (existingImplementations is null || existingImplementations.Count == 0)
		{
			AddMissing(endpointSet, path, pathOperation, tags);
			return;
		}

		if (existingImplementations.Count > 1)
		{
			AddDuplicates(endpointSet, implementedEndpoints, path, pathOperation, tags, existingImplementations);
			return;
		}

		var singleImplementation = existingImplementations[0];
		var methodName = singleImplementation.Method.Name ?? string.Empty;
		var expectedMethodName = pathOperation.Value.OperationId.FirstCharToUpper() + "Async";

		endpointSet.ImplementedEndpoints.Add(new()
		{
			Method = pathOperation.Key.ToString(),
			Endpoint = path,
			OperationId = pathOperation.Value.OperationId,
			Tags = tags,
			Implementation = methodName,
			NewMethodName = expectedMethodName != methodName ? expectedMethodName : string.Empty,
			DeficientDataModels = string.Join(", ", singleImplementation.DeficientDataModels),
			Schema = DescribeResponseSchema(pathOperation.Value, singleImplementation)
		});
		_ = (implementedEndpoints?[path].Remove(singleImplementation));
	}

	/// <summary>
	/// The implementations registered for a path whose Refit verb matches the operation's.
	/// </summary>
	private static List<MethodDetails>? FindImplementations(
		Dictionary<string, List<MethodDetails>>? implementedEndpoints,
		string path,
		OperationType operationType)
	{
		var refitMethod = operationType.ToHttpMethod();
		List<MethodDetails>? pathImplementations = null;
		_ = (implementedEndpoints?.TryGetValue(path, out pathImplementations));

		return pathImplementations?
			.Where(e => e.RefitAttribute.Method == refitMethod)
			.ToList();
	}

	private static void AddMissing(
		EndpointSet endpointSet,
		string path,
		KeyValuePair<OperationType, OpenApiOperation> pathOperation,
		string tags)
		=> endpointSet.MissingEndpoints.Add(new()
		{
			Method = pathOperation.Key.ToString(),
			Endpoint = path,
			OperationId = pathOperation.Value.OperationId,
			Tags = tags,
		});

	/// <summary>
	/// Files every implementation of an operation that has more than one, and takes each out of the
	/// pool so it is not also reported as an implementation without an endpoint.
	/// </summary>
	private static void AddDuplicates(
		EndpointSet endpointSet,
		Dictionary<string, List<MethodDetails>>? implementedEndpoints,
		string path,
		KeyValuePair<OperationType, OpenApiOperation> pathOperation,
		string tags,
		List<MethodDetails> existingImplementations)
	{
		foreach (var duplicateImplementation in existingImplementations)
		{
			endpointSet.DuplicatedEndpoints.Add(new()
			{
				Method = pathOperation.Key.ToString(),
				Endpoint = path,
				OperationId = pathOperation.Value.OperationId,
				Tags = tags,
				Implementation = duplicateImplementation.Method.Name ?? string.Empty,
			});
			_ = (implementedEndpoints?[path].Remove(duplicateImplementation));
		}
	}
}
