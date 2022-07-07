using System.Collections.Generic;
using Nest;
using NestSampleCode.Models;

namespace NestSampleCode
{
    public static class SampleQueries
    {
        private static IElasticClient client = ElasticClientFactory.CreateElasticClient();

        public static void BoolQuerySample1()
        {
            QueryContainer query = new BoolQuery
            {
                Must = new List<QueryContainer>
                {
                    new MatchQuery
                    {
                        Field = "about",
                        Query = "Labore"
                    }
                }
            };
            var response = client.Search<Dictionary<string, object>>(s => s
                .Index("my-index")
                .Query(q => query));
        }

        public static void BoolQuerySample2()
        {
            var response = client.Search<Person>(s => s
                .Index("my-index")
                .Query(q => q
                    .Bool(b => b
                        .Must(must => must
                            .Match(match => match
                                .Field(p => p.About)
                                .Query("Labore"))))));
        }
    }
}