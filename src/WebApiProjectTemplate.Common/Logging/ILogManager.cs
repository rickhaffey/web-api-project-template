using System;
using log4net;

namespace WebApiProjectTemplate.Common.Logging
{
    public interface ILogManager
    {
        ILog GetLog(Type typeAssociatedWithRequestedLog);
    }
}