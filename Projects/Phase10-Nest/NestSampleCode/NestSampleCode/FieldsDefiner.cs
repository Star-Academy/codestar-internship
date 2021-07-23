using Nest;
using NestSampleCode.Models;

namespace NestSampleCode
{
    internal static class FieldsDefiner
    {
        public static PropertiesDescriptor<Person> AddAboutFieldMapping(this PropertiesDescriptor<Person> prpertiesDescriptor)
        {
            return prpertiesDescriptor
                .Text(t => t
                    .Name(n => n.About)
                    .Fields(f => f
                        .Text(ng => ng
                            .Name("ngram")
                            .Analyzer(Analyzers.NgramAnalyzer))));
        }
    }
}