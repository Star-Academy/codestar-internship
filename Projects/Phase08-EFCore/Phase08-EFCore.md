<div dir="rtl" align='justify'>

[لیست تسک‌های مرتبط با این فاز به صورت issue template](issue-template-Phase08.md)

# فاز هشت: EFCore

EntityFrameworkwork Core یک ORM چند سکویی است که به ما این فرصت را می‌دهد با یک بار نوشتن یک کد آن را بر روی پایگاه‌داده‌های مختلف اجرا کنیم. EFCore کاملا متن‌باز و در حال گسترش نیز هست.

## ORM

ORM مخفف Object Reletional Mapping است که مترجم میان زبان‌های برنامه‌نویسی و پایگاه‌داده است و می‌تواند یک کد را به زبان‌های مختلف تبدیل کند.

* [What is ORM? Object-Relational Mapping Explained](https://www.ictshore.com/software-design/what-is-orm/)

## روش‌های توسعه

دو روش توسعه توسط EFCore وجود دارد یکی با استفاده از Code first و دیگری Database first.

![](./ef-core-dev-approaces.png)

### Database first

در این روش ابتدا به ساکن پایگاه‌داده طراحی و پیاده‌سازی می‌شود و سپس بر اساس آن کدهایی به زبان‌برنامه‌نویسی ایجاد می‌شود. این روش بیشتر برای پروژه‌هایی که قبلا از طریقی دیگر و در گذشته پایگاه‌داده را ایجاد کرده‌اند کاربرد دارد.

* [Entity Framework Core Database-First Tutorial for .NET Core](https://www.devart.com/dotconnect/sqlite/docs/EFCore-Database-First-NET-Core.html)

### Code first

در این روش بر خلاف روش قبلی ابتدا مدل‌ها که همان کلاس‌های اشیاء ما هستند ایجاد می‌شوند. خوبی این روش این است که اگر نیاز به تغییر دیتابیس باشد تنها با تغییری جزئی کانفیگ می‌توان پایگاه‌داده را تغییر داد.

برای درک بهتر Code first بهتر است در ابتدا یک پروژه ساده را پیاده‌سازی کنید. از این رو سعی کنید پروژه لینک زیر را اجرا کنید.

* [First EF Core Console Application](https://www.entityframeworktutorial.net/efcore/entity-framework-core-console-application.aspx)

### Linq

برای فراخوانی داده‌ها در EFCore می‌تواند به راحتی از Linq استفاده کنید و کوئری‌های خود را ایجاد کنید.

برای درک بهتر این موضوع لینک زیر را مطالعه کنید و سعی کنید مثال‌های آن‌را پیاده‌سازی کنید.

* [Querying data via the DbSet](https://www.learnentityframeworkcore.com/dbset/querying-data)

### Insert

برای افزودن داده‌ها در جدول به راحتی می‌توانید به وسیله EFCore داده‌ها را بیافزاید. برای آشنایی بیشتر با این مورد لینک زیر را مطالعه نمائید.

* [Insert Records in Entity Framework Core
](https://www.yogihosting.com/insert-records-entity-framework-core/)

### Update

برای به روزرسانی داده‌ها در جدول به راحتی می‌توانید به وسیله EFCore داده‌ها را به روزرسانی کنید. برای آشنایی بیشتر با این مورد لینک زیر را مطالعه نمائید.

* [Update Records in Entity Framework Core
](https://www.yogihosting.com/update-records-entity-framework-core/)

### Delete

برای حذف داده‌ها در جدول به راحتی می‌توانید به وسیله EFCore داده‌ها را حذف کنید. برای آشنایی بیشتر با این مورد لینک زیر را مطالعه نمائید.

* [Delete Records in Entity Framework Core
](https://www.yogihosting.com/delete-records-entity-framework-core/)
  
### Video

اگر فرصت داشته باشید استفاده از ویدیو های دوره آموزشی زیر پیشنهاد میشود

* [Entity Framework Core - The Complete Guide (.NET Core 5)](https://p30download.ir/fa/entry/93481/)

</div>