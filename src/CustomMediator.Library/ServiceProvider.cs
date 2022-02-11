using System;

namespace CustomMediator.Library
{
    public class ServiceProvider
    {
        private static IServiceProvider _serviceProvider;

        public static IServiceProvider GetServiceProvider => _serviceProvider;

        public static void SetInstance(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
    }
}