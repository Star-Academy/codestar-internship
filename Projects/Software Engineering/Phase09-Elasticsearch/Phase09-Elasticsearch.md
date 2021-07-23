<div dir="rtl" align='justify'>

[لیست تسک‌های مرتبط با این فاز به صورت issue template](./issue-template-Phase09.md)

# فاز نه: Elasticsearch

در این فاز با موتور جستجوی
Elasticsearch
و نحوه‌ی کار کردن با آن آشنا می‌شوید.

1. مقدمه

    در سال‌های اخیر با توجه به رشد روزافزون خدمات مبتنی بر نرم‌افزار و تولید مقادیر زیادی داده، امکان جستجو در این داده‌ها اهمیت فوق‌العاده‌ای پیدا کرده است.
    هم‌چنین علاوه بر داده‌هایی که مربوط به فعالیت کاربران در بسترهای مجازی است، خود سیستم‌های نرم‌افزاری مقادیر زیادی
    log
    تولید می‌کنند که امکان جستجو در آن‌ها می‌تواند کار را برای مدیران سیستم و توسعه‌دهندگان بسیار ساده‌تر کند.
    در هر محصول نرم‌افزاری به احتمال قوی کاربر به امکان جستجو نیاز دارد که برای ایجاد این امکان می‌توان از موتورهای جستجو استفاده کرد. محصولات متفاوتی در این حوزه وجود دارند که در حال حاضر معروف‌ترین و محبوب‌ترین آن‌ها
    Elasticsearch
    نام دارد.


    Elasticsearch
    یک موتور جستجوی
    Full-text
    است که به طور متن‌باز توسعه داده می‌شود. این محصول به کاربران این امکان را می‌دهد که در تعداد زیادی سند متنی جستجو کنند. 
    این موتور جستجو توسط بسیاری از شرکت‌های نرم‌افزاری دنیا مورد استفاده قرار گرفته است. هم‌چنین در محبوبیت آن همین بس که در
    github
    بیش از 50هزار ستاره دریافت کرده است.
    این موتور جستجو کاربردهای فراوانی در حوزه‌های مختلف دارد که از این کاربردها می‌توان به امکان ارائه‌ی جستجو در محصولات نرم‌افزاری و جمع‌‌آوری و تحلیل
    logهای
    سیستم‌های نرم‌افزاری اشاره کرد.

    علاوه بر خود
    Elasticsearch
    چندین محصول دیگر به عنوان
    Elastic Stack
    نیز وجود دارند که از مهم‌ترین آن‌ها می‌توان به
    Kibana،
    Logstash
    و
    APM
    اشاره کرد.

    * Kibana

        این محصول امکان مدیریت کلاستر
    Elasticsearch
    و
    Visualize
    کردن داده‌ها در داشبوردها و نمودارهای مختلف را به مدیر سیستم می‌دهد.

    * Logstash

        با این محصول می‌توان
        Logهای
        سیستم را جمع‌آوری کرد که در ادامه بتوان راحت‌تر آن‌ها را مورد تحلیل و بررسی قرار داد.
    
    * APM (Application Performance Monitoring)

        این محصول به ایجادکنندگان نرم‌افزار این امکان را می‌دهد تا نرم‌افزار خود را از نظر کارایی مورد نظارت قرار دهند به این صورت که می‌توانند زمانی که صرف هر یک از قسمت‌های نرم‌افزار و یا فراخوانی هر یک از توابع شده است را اندازه‌گیری کنند و متوجه گلوگاه‌های سیستم شوند.

