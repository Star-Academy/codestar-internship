<div dir="rtl" align='justify'>

[لیست تسک‌های مرتبط با این فاز به صورت issue template](issue-template-Phase07.md)

# فاز هفت: SQL

در این فاز با یک پایگاه داده رابطه‌ای، نحوه‌ی کار کردن با آن و
query
های آن آشنا می‌شوید.

1. مقدمه

    پایگاه داده یا 
    Database 
    مجموعه‌ای از داده‌ها است که به صورت ساختارمند درون کامپیوتر نگهداری می‌شوند. 
    سامانه مدیریت پایگاه داده یا 
    DBMS(Database Management System)
    نرم‌افزاری است که با کاربر نهایی، برنامه‌ها کاربردی و خود پایگاه داده برای ذخیره و بازیابی داده تعامل میکند.
    DBMS
    های مختلفی برای کابردهای متفاوت وجود دارند که پرکاربردترین
    DBMS
    ها، 
    DBMS
    های رابطه‌ای یا همان
    RDBMS(Relaional Database Management System)
    ها هستند. در این 
    DBMS
    ها داده‌ها به صورت سازمانمند در جداول ذخیره می‌شوند و مقادیر موجود در هر جدول با یکدیگر ارتباط دارند. به همین خاطر به آن رابطه‌ای با 
    relational 
    گفته می‌شود.
    
    از آنجایی که اکثر 
    RDBMS
    ها از زبان پرسمان سازمان‌یافته یا 
    SQL(Structured Query Language)
    استفاده می‌کنند، با آشنایی با یکی از این 
    RDBMS
    ها می‌توانید با صرف زمان کم نحوه استفاده از یک 
    RDBMS 
    جدید را فرابگیرید. همچنین 
    SQL 
    جزو استاندارد 
    ANSI 
    و 
    ISO 
    می‌باشد.
    
    RDBMS
    های فراوانی وجود دارند که بسته به نیاز از آن‌ها استفاده می‌شود.
    MySQL, SQL Server, PostgreSQL, SQLite, ...
    نمونه‌های از 
    RDBMS
    های معروف هستند. در این فاز با 
    SQL Server
     که محصول شرکت 
     Microsoft 
     است، کار می‌کنید.

1. آشنایی با مفاهیم اولیه

    - Instance
    - SSMS و ADS
    - Database در SQL Server
    
        یک 
        Database 
        در 
        SQL Server 
        مجموعه‌ای از چند شئ از نوع جدول
        (Table)
        ، رویه ذخیره شده
        (Stored Procedure)
        ، تابع
        (Function)
        ، نما
        (View)
        و ... است. اگر این عبارات برایتان ناآشنا است نگران نباشید! در ادامه با آن‌ها آشنا می‌شوید. فعلا در این حد بدانید که داده‌ها در 
        SQL Server 
        باید در یک 
        Database 
        وجود داشته باشند.


