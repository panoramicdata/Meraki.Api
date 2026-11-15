namespace Meraki.Api;

// Codacy analyses each file on its own, so it reports 'partial' as gratuitous (S2333) and the static-only parts as S1118. The other parts live in sibling files.
#pragma warning disable S2333, S1118
public partial class CustomNewtonsoftJsonContentSerializer
{
	/// <summary>
	/// gets the field name for property
	/// </summary>
	public string? GetFieldNameForProperty(PropertyInfo propertyInfo)
		=> _serializerIgnore.GetFieldNameForProperty(propertyInfo);

	/// <summary>
	/// Serializes an object to HTTP content
	/// </summary>
	/// <typeparam name="T">The type of the object to serialize</typeparam>
	/// <param name="item">The object to serialize</param>
	/// <returns>The HTTP content containing the serialized object</returns>
	public HttpContent ToHttpContent<T>(T item)
		=> _serializerIgnore.ToHttpContent(item);

	/// <summary>
	/// The missing members found in one response, in document order
	/// </summary>
	private sealed class MissingMemberCollector
	{
		private List<JsonMissingMember>? _missingMembers;

		public IReadOnlyList<JsonMissingMember> MissingMembers => _missingMembers ?? [];

		public JsonSerializationException? FirstException { get; private set; }

		/// <summary>
		/// The type that lacks the member whose contents are being recorded
		/// </summary>
		public string CapturingDeclaringType { get; private set; } = string.Empty;

		public void Add(JsonSerializationException ex, string declaringType, string memberName, string path)
		{
			FirstException ??= ex;
			CapturingDeclaringType = declaringType;
			Add(new JsonMissingMember(declaringType, memberName, path));
		}

		public void Add(JsonMissingMember missingMember)
		{
			_missingMembers ??= [];
			_missingMembers.Add(missingMember);
		}
	}

	/// <summary>
	/// A JsonTextReader that, once told a member is missing, records every property inside that
	/// member's value while Newtonsoft skips it, so members nested inside a missing member are
	/// reported too
	/// </summary>
	private sealed class MissingMemberJsonTextReader(TextReader reader, MissingMemberCollector collector) : JsonTextReader(reader)
	{
		private int _captureDepth = -1;

		public void CaptureMembersInside(int depth)
			=> _captureDepth = depth;

		public override bool Read()
		{
			var read = base.Read();
			if (_captureDepth >= 0)
			{
				// The missing member's value sits at the member's own depth and its contents are deeper.
				// A property at that depth is the next sibling; anything shallower ends the parent object.
				if (!read || Depth < _captureDepth || (Depth == _captureDepth && TokenType == JsonToken.PropertyName))
				{
					_captureDepth = -1;
				}
				else if (Depth > _captureDepth && TokenType == JsonToken.PropertyName)
				{
					collector.Add(new JsonMissingMember(collector.CapturingDeclaringType, (string)Value!, Path));
				}
			}

			return read;
		}
	}
}
