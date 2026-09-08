namespace Meraki.Api.Exceptions;

/// <summary>
/// Thrown when a paginated response advertises a next page in its <c>Link</c> header that the
/// client cannot follow. Failing loudly is safer than returning the pages fetched so far as a
/// complete result, because a caller can retry but cannot detect a silently truncated list.
/// </summary>
public class PaginationException : Exception
{
	/// <summary>
	/// Initializes a new instance of the PaginationException class
	/// </summary>
	public PaginationException()
	{
	}

	/// <summary>
	/// Initializes a new instance of the PaginationException class with a specified error message
	/// </summary>
	/// <param name="message">The message that describes the error</param>
	public PaginationException(string message)
		: base(message)
	{
	}

	/// <summary>
	/// Initializes a new instance of the PaginationException class with a specified error message and inner exception
	/// </summary>
	/// <param name="message">The message that describes the error</param>
	/// <param name="innerException">The exception that is the cause of the current exception</param>
	public PaginationException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
