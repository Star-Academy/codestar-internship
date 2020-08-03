<div dir="rtl" align='justify'>

# فاز چهار: #C

در این فاز با زبان سی‌شارپ آشنا خواهید شد. همچنین برنامه‌ای را که به زبان جاوا نوشته‌اید را به زبان سی‌شارپ تبدیل خواهید کرد.

1. نصب پیشنیازها:

   برای اجرا کردن کدی که به زبان سی‌شارپ می‌نویسید نیاز است چند مورد را نصب کنید.

   - بر اساس سیستم‌عامل نسخه مناسب را از [سایت مایکروسافت ](https://dotnet.microsoft.com/download/dotnet-core/3.1) دانلود و نصب کنید.
   - بر روی VSCode اکستنشن‌های زیر رو نصب کنید:
   
    <div dir="ltr" align='justify'>

   1. [C#](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp)
   2. [Code Runner](https://marketplace.visualstudio.com/items?itemName=formulahendry.code-runner)
   3. [C# Extensions](https://marketplace.visualstudio.com/items?itemName=jchannon.csharpextensions)
   4. [vscode-solution-explorer](https://marketplace.visualstudio.com/items?itemName=fernandoescolar.vscode-solution-explorer)
   5. [.NET Core Test Explorer](https://marketplace.visualstudio.com/items?itemName=formulahendry.dotnet-test-explorer)

    </div>

2. مفهوم Solution و Project:

   برای شروع ساخت یک برنامه در سی شارپ لازمه اول با مفهوم Solution و Project آشنا بشی. برای همین لینک‌ زیر رو بخون.


    <div dir="ltr" align='justify'>

    - [What is a C# solution and how to use it?](https://stackoverflow.com/a/40400159/7498797)

    </div>

3. سلام به دنیای سی شارپ:

    برای شروع VSCode رو باز کنید و یه فولدر رو جهت شروع انتخاب کنید. بعد در ترمینال دستور زیر رو وارد کنید.
    

   <div dir="ltr" align='justify'>

   `dotnet new console`

   </div>

   همینطوری که می‌بینی چند فایل و یک فولدر ساخته شد. اگه به فایل `Program.cs` بری اولین برنامه‌ای که با سی‌شارپ ساختی رو می‌بینی که یه کد ساده `Hello world!` است.
   برای اجرای این برنامه درون ترمینال دستور زیر را وارد کن.

   <div dir="ltr" align='justify'>

   `dotnet run`

   </div>

   الان در یک خط عبارت `Hello world!` چاپ شده رو می‌بینی.

4. NuGet چیست؟

   یه ابزار مورد نیاز برای هر دولوپری وجود داشتن بستریه که بتونه باهاش یه کد رو به اشتراک بزاره تا بقیه هم بتونن ازش به عنوان پکیج در کدهاشون استفاده بکنند.
   معمولا پکیج‌ها شامل یه سری کد کامپایل شده مثل DLL ها می‌شن به همراه بقیه چیزایی که ممکنه بهشون نیاز بشه.


    برای .NET (از جمله .NET Core) ،بستری که مایکروسافت برای به اشتراک گذاری کد آماده کرده NuGet عه که نحوه ایجاد، میزبانی و مصرف پکیج‌های مربوط به .NET را مشخص می‌کنه.
    می‌تونی به راحتی با نوشتن یه دستور در کنسول یه پکیج رو به پروژه‌ات اضافه بکنی.

    <div dir="ltr" align='justify'>

    `dotnet add package System.Text.Json`

    </div>

    دستور بالا پکیج `System.Text.Json` رو به برنامه اضافه می‌کنه. این پکیج آیتم‌ها سی‌شارپ رو به جیسون تبدیل می‌کنه. برای مثال کد زیر یه آیتم سی‌شارپ رو به جیسون تبدیل می‌کنه و در خروجی چاپ می‌کنه.

    <div dir="ltr" align='justify'>

    ```C#
    using System;
    using System.Text.Json;

    namespace HelloWorld
    {
        class Program
        {
            static void Main(string[] args)
            {
                var item = new { FirstName = "Mahdi", LastName = "Malverdi"};
                var serializedItem = JsonSerializer.Serialize(item);
                Console.WriteLine(serializedItem);
            }
        }
    }
    ```

    </div>

    در سی‌شارپ برای استفاده از یه پکیج باید از using استفاده بکنید. using کارایی مشابه با import و include در زبان‌های دیگه رو داره.
    همچنین با استفاده از کلمه var در سی شارپ میتونی یک متغیر را تعریف کنی. وقتی از این کلمه برای تعریف متغیر استفاده می‌شه نیازی نیس نوع داده‌ی متغیر نیست و کامپایلر از روی مقداردهی اولیه، نوع متغیر را مشخص می‌کنه.

    اگه دوست داری بیشتر در مورد NuGet بدونی می‌تونی مقاله [An introduction to NuGet](https://docs.microsoft.com/en-us/nuget/what-is-nuget) رو بخونی.

5. کمی پیشرفته‌تر:

   خب حالا وقتشه که کمی پیشرفته‌تر و منظم‌تر با سی‌شارپ برخورد کنی! توی این مرحله یاد می‌گیری چطور تست بنویسی و هم اینکه چطور با کنسول کار بکنی.

   اول کار سری به این [آموزش](https://softchris.github.io/pages/dotnet-core.html#resources) بزن و سعی کن تمام کارهایی که گفته رو انجام بدی.

   اگه هم دوست داشتی می‌تونی از آموزش‌های زیر بر حسب موضوعی که نیاز داری استفاده بکنی:

   <div dir="ltr" align='justify'>

   - [Console.ReadLine() Method in C#](<https://www.geeksforgeeks.org/console-readline-method-in-c-sharp/#:~:text=Console.-,ReadLine()%20Method%20in%20C%23,user%20presses%20the%20Enter%20key.>)
   - [Console Class in C#](https://www.geeksforgeeks.org/console-class-in-c-sharp/#:~:text=Weekday%20in%20C%23-,Console%20Class%20in%20C%23,output%20from%20the%20computer%20end.)
   - [.NET Core CLI overview](https://docs.microsoft.com/en-us/dotnet/core/tools/)
   - [10 commands you don't want to be without in .Net Core](https://softchris.github.io/pages/dotnet-10-commands.html#_4-dotnet-run)
   - [Getting Started with xUnit.net](https://xunit.net/docs/getting-started/netcore/cmdline)

   </div>

6. نام‌گذاری‌ها در سی‌شارپ:

   یکی از گام‌های مهم یادگیری هر زبان برنامه‌نویسی یادگیری اصول نامگذاری در اون زبانه! شاید در وهله اول مورد مهمی در نظر نیاد اما از اون نظر اهمیت داره که کدی می‌نویسی نباید تافته جدا بافته از بقیه جامعه اون زبان باشه. برای همین یه نگاهی به دو لینک زیر بنداز تا با قواعد نام گذاری در این زبان آشنا بشی.

   - [C# Coding Standards and Naming Conventions](https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md)
   - [Naming Guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines)

7. Entity Framework Core:

   Entity Framework Core یک ORM است. اگر با مفهوم ORM آشنایی ندارین پیشنهاد می‌کنم مقالات زیر را بخوانید:

   - [object-relational mapping (ORM)](https://searchwindevelopment.techtarget.com/definition/object-relational-mapping)
   - [WHAT IS ORM?](https://www.brcline.com/blog/what-is-orm)

   اما به طور خلاصه می‌توان گفت ORM در واقع یک لایه مترجم بین زبان برنامه نویسی ما و پایگاه داده هست که این دو را به هم تبدیل می کند و به ما کمک میکند که بین زبان برنامه نویسی مون که سی شارپ هست و بانک اطلاعاتی مون که SQL Server هست ارتباط برقرار کنیم و تبادل اطلاعات داشته باشیم.

   حال مایکروسافت Entity Framework Core یا به اختصار EFCore رو برای زبان‌های .net توسعه داده تا کار با دیتابیس را برای توسعه دهندگان آسان‌تر کند.

   از مزایای EFCore می‌توان به پشتیبانی از اکثر دیتابیس اشاره کرد. این سخن به این معناست که شما یک کد می‌نویسید و تنها با تغییر کانکشن استرینگ، نوع دیتابیس رو تغییر می‌دید.

   با EFCore به یکی از دو روش زیر می‌توان کد زد:

   - Database First:

     در این روش در ابتدا دیتابیس را آماده می‌کنیم و سپس EFCore رو بر اساس اون ایجاد می‌کنیم. برای مطالعه در مورد این روش می‌توان لینک‌های زیر را مطالعه کنید.

     - [Creating a Model for an Existing Database in Entity Framework Core](https://www.entityframeworktutorial.net/efcore/create-model-for-existing-database-in-ef-core.aspx)
     - [Entity Framework Core Database-First Tutorial for .NET Core](https://www.devart.com/dotconnect/postgresql/docs/EFCore-Database-First-NET-Core.html)
     - [Setup and working Entity Framework Database First](https://www.c-sharpcorner.com/article/entity-framework-database-first-in-asp-net-core2/)

   - Code First:
     روش دیگر Code First است. این روش به این معناست که در ابتدا ساختار دیتابیس رو با کد مشخص می‌کنید و سپس بر اساس آن دیتابیس پیاده‌سازی می‌شود. در این آموزش سعی داریم بر اساس Code First پیش رویم.

     برای شروع پیشنهاد می‌کنیم با کمک از طریق لینک زیر یک پروژه بسازید و تمام اسنادی که در فاز‌های قبل خواندید را درون یک دیتابیس sqlite ذخیره کنید.

     - [Getting Started with EF Core](https://docs.microsoft.com/en-us/ef/core/get-started/?tabs=netcore-cli)

       البته اصراری در استفاده از Sqlite نیست و اگر علاقه دارید از دیگر دیتابیس‌ها استفاده کنید می‌توانید از لینک‌های زیر کمک بگیرید.

        - [Creating a Database with Code First in EF Core - MySql](https://docs.oracle.com/cd/E17952_01/connector-net-en/connector-net-entityframework-core-example.html#:~:text=7.2.-,1%20Creating%20a%20Database%20with%20Code%20First%20in%20EF%20Core,application%20using%20MySQL%20Connector%2FNET.)
        - [Entity Framework Core Code First - MSSqlServe](https://entityframeworkcore.com/approach-code-first)
        - [Entity Framework Core Code-First Tutorial for Full .NET Framework - Oracle](https://www.devart.com/dotconnect/oracle/docs/Tutorial_EFCore.html)

    
8. Design patterns:

</div>
