<div dir="rtl" align='justify'>

[لیست تسک‌های مرتبط با این فاز به صورت issue template](./issue-template-Phase10.md)

# فاز ده: Nest

در این فاز با کتاب‌خانه‌ی
[NEST](https://www.elastic.co/guide/en/elasticsearch/client/net-api/current/nest.html)
آشنا می‌شوید.

<div id='Introduction'></div>

1. مقدمه

    همان‌طور که احتمالاً در فاز قبل متوجه شدید
    Elasticsearch
    با استفاده از
    [REST API](https://www.elastic.co/guide/en/elasticsearch/reference/current/rest-apis.html)
    قابل استفاده است.
    [مطالعه‌ی بیش‌تر درباره‌ی
    REST](https://restfulapi.net/).
    با توجه به این موضوع می‌توان در هر زبانی با ساخت یک
    Http Connection
    به
    Elasticsearch
    درخواست داد و 
    Queryهای
    مورد نظر را اجرا کرد.

    در زبان
    #C
    با استفاده از کلاس
    [HttpClient](https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient?view=netcore-3.1)
    به
    Elasticsearch
    متصل شوید و ضمن ساخت یک
    index
    [این اشخاص](https://github.com/Star-Academy/codestar-internship/raw/master/Projects/Phase09-Elasticsearch/people.json)
    را به صورت یکی یکی
    (بدون استفاده از
    Bulk API)
    در آن
    بارگذاری کنید.

    پ.ن: در این قسمت علاوه بر اتصال به
    Elasticsearch
    یادگیری نحوه‌ی استفاده از
    HttpClient
    نیز مد نظر است.

    پ.ن 2: کلاس
    HttpClient
    از واسط
    IDisposable
    ارث‌بری می‌کند اما با سایر
    IDisposableها
    تفاوت دارد که در
    [این لینک](https://medium.com/@nuno.caneco/c-httpclient-should-not-be-disposed-or-should-it-45d2a8f568bc)
    می‌توانید درباره‌ی آن مطالعه کنید.

1. آشنایی با کتاب‌خانه‌ی
NEST

    تا این‌جای کار متوجه شدیم که اتصال به
    Elasticsearch
    در زبان
    #C
    با استفاده از
    HttpClient
    امکان‌پذیر است اما استفاده از آن دشوار و زمان‌بر است. کتاب‌خانه‌ی
    [NEST](https://www.elastic.co/guide/en/elasticsearch/client/net-api/current/nest.html)
    یک رابط سطح بالا برای اتصال به
    Elasticsearch
    ارائه می‌دهد که به خاطر ویژگی
    strongly typed
    بودن کار با آن به صورت شیءگرا را بسیار ساده می‌کند.

    حالا می‌خواهیم کاری را که در قسمت
    <a href='#Introduction'>مقدمه</a>
    انجام دادیم این بار با استفاده از این کتاب‌خانه انجام دهیم.

    1. یک پروژه‌ی سی‌شارپ بسازید و
        [NuGet Package
        این کتاب‌خانه](https://www.nuget.org/packages/NEST/)
        را در آن اضافه کنید.

    1. با استفاده از تکه کد زیر
    یک شیء از کلاس
    `ElasticClient`
    ایجاد کنید:

    <div dir='ltr'>

    ```csharp
    var uri = new Uri ("http://localhost:9200");
    var connectionSettings = new ConnectionSettings (uri);
    // DebugMode gives you the request in each request to make debuging easier
    // But don't forget to only use it in debugging, because its usage has some overhead
    // and should not be used in production
    connectionSettings.EnableDebugMode();
    var client = new ElasticClient (connectionSettings);
    ```

    </div>

    1. با استفاده از تکه کد زیر از درستی اتصال خود اطمینان حاصل کنید:

    <div dir='ltr'>

    ```csharp
    var response = client.Ping();
    ```

    </div>

    1. یک کلاس مدل برای
    Person
    ایجاد کنید:

        <div dir='ltr'>

        ```csharp
        public class Person 
        {
            [JsonPropertyName("age")]
            public int Age {get;set;}

            [JsonPropertyName("eyeColor")]
            public string EyeColor {get;set;}

            [JsonPropertyName("name")]
            public string Name {get;set;}

            [JsonPropertyName("gender")]
            public string Gender {get;set;}

            [JsonPropertyName("company")]
            public string Company {get;set;}

            [JsonPropertyName("email")]
            public string Email {get;set;}

            [JsonPropertyName("phone")]
            public string Phone {get;set;}

            [JsonPropertyName("address")]
            public string Address{get;set;}

            [JsonPropertyName("about")]
            public string About {get;set;}

            [JsonPropertyName("registration_date")]
            public string RegistrationDate {get;set;}

            [Ignore]
            [JsonPropertyName("latitude")]
            public double Latitude {get;set;}

            [Ignore]
            [JsonPropertyName("longitude")]
            public double Longitude {get;set;}

            private string location = null;
            public string Location
            {
                get
                {
                    if (location is null)
                        return $"{Latitude},{Longitude}";
                    return location;
                }
                set
                {
                    location = value;
                }
            } 
        }
        ```

        </div>

        در این کلاس به
        [Attribute](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/attributes/)های
        Ignore
        و
        JsonPropertyName
        دقت کنید و علت استفاده از آن‌ها را توضیح دهید.
    
        هم‌چنین به نحوه‌ی تعریف
        Location
        نیز دقت کنید.

    1. با استفاده از کلاس مدل تعریف شده فایل
    JSON
    داده‌ها را بخوانید.

    1. یک
    index
    با
    mapping
    مناسب برای این اشخاص تعریف کنید.
    یک مثال برای تعریف
    index
    همراه با
    mapping
    در زیر آمده است:

        <div dir='ltr'>

        ```csharp
        var index = "my-index";
        var response = client.Indices.Create(index,
                s => s.Settings(settings => settings
                    .Setting("max_ngram_diff", 7)
                    .Analysis(analysis => analysis
                        .TokenFilters(tf => tf
                            .NGram("my-ngram-filter", ng => ng
                                .MinGram(3)
                                .MaxGram(10)))
                        .Analyzers(analyzer => analyzer
                            .Custom("my-ngram-analyzer", custom => custom
                                .Tokenizer("standard")
                                .Filters("lowercase", "my-ngram-filter")))))
                        .Map<Person>(m => m
                            .Properties(pr => pr
                                    .Text(t => t
                                        .Name(n => n.About)
                                        .Fields(f => f
                                            .Text(ng => ng
                                                .Name("ngram")
                                                .Analyzer("my-ngram-analyzer")))))));
        ```

        </div>

        با اجرای این مثال توضیح دهید
        Mapping
        تعریف‌شده چه
        Fieldهایی
        دارد.
        از
        [این لینک](https://www.elastic.co/guide/en/elasticsearch/client/net-api/current/multi-fields.html)
        می‌توانید کمک بگیرید.

    1. با استفاده از تکه‌کد زیر (احتمالاً با کمی تغییر)
    داده‌ها را در
    index
    ایجاد شده بریزید:

        <div dir='ltr'>

        ```csharp
        var bulkDescriptor = new BulkDescriptor();
        foreach (var person in people)
        {
            bulkDescriptor.Index<Person>(x => x
                .Index(index)
                .Document(person)
            );
        }
        client.Bulk(bulkDescriptor);
        ```

        </div>


1. اجرای
Queryهای
جستجو

    در این قسمت انواع
    Queryهایی
    که در فاز قبل اجرا کردید را روی داده‌ها با استفاده از
    NEST
    اجرا کنید. در این راه احتمالاً
    [این لینک](https://www.elastic.co/guide/en/elasticsearch/client/net-api/current/query-dsl.html)
    به کمک شما می‌آید.

    یک مثال به دو صورت در زیر آمده است:

    <div dir='ltr'>

    ```csharp
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
    ```

    </div>

1. آشنایی با مفهوم
Near Real Time

    وقتی در
    Elasticsearch
    داده‌ای را
    index
    می‌کنیم همان لحظه برای جستجو در دسترس نیست. در این باره
    [این لینک](https://www.elastic.co/guide/en/elasticsearch/reference/master/near-real-time.html)
    را مطالعه کنید.

    با توجه به این موضوع برای این که یک سند بارگذاری شده قابل جستجو باشد باید
    index
    مورد نظر
    [refresh](https://www.elastic.co/guide/en/elasticsearch/reference/master/indices-refresh.html)
    شود.

1. آشنایی با
Queryهای
سیستمی
Elasticsearch

    هر یک از تکه‌کدهای زیر را اجرا کنید و توضیح دهید خروجی هر کدام چیست؟

    <div dir='ltr'>

    * [Cluster health](https://www.elastic.co/guide/en/elasticsearch/reference/current/cluster-health.html)

    ```csharp
    var response = client.Cluster.Health();
    ```

    * [cat nodes](https://www.elastic.co/guide/en/elasticsearch/reference/current/cat-nodes.html)

    ```csharp
    var response = client.Cat.Nodes();
    ```

    * [cat indices](https://www.elastic.co/guide/en/elasticsearch/reference/current/cat-indices.html)

    ```csharp
    var response = client.Cat.Indices();
    ```

    </div>

1. Response Validation

    پاسخی که
    NEST
    از
    Elasticsearch
    دریافت می‌کند در قالب یک
    `IResponse`
    در اختیار ما قرار می‌گیرد که البته از یکی از کلاس‌هایی است که این
    interface
    را پیاده‌سازی کرده‌اند.
    گاهی اوقات اجرای
    Query
    با مشکل مواجه می‌شود که این مشکلات در پاسخی که در اختیار ما قرار می‌گیرد یا در قالب
    Exception
    و یا در یکی از
    Propertyهای
    IResponse
    توضیح داده می‌شوند.
    در
    [این لینک](https://www.elastic.co/guide/en/elasticsearch/client/net-api/1.x/handling-responses.html)
    در این باره مطالعه کنید و یک
    Validator
    برای
    Responseها
    پیاده سازی کنید.

1. پروژه

    یک اپلیکیشن به زبان سی‌شارپ بنویسید که مانند فاز یک کار کند با این تفاوت که به جای این که ساخت
    Index
    و جستجو را خودتان پیاده‌سازی کنید از امکانات
    Elasticsearch
    استفاده کنید.
    از 
    Response Validatorی
    که در قسمت قبل نوشتید در این اپلیکیشن استفاده کنید.

1. برای علاقه‌مندان

    اگر علاقه‌مندید درباره‌ی کتاب‌خانه‌ی 
    [FluentNest](https://www.nuget.org/packages/FluentNest)
    نیز مطالعه کنید.

<br></br>
یک نمونه کد در
[این‌جا](https://github.com/Star-Academy/codestar-internship/raw/master/Projects/Phase10-Nest/NestSampleCode)
موجود است.
</div>

موفق باشید



