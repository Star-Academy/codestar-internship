<div dir="rtl" align='justify'>

# فاز هفت: Elasticsearch

در این فاز با موتور جستجوی
Elasticsearch
و نحوه‌ی کار کردن با آن آشنا می‌شوید.

1. آشنایی با Elasticsearch

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

    پ.ن:
    Elasticsearch
    کاملاً
    Open-Source
    است.

1. آشنایی با مفاهیم 
document
و 
index

    برای مطالعه در این زمینه
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

1. بارگذاری سند متنی در
Elasticsearch

    1. برای اجرای
    query
    ها از قسمت
    Dev Tools
    در
    Kibana
    استفاده کنید.

    1. ابتدا یک
    index
    در 
    Elasticsearch
    ایجاد کنید. برای این کار می‌توانید از
    [این لینک](https://www.elastic.co/guide/en/elasticsearch/reference/current/indices-create-index.html)
    کمک بگیرید.

    1. تعدادی سند متنی در
    index
    ایجاد شده بریزید. دقت کنید که سندهایی که به
    Elasticsearch
    داده می‌شوند به فرمت
    [JSON](https://en.wikipedia.org/wiki/JSON)
    هستند. برای این کار می‌توانید از
    [این لینک](https://www.elastic.co/guide/en/elasticsearch/reference/current/docs-index_.html)
    کمک بگیرید.

        مثالی نیز در زیر آمده است:

        <div dir="ltr">

        ```json
        POST /<index>/_doc/
        {
            "name": "تربچه",
            "location": "تو باغچه"
        }
        ```

        </div>

    1. با استفاده از
    Query
    زیر از درستی کار خود مطمئن شوید:

    <div dir="ltr">

    ```json
    GET /<index>/_search
    ```

    </div>

1. جستجو در اسناد متنی بارگذاری شده

    برای جستجو می‌توانید از
    Query
    زیر استفاده کنید:

    <div dir="ltr">

    ```json
    GET /<index>/_search
    {
        "query":{
            "match": {
                "name": "تربچه"
            }
        }
    }
    ```

    </div>

    این مثالی از
    Match Query
    است که می‌توانید در لینک زیر بیش‌تر با آن آشنا شوید:

    * [Match Query](https://www.elastic.co/guide/en/elasticsearch/reference/current/query-dsl-match-query.html)

    هم‌چنین برای آشنایی با
    Query
    های مختلف که
    Elasticsearch
    در اختیار کاربر می‌گذارد می‌توانید از لینک زیر کمک بگیرید:

    * [Query DSL](https://www.elastic.co/guide/en/elasticsearch/reference/current/query-dsl.html)

    انواع مختلف 
    Query
    به ویژه
    Query
    های زیر را امتحان کنید و امکانات هر یک از آن‌ها و تفاوت آن‌ها را دریابید:

    * [Match Query](https://www.elastic.co/guide/en/elasticsearch/reference/current/query-dsl-match-query.html)
    * [Fuzzy Query](https://www.elastic.co/guide/en/elasticsearch/reference/current/query-dsl-fuzzy-query.html)
    * [Term Query](https://www.elastic.co/guide/en/elasticsearch/reference/current/query-dsl-term-query.html)
    * [Range Query](https://www.elastic.co/guide/en/elasticsearch/reference/current/query-dsl-range-query.html)
    * [Bool Query](https://www.elastic.co/guide/en/elasticsearch/reference/current/query-dsl-bool-query.html)

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
    آشنا شوید. با استفاده از آن چند سند را به طور یک‌جا در
    Elasticsearch
    بریزید.

<br/><br/>
بهترین منبع برای آشنایی بیش‌تر با
Elasticsearch
خود
Doumentation
آن است که در زیر لینک آن آمده است:

* [Elasticsearch Reference](https://www.elastic.co/guide/en/elasticsearch/reference/current/index.html)



