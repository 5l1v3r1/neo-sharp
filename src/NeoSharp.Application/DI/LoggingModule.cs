﻿using NeoSharp.Core.DI;
using NeoSharp.Core.Logging;
using NeoSharp.Logging.NLog;

namespace NeoSharp.Application.DI
{
    public class LoggingModule : IModule
    {
        public void Register(IContainerBuilder containerBuilder)
        {
            containerBuilder.RegisterSingleton<Microsoft.Extensions.Logging.ILoggerFactory, NLogLoggerFactory>();
            containerBuilder.RegisterSingleton(typeof(ILogger<>), typeof(LoggerAdapter<>));
        }
    }
}