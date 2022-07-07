using System;
using Nest;

namespace NestSampleCode 
{
    internal static class ElasticClientFactory 
    {
        private static IElasticClient client = CreateInitialClient();

        private static IElasticClient CreateInitialClient()
        {
            var uri = new Uri ("http://localhost:9200");
            var connectionSettings = new ConnectionSettings (uri);
            // DebugMode gives you the request in each request to make debuging easier
            // But don't forget to only use it in debugging, because its usage has some overhead
            // and should not be used in production
            connectionSettings.EnableDebugMode();
            return new ElasticClient (connectionSettings);
        }

        public static IElasticClient CreateElasticClient() 
        {
            return client;
        }
    }
}