1. Elasticsearch کمی عمیق‌تر

    برای آشنایی با موتور جستجوی
    Elasticsearch
    مطالعه‌ی لینک زیر مفید است:

    <div dir="ltr">

    - [What is Elasticsearch?](https://www.elastic.co/guide/en/elasticsearch/reference/current/elasticsearch-intro.html)
    
    </div>

    شما در فاز 1، جستجو در اسناد متنی را به وسیله‌ی
    Inverted Index
    پیاده‌سازی کردید. موتور جستجوی
    Elasticsearch
    نیز قابلیتی مشابه پروژه‌ی شما ارائه می‌دهد.
    این قابلیت شامل
    index
    کردن اسناد متنی و سپس جستجو در آن‌ها می‌شود که البته امکانات بسیار پیشرفته‌تری را نیز در بردارد. تعدادی از این امکانات در زیر آمده است:
    
    * امکانات معماری

        - توزیع‌شدگی
        
            شما می‌توانید
        Elasticsearch
        را روی چندین سرور نصب کنید و آن‌ها را به یک دیگر متصل کنید و این سرورها با همکاری یکدیگر قدرت و سرعت بیش‌تری را در اختیار شما قرار دهند.

        - مقیاس‌پذیری

            با افزودن تعداد سرورها می‌توانید مقادیر بیش‌تری داده در
        Elasticsearch
        بریزید و کماکان سرعت بالای
        index
        کردن و جستجو حفظ شود.
        توضیحات بیش‌تر در
        [Scalability and resilience: clusters, nodes, and shards](https://www.elastic.co/guide/en/elasticsearch/reference/current/scalability.html).

    * امکانات کارکردی

        * Dynamic Mapping

            سندی که می‌خواهید در
        Elasticsearch
        بریزید می‌تواند هر ساختاری داشته باشد و لازم نیست از قبل ساختار آن را در
        Elasticsearch
        تعیین کنید چرا که به طور خودکار آن را تشخیص می‌دهد و ساختار مناسب را تعریف می‌کند.
        در
        [اینجا](https://www.elastic.co/guide/en/elasticsearch/reference/current/dynamic-mapping.html)
        می‌توانید در این باره بیش‌تر مطالعه کنید.

        * Normalization
        
            Elasticsearch
            امکانات نرمال‌سازی متن پیشرفته از جمله
            Analyzer
            ها و 
            Tokenizer
            های مختلفی دارد که کار کاربر را بسیار ساده می‌کند.

        * پشتیبانی از انواع مختلف داده

            به غیر از مقادیر متنی می‌توان داده‌های عددی، تاریخی و یا مختصات مکانی و ... را در
            Elasticsearch
            ریخت و روی آن‌ها جستجو کرد. برای مثال فقط در سندهای یک بازه‌ی زمانی خاص و یا سندهای یک محدوده‌ی جغرافیایی خاص جستجو کرد.

        * پشتیبانی از جستجوی
        Fuzzy
        و
        زیررشته
        
            در بسیاری مواقع کاربران ممکن است مقداری از عبارت را به اشتباه تایپ کنند یا فقط زیررشته‌ای از یک عبارت را جستجو کنند.
            Elasticsearch
            از این نوع جستجوها نیز پشتیبانی می‌کند.

1. آشنایی با مفاهیم

    در
    Elasticsesarch
    چندین مفهوم مطرح می‌شود که در زیر توضیح داده شده‌اند:

    * Cluster

        همان‌طور که گفته شد
        Elasticsearch
        توزیع‌شده است. به تعدادی از سرورها که به یکدیگر متصل هستند و سرویس
        Elasticsearch
        را ارائه می‌دهند
        Elasticsearch Cluster
        گفته می‌شود.

    * Node

        به هر یک از سرورهای
        Elasticsearch
        در یک
        Cluster
        یک
        Node
        گفته می‌شود که
        Nodeها
        نقش‌های مختلفی بر عهده دارند که با توجه به نقش آن‌ها به چند دسته تقسیم می‌شوند که مهم‌ترین آن‌ها
        Master Node
        و
        Data Node
        هستند. برای مطالعه‌ی بیش‌تر می‌توانید به
        [این‌جا](https://www.elastic.co/guide/en/elasticsearch/reference/current/modules-node.html)
        مراجعه کنید.

    * Document

        به هر یک از سندهای متنی که در
        Elasticsearch
        بارگذاری می‌شود
        Document
        گفته می‌شود. این مفهوم، مفهومی فراتر از
        Elastcisearch
        است و کلاً در حوزه‌ی بازیابی اطلاعات مورد استفاده قرار می‌گیرد.
        برای مثال فرض کنید بخواهیم در غزل‌های حافظ جستجو کنیم در این صورت بسته به کاربرد ممکن است هر یک از ابیات به عنوان یک
        Document
        در نظر گرفته شوند و یا هر یک از غزل‌ها یک
        Document
        به حساب بیایند.

    * Index

        در
        Elasticsearch
        مفهوم
        Index
        به هر یک از مخازنی گفته می‌شود که تعدادی
        Document
        با قالب مشابه در آن قرار گرفته‌اند برای مثال می‌توان آن را با یک جدول در پایگاه داده‌های رابطه‌ای مقایسه کرد که البته این دو مفهوم یکسان نیستند و تفاوت‌هایی دارند که فعلاً از آن‌ها چشم‌پوشی می‌کنیم.

        پ.ن: علاوه بر مفهوم گفته‌شده از عبارت
        Index
        به صورت فعلی به معنای ریختن داده در
        Elasticsearch
        استفاده می‌شود.

    * Mapping

        در هر
        Index
        سندها قالب مشخصی دارند که به این قالب
        Mapping
        گفته می‌شود. برای مثال اگر بخواهیم مشخصات تعدادی دانشجو را در
        Elasticsearch
        بریزیم و هر دانشجو را یک
        Document
        در نظر بگیریم، هر دانشجو نام، نام خانوادگی، رشته، تاریخ ورود، سن، معدل و ... دارد که از هر کدام از این موارد در
        Elasticsearch
        با عنوان
        Field
        یاد می‌شود. هر کدام از این
        Fieldها
        نوع مشخصی دارد برای مثال نام‌، نام خانوادگی و رشته از نوع
        text
        هستند و مثلاً سن از نوع عدد طبیعی و معدل از جنس عدد اعشاری است و تاریخ ورود می‌تواند از جنس تاریخ در نظر گرفته شود. به این قالب که
        Fieldهای
        مختلف و جنس هر کدام را مشخص می‌کند
        Mapping
        گفته می‌شود.

    * Shard

        همان‌طور که پیش‌تر اشاره شد
        Elasticsearch
        به صورت توزیع‌شده است که می‌توان داده را در چندین سرور توزیع کرد. نحوه‌ی توزیع به این صورت است که هر
        Index
        دارای تعدادی
        Shard
        است که این
        Shardها
        به طور متوازن بین سرورها توزیع می‌شوند. برای مثال اگر 5 سرور داشته باشیم و یک
        Index
        دارای 10 شارد باشد سهم هر سرور 2 شارد خواهد بود یعنی 2 شارد روی آن سرور نگه‌داری می‌شود.
        حالا فرض کنید که یکی از سرورها دچار مشکل شود که در این صورت آن قسمت از داده که در اختیار آن سرور بوده است از دسترس خارج می‌شود.
        Elasticsearch
        برای این موضوع نیز راه‌حلی اندیشیده است به این صورت که با توجه به میزان اهمیت داده می‌توان از هر یک از
        Shardها
        تعدادی کپی داشت که در صورت از دسترس خارج شدن داده‌ی اصلی، داده هم‌چنان از طریق آن کپی‌ها در دسترس باشد.
        به
        Shardهای
        اصلی
        Primary Shard
        و 
        به کپی‌ها
        Replica Shard
        گفته می‌شود.

    * Segment

        هر یک از
        Shardها
        دارای تعدادی
        Segment
        است. علت وجود این
        Segmentها
        این است که
        Elasticsearch
        بر پایه‌ی
        [Apache Lucene](https://lucene.apache.org/)
        ایجاد شده است. به اختصار می‌توان گفت که
        Apache Lucene
        سرویس جستجو را ارائه می‌دهد اما تنها روی یک ماشین بدون قابلیت‌های توزیع‌شدگی که
        Elasticsearch
        قابلیت توزیع‌شدگی را به آن اضافه می‌کند. در حقیقت هر یک از
        Shardها
        یک
        Instance
        از نرم‌افزار
        Lucene
        است.

    به طور خلاصه می‌توان گفت در
    Elasticsearch
    هر
    Cluster
    تعدادی
    Node
    دارد. هر
    Node
    میزبان تعدادی
    Shard
    است که هر
    Shard
    از تعدادی
    Segment
    تشکیل شده است.
    هر
    Index
    از تعدادی
    Shard
    تشکیل شده است.


    برای مطالعه‌ی بیش‌تر درباره‌ی
    Indexها
    و
    Documentها
    [اینجا](https://www.elastic.co/guide/en/elasticsearch/reference/current/documents-indices.html)
    کلیک کنید.

1. نصب و راه‌اندازی
Elasticsearch
و
Kibana

    1. ابتدا
    Elasticsearch
    متناسب با سیستم‌عامل خود را از
    [اینجا](https://www.elastic.co/downloads/elasticsearch)
    دریافت و نصب کنید.
    
    1. سپس
    Kibana
    متناسب با سیستم‌عامل خود را از
    [اینجا](https://www.elastic.co/downloads/kibana)
    دریافت و نصب کنید.

        پ.ن: لینک‌های داده شده تحریم هستند که برای رفع تحریم باید از 
        VPN
        و یا
        [سرویس شکن](https://shecan.ir/)
        استفاده کنید.

        پ.ن 2:
        اگر از یکی از توزیع‌های سیستم‌عامل لینوکس استفاده می‌کنید می‌توانید برای نصب این دو برنامه از
        Package Manager
        ها نیز استفاده کنید.

    1. Elasticsearch
    و
    Kibana
    را اجرا کنید.

        به طور پیش‌فرض 
    Elasticsearch
    روی پورت 9200 و 
    Kibana
    روی پورت 5601
    راه‌اندازی می‌شود.
    برای اطمینان از درستی اجرای آن‌ها می‌توانید در مرورگر خود آدرس‌های زیر را تست کنید و مطمئن شوید که این دو برنامه به درستی کار می‌کنند:
    
    <div dir="ltr">

    * [http://localhost:9200/](http://localhost:9200/)

    * [http://localhost:5601/](http://localhost:5601/)

    </div>

1. ایجاد index

    1. برای اجرای
    query
    ها از قسمت
    Dev Tools
    در
    Kibana
    استفاده کنید.

    1. ابتدا با اجرای
    Query
    زیر یک
    index
    به نام 
    `people-simple`
    در 
    Elasticsearch
    ایجاد کنید:

    <div dir="ltr">

    ```json
    PUT /people-simple
    ```

    </div>


    در
    [این لینک](https://www.elastic.co/guide/en/elasticsearch/reference/current/indices-create-index.html)
    توضیحات بیش‌تری درباره‌ی ایجاد
    index
    داده شده است.

    <div id='indexing-documents'></div>

1. بارگذاری اسناد متنی

    1. فایل
    [people-simple.json](https://github.com/Star-Academy/codestar-internship/raw/master/Projects/Phase09-Elasticsearch/people-simple.json)
    را دریافت کنید که در آن مشخصات چند شخص در قالب 
    JSON
    آورده شده است.

    1. این اشخاص را در
    index
    ایجاد شده بریزید. 
    برای این کار می‌توانید از
    [این لینک](https://www.elastic.co/guide/en/elasticsearch/reference/current/docs-index_.html)
    کمک بگیرید.

        مثالی نیز در زیر آمده است:

        <div dir="ltr">

        ```json
        POST /people-simple/_doc/
        {
            "name": "Ali",
            "last_name": "Mohammad",
            "age": 50
        }
        ```

        </div>

    1. با استفاده از
    Query
    زیر از درستی کار خود مطمئن شوید:

    <div dir="ltr">

    ```json
    GET /people-simple/_search
    ```

    </div>

1. جستجو در اسناد متنی بارگذاری شده

    انواع مختلف 
    Query
    به ویژه
    Query
    های زیر را امتحان کنید و امکانات هر یک از آن‌ها و تفاوت آن‌ها را با توجه به نتایج به دست‌آمده دریابید:

    * [Match Query](https://www.elastic.co/guide/en/elasticsearch/reference/current/query-dsl-match-query.html)
    
    <div dir="ltr">

    ```json
    GET /people-simple/_search
    {
        "query":{
            "match": {
                "name": "mohammad"
            }
        }
    }
    ```

    </div>  


    * [Fuzzy Query](https://www.elastic.co/guide/en/elasticsearch/reference/current/query-dsl-fuzzy-query.html)

    <div dir="ltr">

    ```json
    GET /people-simple/_search
    {
        "query": {
            "match": {
                "name": {
                    "query": "mohammad",
                    "fuzziness": 1
                }
            }
        }
    }
    ```

    </div> 

    * [Term Query](https://www.elastic.co/guide/en/elasticsearch/reference/current/query-dsl-term-query.html)

    <div dir="ltr">

    ```json
    GET /people-simple/_search
    {
        "query": {
            "term": {
                "name": {
                    "value": "mohammad"
                }
            }
        }
    }
    ```

    </div> 

    * [Range Query](https://www.elastic.co/guide/en/elasticsearch/reference/current/query-dsl-range-query.html)

    <div dir="ltr">

    ```json
    GET /people-simple/_search
    {
        "query": {
            "range": {
                "age": {
                    "gte": 24,
                    "lte": 35
                }
            }
        }
    }
    ```

    </div> 

    * [Multi-match Query](https://www.elastic.co/guide/en/elasticsearch/reference/current/query-dsl-multi-match-query.html)

    <div dir="ltr">

    ```json
    GET /people-simple/_search
    {
        "query": {
            "multi_match": {
                "query": "mohammad",
                "fields": ["name", "last_name"],
                "fuzziness": 1
            }
        }
    }
    ```

    </div> 

    * [Bool Query](https://www.elastic.co/guide/en/elasticsearch/reference/current/query-dsl-bool-query.html)

    <div dir="ltr">

    ```json
    GET /people-simple/_search
    {
        "query": {
            "bool": {
                "must": [
                    {
                        "match": {
                            "name": {
                                "query": "mohammad",
                                "fuzziness": 1
                            }
                        }
                    }
                ],
                "should": [
                    {
                        "range": {
                            "age": {
                                "gte": 10,
                                "lte": 30
                            }
                        }
                    }
                ]
            }
        }
    }
    ```

    </div> 

    <div dir="ltr">

    ```json
    GET /people-simple/_search
    {
        "query": {
            "bool": {
                "must": [
                    {
                        "match": {
                            "name": {
                                "query": "mohammad",
                                "fuzziness": 1
                            }
                        }
                    }
                ],
                "must_not": [
                    {
                        "match": {
                            "last_name": "mostmand"
                        }
                    }
                ]
            }
        }
    }
    ```

    </div> 

    <div dir="ltr">

    ```json
    GET /people-simple/_search
    {
        "query": {
            "bool": {
                "must": [
                    {
                        "match": {
                            "name": {
                                "query": "mohammad",
                                "fuzziness": 1
                            }
                        }
                    },
                    {
                        "match": {
                            "last_name": "mostmand"
                        }
                    }
                ]
            }
        }
    }
    ```

    </div> 

    برای آشنایی بیش‌تر با
    Query
    های مختلف که
    Elasticsearch
    در اختیار کاربر می‌گذارد می‌توانید از لینک زیر کمک بگیرید:

    * [Query DSL](https://www.elastic.co/guide/en/elasticsearch/reference/current/query-dsl.html)

1. Text Analysis

    برای این که بتوان در اسناد متنی جستجو کرد نیاز است تا این اسناد نرمال‌سازی شوند. برای مثال باید حروف کلمات
    lowercase
    شوند و یا کلاً این که یک متن به کلمات شکسته شود و هم هنگام
    index
    کردن و هم هنگام جستجو این اتفاق بیفتد.

    Elasticsearch
    در این زمینه امکانات زیادی ارائه می‌دهد. برای استفاده از این امکانات باید هنگام تعریف
    index
    از
    Analyzerها
    و
    Tokenizerهای
    مناسب استفاده کرد. ابتدا به توضیحی از این مفاهیم می‌پردازیم:

    * Analyzer

        مجموعه‌ای از
        Tokenizerها
        و
        Normalizerها
        که برای هر
        Field
        در
        Mapping
        تعریف می‌شود و نحوه‌ی برخورد با مقادیر آن
        Field
        را مشخص می‌کند.

    * Tokenizer

        وقتی می‌خواهیم یک عبارت متنی را
        index
        کنیم برای این که قابل جستجو باشد باید آن را به بخش‌های کوچک‌تر به نام
        Token
        تجزیه کنیم.
        Tokenizer
        این وظیفه را بر عهده دارد. انواع
        Tokenizer
        وجود دارد که ساده‌ترین و متداول‌ترین نوع آن شکستن عبارت به کلمات تشکیل‌دهنده‌ی آن است.

    * Normalizer
    
        انتظار داریم وقتی کلمه‌ی
        'quick'
        را جستجو می‌کنیم سندهایی که دارای کلمه‌ی
        'Quick'
        هستند نیز در نتایج ظاهر شوند بنابراین نیاز است تا همه‌ی کلمات را نرمال کنیم که در اینجا
        lowercase
        کردن کاراکترها می‌تواند مناسب باشد.

    تفاوت
    Normalizer
    با
    Tokenizer
    در این است که
    Normalizer
    یک
    Token
    ورودی می‌گیرد و یک
    Token
    خروجی می‌دهد اما
    Tokenizer
    یک عبارت ورودی می‌گیرد و تعدادی
    Token
    خروجی می‌دهد.

    برای مطالعه‌ی بیش‌تر می‌توانید از
    [این لینک](https://www.elastic.co/guide/en/elasticsearch/reference/current/analysis.html)
    استفاده کنید.

1. استفاده از
Analyzerها

    در قسمت
    <a href='#indexing-documents'>بارگذاری اسناد متنی</a>
    ما
    Analyzerی
    تعیین نکردیم و
    Elasticsearch
    با توجه به ساختار سندهایی که در آن بارگذاری کردیم از
    Analyzerهای
    پیش‌فرض استفاده کرد.
    با اجرای
    Query
    زیر می‌توانید
    Mapping
    پیش‌فرض ایجاد شده برای
    هر
    Field
    را مشاهده کنید:

    <div dir='ltr'>

    ```json
    GET people-simple/_mapping
    ```

    </div>

    حال می‌خواهیم
    Mapping
    و
    Analyzerها
    را خودمان تعیین کنیم.

    1. ابتدا با استفاده از
    [Analyze API](https://www.elastic.co/guide/en/elasticsearch/reference/current/indices-analyze.html)
    نتیجه‌ی استفاده از چند مورد از
    Analyzerها
    را مشاهده می‌کنیم.
    در زیر چند
    Query
    آورده شده است که اجرای آن‌ها به روشن کردن قضیه کمک می‌کند:

    <div dir='ltr'>

    ```json
    POST _analyze
    {
        "analyzer": "whitespace",
        "text": "The quick brown fox."
    }
    ```

    </div>

    موارد استفاده شده:

    * [Whitespace Analyzer](https://www.elastic.co/guide/en/elasticsearch/reference/current/analysis-whitespace-analyzer.html)

    <br></br>

    <div dir='ltr'>

    ```json
    POST _analyze
    {
        "analyzer": "standard",
        "text": "The quick brown fox."
    }
    ```

    </div>

    موارد استفاده شده:

    * [Standard Analyzer](https://www.elastic.co/guide/en/elasticsearch/reference/current/analysis-standard-analyzer.html)

    <br></br>

    <div dir='ltr'>

    ```json
    POST _analyze
    {
        "tokenizer": "standard",
        "filter": [ "lowercase", "asciifolding" ],
        "text": "Is this déja vu?"
    }
    ```

    </div>

    موارد استفاده شده:

    * [Standard Tokenizer](https://www.elastic.co/guide/en/elasticsearch/reference/current/analysis-standard-tokenizer.html)

    * [Lowercase Token Filter](https://www.elastic.co/guide/en/elasticsearch/reference/current/analysis-lowercase-tokenfilter.html)

    * [ASCII Folding Token Filter](https://www.elastic.co/guide/en/elasticsearch/reference/current/analysis-asciifolding-tokenfilter.html)

    <br></br>

    حالا می‌خواهیم یک
    Analyzer
    مناسب خودمان ایجاد کنیم که
    Query
    زیر مثالی از آن است:

    <div dir='ltr'>

    ```json
    PUT people-simple2
    {
        "settings": {
            "index": {
            "max_ngram_diff": 7
            },
            "analysis": {
                "analyzer": {
                    "my_ngram_analyzer": {
                        "type": "custom",
                        "tokenizer": "standard",
                        "filter": [
                            "lowercase",
                            "my_ngram_filter"
                        ]
                    }
                },
                "filter": {
                    "my_ngram_filter": {
                        "type": "ngram",
                        "min_gram": 3,
                        "max_gram": 10
                    }
                }
            }
        }
    }
    ```

    </div>

    موارد استفاده شده:

    * [Custom Analyzer](https://www.elastic.co/guide/en/elasticsearch/reference/current/analysis-custom-analyzer.html)

    * [Standard Tokenizer](https://www.elastic.co/guide/en/elasticsearch/reference/current/analysis-standard-tokenizer.html)

    * [Lowercase Token Filter](https://www.elastic.co/guide/en/elasticsearch/reference/current/analysis-lowercase-tokenfilter.html)

    * [N-gram Token Filter](https://www.elastic.co/guide/en/elasticsearch/reference/current/analysis-ngram-tokenfilter.html)

    در این
    Query
    ما یک
    index
    به نام
    `people-simple2`
    ساختیم که یک
    Custom Analyzer
    به اسم
    `my_ngram_analyzer`
    دارد که این
    Analyzer
    از یک
    Standard Tokenizer
    همراه با
    Lowercase Token Filter
    و
    `my_ngram_filter`
    استفاده کرده است که
    `my_ngram_filter`
    خود یک
    N-gram Token Filter
    است که زیررشته‌های به طول 3 تا 10 از کلمات ایجاد می‌کند. در ابتدای کار نیز در تنظیمات این
    index
    تعیین شده است که اختلاف
    min_gram
    و
    max_gram
    می‌تواند حداکثر 7 باشد که پیش‌فرض آن 1 است.

    حالا با اجرای کوئری زیر نتیجه‌ی استفاده از این
    Custom Analyzer
    من‌درآوردی رو ببینید!

    <div dir='ltr'>

    ```json
    POST people-simple2/_analyze
    {
        "analyzer": "my_ngram_analyzer",
        "text": "Mohammad Reza"
    }
    ```

    </div>

    چه مشاهده می‌کنید؟ به نظر شما این
    Analyzer
    چه کاربردی دارد؟

    <details>
    <summary>
    هشدار لوث‌سازی
    (Spoiler Alert)
    </summary>
    
    `اگر بخواهیم زیررشته‌ی عبارات را جستجو کنیم می‌توانیم از این
    Analyzer
    استفاده کنیم مثلاً اگر عبارت
    «محمد»
    را جستجو کنیم و بخواهیم سندی که عبارت
    «محمدی»
    دارد نیز در نتایج ظاهر شود.`
    
    </details>

    برای آشنایی با انواع مختلف
    Tokenizerها
    و
    Token Filterها
    می‌توانید از لینک زیر استفاده کنید:

    [https://www.elastic.co/guide/en/elasticsearch/reference/current/analysis.html](https://www.elastic.co/guide/en/elasticsearch/reference/current/analysis.html)

1. انجام جستجوی زیررشته

    1. حالا از
    Analyzer
    ساخته‌شده در قسمت قبل استفاده می‌کنیم:

        <div dir='ltr'>

        ```json
        PUT people-simple2/_mapping
        {
            "properties":{
                "last_name": {
                    "type":"text",
                    "analyzer":"my_ngram_analyzer"
                }
            }
        }
        ```

        </div>

        مشخص است که یک
        Field
        به نام
        last_name
        با
        Analyzer
        خودمان تعریف کردیم.

    1. Query
    زیر را اجرا کنید و نتیجه را ببینید:

        <div dir='ltr'>

        ```json
        GET people-simple2/_search
        {
            "query": {
                "match": {
                    "last_name": "hamm"
                }
            }
        }
        ```

        </div>

    البته ایجاد
    Analyzer
    و
    تعریف
    Fieldهای
    index
    را می‌توان در یک
    Query
    انجام داد که البته به شرطی است که
    index
    با آن نام قبلاً وجود نداشته باشد:

    <div dir='ltr'>

    ```json
    PUT people-simple3
    {
        "settings": {
            "index": {
                "max_ngram_diff": 7
            },
            "analysis": {
                "analyzer": {
                    "my_ngram_analyzer": {
                        "type": "custom",
                        "tokenizer": "standard",
                        "filter": [
                            "lowercase",
                            "my_ngram_filter"
                        ]
                    }
                },
                "filter": {
                    "my_ngram_filter": {
                        "type": "ngram",
                        "min_gram": 3,
                        "max_gram": 10
                    }
                }
            }
        },
        "mappings": {
            "properties":{
                "last_name": {
                    "type":"text",
                    "analyzer":"my_ngram_analyzer"
                }
            }
        }
    }
    ```

    </div>

1. Typeهای
دیگر

    علاوه بر جنس
    text
    می‌توان
    Fieldها
    را از جنس‌های دیگر نیز تعریف کرد که مثالی از آن را در مشخصه‌ی
    age
    از داده‌های نمونه دیدید.

    حالا تلاش کنید که با استفاده از مطالب قسمت قبل
    Mapping
    مناسب برای
    [این داده‌های نمونه](https://github.com/Star-Academy/codestar-internship/raw/master/Projects/Phase09-Elasticsearch/people.json)
    را در یک
    index
    جدید تعریف کنید و تعدادی از این داده‌ها را در آن
    index
    بریزید.

    در
    [این لینک](https://www.elastic.co/guide/en/elasticsearch/reference/current/mapping-types.html)
    می‌توانید انواع مختلف داده در
    Elasticsearch
    را مشاهده کنید و درباره‌ی آن‌ها اطلاعات بیش‌تری کسب کنید.

    راهنمایی:
    مشخصه‌های
    latitude
    و
    longitude
    در داده‌های نمونه به طور جداگانه آورده شده‌اند که برای ریخته شدن در
    Elasticsearch
    باید به یک
    Field
    تبدیل شوند که این کار را به طور دستی و یا با نوشتن یک کد به زبان دلخواه می‌توانید انجام دهید.

    راهنمایی 2:
    داده‌های از جنس تاریخ و زمان ممکن است در فرمت‌های مختلفی باشند لذا در هنگام تعریف
    Mapping
    علاوه بر تعریف
    type،
    فرمت متناسب با داده‌های نمونه را منظور کنید.


1. آشنایی با
Bulk API

    اگر بخواهید تعداد زیادی سند در
    Elasticsearch
    بارگذاری کنید این که برای هر کدام یک بار
    Query
    بزنید چندان بهینه نیست چرا که سربار زیادی روی شبکه دارد و این مسئله کار را بسیار کند می‌کند. برای حل این مشکل باید چندین سند را به طور یک‌جا برای بارگذاری به
    Elasticsearch
    فرستاد.

    از
    [این لینک](https://www.elastic.co/guide/en/elasticsearch/reference/current/docs-bulk.html)
    کمک بگیرید و با
    Bulk API
    آشنا شوید. با استفاده از آن 
    [ابیاتی از شعرای گران‌قدر پارسی‌زبان](https://github.com/Star-Academy/codestar-internship/raw/master/Projects/Phase09-Elasticsearch/poems.txt)
    را به طور یک‌جا در
    Elasticsearch
    بریزید.

    راهنمایی:
    برای ساختن
    Bulk Query
    نیاز دارید تا تغییراتی را در فایل داده شده اعمال کنید که به دلیل تعداد زیاد سندها به طور دستی امکان‌پذیر نیست که می‌توانید برای آن به زبان دلخواه کد بزنید.


1. Aggregations

    از هر کدام از شاعرها چند بیت در داده‌های بارگذاری شده در قسمت قبل وجود دارد؟

    برای پاسخ به این سؤال می‌توانید از
    [Terms Aggregation](https://www.elastic.co/guide/en/elasticsearch/reference/current/search-aggregations-bucket-terms-aggregation.html)
    استفاده کنید.

    با اجرای
    Query
    زیر به پاسخ پرسش بالا برسید:

    <div dir='ltr'>

    ```json
    GET poems/_search
    {
        "aggs": {
            "poets": {
                "terms": { "field": "poet.keyword" } 
            }
        },
        "size": 0
    }
    ```

    </div>

    Queryهای
    Aggregation
    در
    Elasticsearch
    خود دنیایی دارد که بیان همه‌ی انواع آن در این مقال نمی‌گنجد. برای آشنایی می‌توانید به
    [Aggregations](https://www.elastic.co/guide/en/elasticsearch/reference/current/search-aggregations.html)
    مراجعه کنید.

<br/><br/>
بهترین منبع برای آشنایی بیش‌تر با
Elasticsearch
خود
Doumentation
آن است که در زیر لینک آن آمده است:

* [Elasticsearch Reference](https://www.elastic.co/guide/en/elasticsearch/reference/current/index.html)


اشعار از
API
[وبسایت گنجور](http://ganjoor.net/)
به دست آمده است.

<br></br>
</div>

موفق باشید



