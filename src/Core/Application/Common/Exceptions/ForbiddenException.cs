using System.Net;

namespace Template.Application.Common.Exceptions;
public class ForbiddenException : CustomException
{
    public ForbiddenException(string message)
        : base(message, null, HttpStatusCode.Forbidden)
    {
    }
}