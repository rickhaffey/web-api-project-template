using System;

namespace WebApiProjectTemplate.Common
{
    public interface IDateTime
    {
        DateTime UtcNow { get; }
    }
}