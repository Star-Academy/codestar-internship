<div dir="rtl" align='justify'>

# فاز بیست و یک: آشنایی با Spark

## مقدمه

فرض کنید بخواهیم، برنامه‌ای بنویسیم که یک پردازش ساده روی داده‌های متنی انجام دهد. مثلاً متن ورودی را پردازش کند و تعداد تکرار هر کلمه در آن متن را محاسبه کند. (همان مسئله‌ی معروف Word Count)

نمونه ورودی:


<div dir="ltr">

```json
salam, chetory? salam khoobam!
```

</div>

نمونه خروجی:

<div dir="ltr">

```json
salam: 2
chetory: 1
khoobam: 1
```

</div>


  **روش اول**: یک کد می‌نویسیم که تک تک کلمات متن را استخراج کند (مانند فاز اول کارآموزی) و از طرف دیگر یک Dictionary یا HashMap نگه می‌داریم که به ازای هر کلمه تعداد تکرار آن را نگه دارد و در صورت رسیدن به هر کلمه تعداد تکرار آن کلمه را یک واحد زیاد می‌کنیم.

* چالش **حجم داده**: تا وقتی حجم داده ورودی در حد چند گیگابایت باشد احتمالاً روش اول جواب می‌دهد و مشکلی وجود ندارد اما اگر حجم متن‌های ورودی به ترابایت یا پتابایت (هر پتابایت = 1024 ترابایت) برسد چطور؟ به نظر شما شرکت گوگل اگر بخواهد چنین پردازش ساده‌ای را روی متنی معادل با کل صفحات وب انجام دهد آیا روش قبلی جواب می‌دهد؟

* چالش **سخت افزار**: می‌دانیم سرعت اجرای دستورات توسط CPU محدود است. با تمام پیشرفت‌های انجام شده در حوزه‌ی سخت‌افزار رسیدن به سرعت بیشتر از 4GHz در محیط‌های عملیاتی مشکل است. همچنین در میزان RAM قابل استفاده توسط یک کامپیوتر/سرور (server) محدودیت وجود دارد.

* چالش **زمان**: اگر بخواهیم حجم زیاد داده را با در نظر گرفتن محدودیت‌های سخت‌افزاری روی یک کامپیوتر/سرور پردازش کنیم ممکن است پردازش مورد نظر هفته‌ها یا ماه‌ها طول بکشد، این موضوع باعث می‌شود، روش اول در شرایطی که با حجم زیادی از داده مواجه باشیم عملیاتی و به‌صرفه نباشد.

نکته  اصلی اینجاست که چالش‌های بالا فقط مخصوص مسئله‌ی Word Count نیست، بلکه در طیف گسترده‌ای از پردازش‌های مربوط به تحلیل داده وجود دارد. در فاز‌های قبلی با انواع پردازش‌ها آشنا شدید از جمله:

* فیلتر
* تمیز سازی
* Join
* Aggregation (Group by)

حالا فرض کنید این پردازش‌ها را بخواهیم روی حجم بسیار زیاد داده (میلیارد‌ها رکورد تراکنش و ...) اجرا کنیم، نتیجه بروز همان چالش‌های قبلی است. اینجاست که به نظر می‌رسد باید سراغ روشی برویم که برای پردازش‌ها به **یک** کامپیوتر متکی نباشد.

## آشنایی با Map Reduce

در سال‌های گذشته شرکت‌های مختلفی با چالش‌های مطرح شده در مقدمه مواجه شدند و پارادایم Map Reduce نگاه جدیدی بود که می‌توانست مشکلات را حل کند. یعنی با درگیر کردن تعداد زیادی کامپیوتر/سرور، انواع پردازش‌ها را روی حجم بالای داده‌ها در زمان معقولی انجام دهد. 

برای آشنایی با جزئیات آن لینک‌های زیر را بررسی و مطالعه کنید:

<div dir="ltr">

* [What Is MapReduce? | What Is MapReduce In Hadoop? | Hadoop MapReduce Tutorial | Simplilearn Youtube](https://www.youtube.com/watch?v=b-IvmXoO0bU)

* [What is MapReduce in Hadoop? Architecture | Example](https://www.guru99.com/introduction-to-mapreduce.html)

* [MapReduce - Wiki](https://en.wikipedia.org/wiki/MapReduce)

* [What is MapReduce?](https://www.talend.com/resources/what-is-mapreduce/)

</div>

همچنین مقاله معروف Map Reduce را می‌توانید از لینک زیر بخوانید:

<div dir="ltr">

* [MapReduce: Simplified Data Processing on Large Clusters](https://research.google/pubs/pub62/)

</div>


## آشنایی با مفاهیم Spark

تحولی که Map Reduce ایجاد کرد بسیار بزرگ بود و استقبال زیادی از آن شد اما نیاز بود که ابزار‌ها و معماری‌های پیشرفته‌تری بر اساس همان الگو و پارادایم پیاده‌سازی شوند. بر همین مبنا Spark شکل گرفت. برای آشنایی با آن لینک‌های زیر را با دقت بررسی و مطالعه کنید:

<div dir="ltr">

* [Spark Tutorial For Beginners | Big Data Spark Tutorial | Apache Spark Tutorial | Simplilearn Youtube](https://www.youtube.com/watch?v=QaoJNXW6SQo)

* [Spark Tutorial – Learn Spark Programming](https://data-flair.training/blogs/spark-tutorial/)

</div>

* [مقدمه‌ای بر Apache Spark](https://vrgl.ir/P9uxu)

* [معرفی و آشنایی با آپاچی اسپارک](https://bigdataworld.ir/%D9%85%D8%B9%D8%B1%D9%81%DB%8C-%D9%88-%D8%A2%D8%B4%D9%86%D8%A7%DB%8C%DB%8C-%D8%A8%D8%A7-%D8%A2%D9%BE%D8%A7%DA%86%DB%8C-%D8%A7%D8%B3%D9%BE%D8%A7%D8%B1%DA%A9/)


یکی از مفاهیم اصلی در معماری Spark مفهوم RDD (Resilient Distributed Dataset) است، در مورد آن به دقت مطالعه کنید:

<div dir="ltr">

* [Spark RDD – Introduction, Features & Operations of RDD](https://data-flair.training/blogs/spark-rdd-tutorial/)

</div>

حالا که با Spark آشنا شدید، در مورد طیف وسیع کاربرد‌های آن مطالعه کنید:

<div dir="ltr">


* [Apache Spark Use Cases in Real Time](https://data-flair.training/blogs/spark-use-cases/)

</div>

## کار با Spark روی Colab


## آشنایی با PySpark


## پروژه


</div>