1. نصب و راه‌اندازی SQL Server و SSMS

    1. ابتدا یک نسخه از 
    SQL Server
    را با توجه به سیستم عامل خود دانلود کنید. پیشنهاد می‌شود نسخه 
    SQL Server 2019 Developer
    را از 
    [سایت مایکروسافت](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
    دانلود و نصب کنید. این نسخه تمامی ویژگی‌های نسخه 
    Enterprise 
    را به صورت رایگان در اختیارمان قرار میدهد ولی فقط مجوز استفاده در محیط توسعه و تست را دارد.

    1. با توجه به نسخه دانلود شده به نصب بپردازید. تمام تنظیمات خواسته شده را در حالت پیشفرض قرار دهید. همچنین در قسمت 
    Feature Selection 
    انتخاب 
    Database Engine Service 
    برای کار ما کافی است. به تنظیمات زیر هم توجه کنید.

        <!-- ![Feature Selection](./Resource/FeatureSelection.png) -->
        <center><img src="./Resource/FeatureSelection.png" alt="Feature Selection" width="60%"></center>
        <!-- ![Administrator](./Resource/Admin.png) -->
        <center><img src="./Resource/Admin.png" alt="Administrator" width="60%"></center>

    1. حال نوبت به نصب ابزار مدیریت 
    SQL Server 
    است. 
    SSMS (SQL Server Management Studio) 
    یکی از ابزارهای قدیمی برای این کار است که تنها برای ویندوز موجود است و در محیط‌های محصول اکثرا از آن استفاده می‌شود. 

    1. حال 
    SSMS (SQL Server Management Studio)
    که ابزاری رایگان برای پیکربندی، مدیریت و اداره کردن تمامی اجزا 
    SQL Server 
    است را از 
    [سایت مایکروسافت](https://docs.microsoft.com/en-us/sql/ssms/)
    دانلود و نصب کنید.


1. ایجاد و حذف Database

    همانظور که در تعاریف دیدم برای کار با داده باید حداقل یک 
    Database 
    ایجاد کنیم. 

    <div dir="ltr">

    ```
    CREATE DATABASE database_name;
    ```
    </div>

    برای مثال:

    <div dir="ltr">

    ```
    CREATE DATABASE StarAcademy;
    ```
    </div>

    با اجرای این دستور، دیتابیس ساخته می‌شود و با 
    Refresh 
    کردن 
    Connections
    دیتابیس 
    StarAcademy
    مشاهده می‌شود.
    
    پس از اجرا کردن هر دستور 
    ADS 
    پیغامی متناسب با موفقیت و یا عدم موفقیت 
    Query 
    اجرا شده چاپ می‌کند. در صورت مواجه شدن با خطا، پیغام مربوط به خطا نیز چاپ می‌شود که به رفع خطا کمک می‌کند.

    <center><img src="./Resource/ADSMessage.png" alt="ADS Message" width="80%"></center>

    برای حذف یک دیتابیس نیز از دستور زیر استفاده می‌شود.

    <div dir="ltr">

    ```
    DROP DATABASE database_name;
    ```
    </div>

1. Data Type

    Data Type 
    نوع داده‌ای است که هر ستون در جدول یا متغییر می‌تواند ذخیره کند. 
    Data Type
    های 
    SQL Server 
    در هفت دسته کلی قرار میگیرند که عبارتند از:
    
    - Exact numeric
    - Approximate numberic
    - Date and time
    - Character strings
    - Unicode character strings
    - Binary strings
    - Other data types

    اعضای هر یک از این دسته‌ها را با جزئیات می‌توانید در 
    [سایت مایکروسافت](https://docs.microsoft.com/en-us/sql/t-sql/data-types/data-types-transact-sql)
    ببینید. پرکاربردترین 
    Data Type
    ها نیز در جدول زیر قابل مشاهده هستند.

    <center><div dir="ltr">

    | Data Type | توضیحات | Range/Limit | Storage Size |
    | :---: | :---: | :---: | :---: |
    | int | It stores whole numbers in the range given | -2^31 to −2^31-1 | 8 bytes |
    | varchar(n) | This is a character string with variable width | 8000 chars | n + 2 bytes |
    | nvarchar(n) | It is a unicode string of variable width | 4000 chars | 2*n + 2 bytes |
    | datetime | Used for specifying a date and time. It has an accuracy of 3.33 milliseconds. | 1753/1/1 to 9999/12/31 | 8 bytes |
    | decimal | Used for scale and fixed precision numbers | −10^38+1 to 10^38−1 | 5 to 17 bytes |
    | float(n) | Used for a floating precision number | −1.79E+308 to 1.79E+308 | Depends on the value of n |
    | bit | It can take 0, 1, or NULL values. | 0 to 1 | 1 byte/8bit column |
    </div></center>

1. جدول 

    جدول یا 
    Table 
    شئ‌ای است که داده‌ها را به صورت سطر 
    (Row) 
    و ستون 
    (Column)
    ذخیره می‌کند.

    برای ساختن جدول از دستور زیر استفاده می‌کنیم.

    <div dir="ltr">

    ```
    CREATE TABLE tableName
    ( 
        column_1 datatype [ NULL | NOT NULL ],
        column_2 datatype [ NULL | NOT NULL ],
        ...
    );
    ```
    </div>

    برای مثال جدول دانشجو را به صورت زیر می‌سازیم. با نوشتن 
    NOT NULL 
     بعد از تعریف هر ستون، دادن مقدار به آن ستون در هنگام افزودن داده الزامی می‌شود. (در واقع مقدار آن ستون نمی‌تواند NULL باشد)
    
    <div dir="ltr">

    ```
    CREATE TABLE Student
    (
        StudentNumber VARCHAR(8) NOT NULL,
        Grade FLOAT(2),
        FirstName NVARCHAR(20) NOT NULL,
        LastName NVARCHAR(20) NOT NULL,
        IsMale BIT NOT NULL,
        DateOfBirth DATETIME NOT NULL,
        LeftUnitsCount INT NOT NULL
    );
    ```
    </div>

    پس از ساختن جدول می‌توانیم با دستور زیر داده‌ی مورد نظر را در جدول قرار دهیم.

    <div dir="ltr">

    ```
    INSERT INTO tableName
    (column_1, column_2, ... )
    VALUES
    (expression_1, expression_2, ... ),
    (expression_1, expression_2, ... ),
    ...;
    ```
    </div>

    برای مثال با دستور زیر داده متناظر به جدول اضافه می‌شود.

     <div dir="ltr">

    ```
    INSERT INTO Student(FirstName, LastName, DateOfBirth, IsMale, LeftUnitsCount, StudentNumber)
    VALUES('Ava', 'Ahmadi', 'Feb 15, 2002', 0, 140, '99100200');
    ```
    </div>

    همچنین با حفظ ترتیب ستون‌ها، می‌توان بدون نیاز به مشخص کردن نام هر ستون داده را اضافه کرد. مانند دستور زیر.

    <div dir="ltr">

    ```
    INSERT into Student values
    (
        '98100200',
        13.234,
        N'علی',
        N'احمدی',
        1,
        '1/22/2001',
        92
    );
    ```
    </div>

    همانطور که میبینید، برای مشخص کردن یک رشته به عنوان رشته 
    Unicode
    (در اینجا نام و نام خانوادگی که فارسی نوشته شده است) از پیشوند
    N
    استفاده می‌شود.

    پس قرار دادن داده‌ها در جدول، با کوئری زیر می‌توانیم داده ذخیره شده در جدول را دریافت کنیم.

    <div dir="ltr">

    ```
    SELECT column1, column2, ...
    FROM tableName
    [WHERE condition];
    ```
    </div>

    برای مثال برای دریافت داده تمام دانشجویانی که اضافه کرده‌ایم، دستور زیر را اجرا می‌کنیم.

    <div dir="ltr">

    ```
    SELECT *
    FROM Student;
    ```
    </div>

    هانطور که مشاهده می‌کنید، به جای نام ستون‌ها از "*" استفاده شده است. که به معنی همه ستون‌ها می‌باشد. در واقع این دستور با دستور زیر معادل است. 

    <div dir="ltr">

    ```
    SELECT StudentNumber, Grade, FirstName, LastName, IsMale, DateOfBirth, LeftUnitsCount
    FROM Student;
    ```
    </div>

    با اجرای دستور بالا، 
    ADS 
    داده‌ها را مانند شکل زیر به صورت جدول در 
    Results Tab
     نمایش می‌دهد.

    با استفاده از 
    Operator
    ها در عبارتی که با 
    Where 
    شروع می‌شود، می‌توانیم شروط و محدودیت‌هایی بر روی داده دریافت شده قرار دهیم. برای مثال دستور زیر افرادی که جنسیت آن‌ها مرد و معدلشان بین 10 تا 15 است را نمایش می‌دهد.

    <div dir="ltr">

    ```
    SELECT *
    FROM Student
    WHERE IsMale = 1 AND 10 < Grade AND Grade < 15;
    ```
    </div>

    همان 
    Query 
    بالا را به صورت زیر هم می‌توان نوشت.

    <div dir="ltr">

    ```
    SELECT *
    FROM Student
    WHERE IsMale = 1 AND Grade BETWEEN 10 AND 15;
    ```
    </div>

    در هر دو صورت خروجی به شکل زیر خواهد بود.

    <center><img src="./Resource/ADSSelect.png" alt="ADS Select" width="80%"></center>

    در جدول زیر 
    Operator
    های موجود را مشاهده می‌کنید. همچنین مانند مثال بالا می‌تواند تعداد از 
    Cluase
    ها را با یکدیگر 
    `AND`
    یا 
    `OR`
    کنید.

    <center><div dir="ltr">

    | Operator | توضیحات | Example |
    | :---: | :---: | :---: |
    | = | Equal | StudentNumber = '98100200'|
    | >, >= | Greater than, Greater than equal | Grade > 15, Grade >= 15 |
    | <, <= | Less than, Less than equal | Grade < 12, Grade <= 12 |
    | <> or != | Not equal | IsMale <> 1 or IsMale != 1 |
    | BETWEEN | Between a certain range | Grade BETWEEN 14 AND 17 |
    | LIKE | Search for a pattern | StudentNumber LIKE '98%' |
    | IN | To specify multiple possible values for a column | LastName IN ('Ahmadi', N'احمدی') |

    </div></center>

    پس از ساختن جدول، با دستورات زیر می‌توانیم ستون‌های آن را ویرایش کنیم. 

    <div dir="ltr">

    ```
    ALTER TABLE tableName ADD column1 datatype, column2 datatype, ...;
    ALTER TABLE tableName DROP COLUMN column1, column2, ...;
    ALTER TABLE tableName ALTER COLUMN column1 datatype, column2 datatype, ...;
    ```
    </div>

    با دستور زیر می‌توانیم یک جدول را حذف کنیم.
    
    <div dir="ltr">

    ```
    DROP TABLE tableName;
    ```
    </div>

    همچنین برای حذف داده‌های درون یک جدول و حفظ ساختار جدول از دستور زیر استفاده می‌کنیم.
    
    <div dir="ltr">

    ```
    DELETE TABLE tableName;
    ```
    </div>

1. کلیدها


1. آشنایی با T-SQL

    **T-SQL(Transact-SQL)** 
    زبان توسعه داده شده توسط ماکروسافت است که قابلیت‌هایی مثل متغییر، مدیریت استثنا 
    (Exception)
    ، رویه‌ی ذخیره شده 
    (Stored Procedure) 
    و ... را به 
    SQL Server 
    اضافه می‌کند. دقت کنید که 
    T-SQL 
    در کنار 
    SQL 
    قرار دارد و 
    SQL Server
    به صورت کامل از 
    SQL 
    استاندارد پشتیبانی می‌کند. در ادامه با برخی از ویژگی‌های T-SQL آشنا می‌شوید.


1. تابع‌ها


1. Joins


1. ساختن کاربر و مدیریت دسترسی‌ها


</div>
