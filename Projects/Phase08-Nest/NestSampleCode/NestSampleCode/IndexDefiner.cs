using Nest;
using NestSampleCode.Models;

namespace NestSampleCode
{
    internal class IndexDefiner
    {
        private readonly IElasticClient client;

        public IndexDefiner()
        {
            client = ElasticClientFactory.CreateElasticClient();
        }

        public void CreateIndex(string index)
        {
            var response = client.Indices.Create(index,
                s => s.Settings(settings => settings
                    .Setting("max_ngram_diff", 7)
                    .Analysis(analysis => analysis
                        .TokenFilters(tf => tf
                            .NGram(TokenFilters.NgramFilter, ng => ng
                                .MinGram(3)
                                .MaxGram(10)))
                        .Analyzers(analyzer => analyzer
                            .Custom(Analyzers.NgramAnalyzer, custom => custom
                                .Tokenizer("standard")
                                .Filters("lowercase", TokenFilters.NgramFilter)))))
                        .Map<Person>(m => m
                            .Properties(pr => pr
                                    .Text(t => t
                                        .Name(n => n.About)
                                        .Fields(f => f
                                            .Text(ng => ng
                                                .Name("ngram")
                                                .Analyzer(Analyzers.NgramAnalyzer)))))));
        }
    }
}