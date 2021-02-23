<div dir="rtl" align='justify'>

[لیست تسک‌های مرتبط با این بخش به صورت issue template](./issue-template-Phase12.md)

#  فاز دوازده : Logging & APM

در این فاز با مفاهیم
Logging
و
Application Performance Monitoring
و اهمیت استفاده از این مفاهیم در نگهداری محصول آشنا می‌شوید.  

<br>

### 1. اهمیت مانیتور بخش‌های مختلف مربوط به پردازش درخواست کاربر:

با استفاده از یک ابزار
Performance Monitoring
می‌توان از لحظه‌ای که یک 
Request
توسط کاربر ایجاد می‌شود، تا لحظه‌ای که 
Response
به کاربر برسد؛ نحوه‌ی پردازش 
Request
و ایجاد
Response
را مشاهده کرد. ابزار
APM
به شما این امکان را می‌دهد که مشاهده کنید به ازای هر
Request
کاربر، کدام بخش‌ها از کد فراخوانی شده است و زمان سپری شده در هر کدام از این بخش‌ها چقدر است. حال این ابزار کمک می‌کند تا بخش‌هایی از کد محصول یا ابزار‌ها و کتابخانه‌های استفاده شده که موجب کندی محصول می‌شوند شناسایی شوند.

<br>

### 2.  آشنایی با Elastic Apm:
  
Elastic Apm
یکی از این ابزارهای
Application Performance Monitoring
بوده و همان طور که از نامش مشخص است محصول شرکت
Elastic 
است.
این محصول به چهار بخش تقسیم می‌شود که دو بخش اول مخصوص
Apm
بوده و دو بخش دیگر جزو 
Elastic Stack
هستند:

* Apm Agent:
   کتابخانه‌های
    متن‌بازی هستند که در زبان‌های مختلف در دسترس بوده و کافی است کتابخانه مربوط به برنامه‌تان را نصب کنید.
    این قسمت وظیفه‌ی جمع‌آوری اطلاعات مربوط به
    Performance
    برنامه و ارسال این اطلاعات به 
    Apm Server
    را بر عهده دارد. 
    Agent
    ها اطلاعاتی مثل میزان مصرف منابع سخت‌افزاری و یا 
    Exception 
    های رخ‌داده در طول اجرای برنامه را به صورت خودکار جمع‌آوری می‌کنند و همچنین با 
    Api
    هایی که ارائه می‌دهند امکان 
    Trace
    برنامه را فراهم می‌کنند.

* Apm Server:
    این بخش وظیفه‌ی دریافت اطلاعات از 
    Agent
    ها و تبدیل آن‌ها به
    Document
    و ارسال آن‌ها به 
    Elasticsearch
    را بر‌عهده دارد.
    در مورد اینکه چرا 
    Apm Server
    یک بخش جدا از
    Agent
    است تحقیق کنید.

* Elasticsearch:
    این قسمت برای ذخیره‌سازی اطلاعات جمع‌آوری شده در مراحل قبل استفاده می‌شود. همچنین با توجه به امکاناتی همچون
    Full-Text Search
    بودن و
    Real Time Searching
    امکان تحلیل این اطلاعات را به ما می‌دهد.

* Kibana:
    این محصول که یک ابزار تجزیه و تحلیل و مصورسازی
    است و طراحی شده است تا اطلاعات
    Elasticsearch
    را نمایش دهد و امکان تحلیل اطلاعات را فراهم آورد.
    در این قسمت می‌توان اطلاعات جمع‌آوری شده در مراحل قبل را مشاهده و آن‌ها را تحلیل کرد.
       
![apm-architecture-cloud](https://www.elastic.co/guide/en/apm/get-started/current/images/apm-architecture-cloud.png) 
    
برای آشنایی با انواع اطلاعاتی که توسط
Apm
جمع‌آوری می‌شوند مطالعه
[این لینک](https://www.elastic.co/guide/en/apm/get-started/current/apm-data-model.html)
پیشنهاد می‌شود. 

<br>

### 3. نصب و راه‌اندازی Apm Server و اضافه کردن Apm به Kibana

1. Elasticsearch 
و 
Kibana
را نصب کنید. 
(مراحل نصب در 
[فاز ۷](../Phase07-Elasticsearch/Phase07-Elasticsearch.md)
قرار دارد.)
    
1. سپس 
Apm Server
متناسب با سیستم‌عامل خود را از
[اینجا](https://www.elastic.co/downloads/apm)
دانلود کنید.
    
1. Apm server
را اجرا کنید.
    به طور پیش‌فرض
    Apm Server
    روی پورت 8200 راه‌اندازی می‌شود.
    همچنین برای اتصال به 
    Elasticsearch
    به صورت پیش‌فرض به آدرس
    [http://localhost:9200](http://localhost:9200/) 
    متصل می‌شود که می‌توان با تغییر کانفیگ موجود در فایل
    apm-server.yml
    واقع در پوشه‌ی
    Apm Server
    این مقدار را تغییر داد.
        
1. Apm
دارای یک داشبورد در 
Kibana
بوده که امکانات زیادی را در اختیار ما قرار می‌دهد. این داشبورد با داکیومنت‌هایی که توسط
Apm-Server
در 
Elasticsearch
ایندکس شده‌است کار می‌کند. پس لازم است برای راه‌اندازی این داشبورد، ابتدا 
index
های موردنیاز ساخته‌شوند.
با مراجعه به صفحه‌ی 
Apm 
برای بار اول در
kibana
تمام مراحل نصب و راه‌اندازی 
Elastic Apm
قرار دارد. در قسمت 
Load Kibana Objects
این 
index
های موردنیاز به طور خودکار ایجاد می‌شوند.
همچنین می‌توانیم 
index 
های موردنظر خود را ایجاد کنیم اما این 
index 
ها باید دارای
mapping
مشابه با 
index
های پیش‌فرض باشند تا داشبورد 
Apm 
به درستی کار کند.
<br>
پس از راه‌اندازی 
Kibana
با مراجعه به آدرس
[http://localhost:5601/app/kibana#/home/tutorial/apm](http://localhost:5601/app/kibana#/home/tutorial/apm)
تمام مراحل اضافه کردن 
Apm
را مشاهده کنید.

<br>

### 4. اضافه کردن Net Agent. به پروژه C#

1. ابتدا کتابخانه 
[Elastic.Apm](https://www.nuget.org/packages/Elastic.Apm)
را به ساختار پروژه خود اضافه کنید.
    
1. در مورد 
[Api](https://www.elastic.co/guide/en/apm/agent/dotnet/current/public-api.html)
هایی که این کتابخانه در اختیار ما قرار می‌دهد مطالعه کنید.
    
1. با اضافه کردن
Api
مرحله‌ی قبل به کد 
Application
زمان سپری شده در توابع مختلف را در 
Kibana
مشاهده کنید.
    
<br>

__با مراجعه به
[این صفحه](https://www.elastic.co/guide/en/apm/agent/dotnet/current/setup.html)
می‌توانید 
Agent
های مختلفی که 
Elastic
برای
Net.
منتشر کرده‌است را مشاهده کنید.__
    
    
</div>
