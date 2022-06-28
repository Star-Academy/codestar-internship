<div dir="rtl" align='right'>

#  آشنایی با #C

<div align='center'>

**[⚡Issues⚡](./issue-template.md)**
</div>

در این فاز با زبان #C آشنا خواهید شد. همچنین چند برنامه ساده با زبان #C خواهید نوشت.

## نصب پیش‌نیازها:

در قدم اول برای کار با زبان #C پیشنهاد می‌کنیم از [VS Code]() استفاده کنید تا با  [Net CLI.](https://docs.microsoft.com/en-us/dotnet/core/tools/) بهتر آشنا شوید.
برای نوشتن کد به زبان #C در VS Code مراحل زیر را طی کنید:
1. نصب [NET SDK](https://dotnet.microsoft.com/en-us/download).
2. نصب اکستنشن [C#](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.csharp).

پس از نصب موارد بالا دستور ```dotnet --info ``` را در ترمینال اجرا کنید.
*پیشنهاد می‌شود نسخه جدید [ترمینال ویندوز](https://github.com/microsoft/terminal/releases) را نیز نصب کنید.*

## آشنایی با زبان #C:

بهتر است ابتدا با Solution و Project  در زبان C# آشنا شوید که برای درک این مفاهیم [?What is a C# solution and how to use it](https://stackoverflow.com/a/40400159/7498797) را مطالعه کنید، سپس در صورتی که با زبان Java آشنایی دارید [C# Crash Course for Java Developers](https://nerdparadise.com/programming/csharpforjavadevs) را مطالعه بفرمایید.

## اولین برنامه
   
VS Code را باز کنید و یک پوشه انتخاب کنید.  سپس در ترمینال برای ایجاد یک Console App دستور زیر را اجرا کنید:
<div dir="ltr" align='justify'>

`dotnet new console`
</div>

پس از اجرای دستور بالا چند فایل و یک پوشه ساخته می‌شوند. اگر فایل `Program.cs` را باز کنید مشاهده می‌کنید که یک کد ساده‌ی چاپ `Hello world` در این فایل نوشته شده است. برای اجرای این برنامه درون ترمینال دستور زیر را اجرا کنید:

<div dir="ltr" align='justify'>

`dotnet run`
</div>

با اجرای دستور بالا می‌بایست عبارت `Hello World` در ترمینال چاپ شود.

## NuGet
یک نرم‌افزار حیاتی برای توسعه‌ی پلتفرم‌های مدرن که توسعه‌دهندگان می‌توانند با استفاده از آن کدهای خود را به اشتراک بگذارند و یا از کدهای دیگران استفاده کنند. این کد‌ها در قالب  packageهایی که شما کدهای کامپایل شده به اسم dll و سایر فایل‌های مورد نیاز برای پروژه هایی که از این packageها استفاده می‌کنند می‌باشند. برای .NET مکانیزمی که برای اشتراک گذاری کد می‌باشد و ماکروسافت از آن پشتیبانی می‌کند NUGET  می‌باشد که معین می‌کند packageها برای .NET ایجاد، نگهداری و مصرف می‌شود. و برای هرکدام از این عملیات ها ابزاری فراهم می‌کند. به صورت ساده‌تر nuget package یک عدد فایل زیپ می‌باشد که پسوند .nupkg می‌باشد که شامل کدهای کامپایل شده (dll) و سایر فایل های مرتبط با این کدها مانند یک فایل که توصیفی از اطلاعات یک package را ارائه میدهد مانند ورژن کامپانی اسم 
برای توسعه به هر زبان برنامه نویسی به ابزاری  نیاز دارید که بتوان به کمک آن کدها را به اشتراک گذاشت و از کدهای به اشتراک گذاشته شده‌ی سایرین استفاده کرد.
کدهای #C هنگام کاپایل به فایل‌های dll تبدیل می‌شوند که هنگام اجرای بنامه به این فایل‌ها نیاز داریم.


توسعه دهندگان برای استفاده و و شیر کد ها از نوگت استفاده میکنند و نوگت ها ابزاری که عملیات های لازم برای اشتراک و دریافت پیکج ها را هندل میکند






برای .NET ، بستری که مایکروسافت برای به اشتراک گذاری کد آماده کرده NuGet است که نحوه ایجاد، میزبانی و مصرف پکیج‌های مربوط به .NET را مشخص می‌کنه.
می‌توانید به راحتی با نوشتن یک دستور در کنسول یک پکیج را به پروژه‌‌تان اضافه کنید.

<div dir="ltr" align='justify'>

`dotnet add package System.Text.Json`

</div>

دستور بالا پکیج `System.Text.Json` را به برنامه اضافه می‌کند. این پکیج آیتم‌های #C را به جیسون تبدیل می‌کند. برای مثال کد زیر یک آیتم #C را به جیسون تبدیل و در خروجی چاپ می‌کند.

<div dir="ltr" align='justify'>

```C#
using System;
using System.Text.Json;

namespace HelloWorld
{
    public class Person
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
    }

    class Program
    {
        static void Main(string[] args)
        {
            var item = new Person() { FirstName = "Mahdi", LastName = "Malverdi"};
            var serializedItem = JsonSerializer.Serialize(item);
            Console.WriteLine(serializedItem);
        }
    }
}
```

</div>

در #C برای استفاده از یه پکیج باید از using استفاده بکنید. using کارایی مشابه با import و include در زبان‌های دیگر را دارد.
همچنین با استفاده از کلمه var در سی شارپ میتوانید یک متغیر را تعریف کنید. وقتی از این کلمه برای تعریف متغیر استفاده می‌شود نیازی به تعیین نوع داده‌ی متغیر نیست و کامپایلر از روی مقداردهی اولیه، نوع متغیر را مشخص می‌کند.

اگر دوست دارید بیشتر در مورد NuGet بدانید می‌توانید مقاله [An introduction to NuGet](https://docs.microsoft.com/en-us/nuget/what-is-nuget) را بخوانید.

5.  کمی پیشرفته‌تر:

    در این مرحله یاد می‌گیرید چطور تست بنویسید و هم اینکه چطور با کنسول کار بکنید.

    اول سری به این [آموزش](https://softchris.github.io/pages/dotnet-core.html#creating-a-solution) بزنید و سعی کنید تمام کارهایی که گفته شده را انجام دهید.

    اگر هم علاقه داشتید می‌توانید از آموزش‌های زیر بر حسب موضوعی که نیاز دارید استفاده بکنید:

    <div dir="ltr" align='justify'>

    - [Console.ReadLine() Method in C#](<https://www.geeksforgeeks.org/console-readline-method-in-c-sharp/#:~:text=Console.-,ReadLine()%20Method%20in%20C%23,user%20presses%20the%20Enter%20key.>)
    - [Console Class in C#](https://www.geeksforgeeks.org/console-class-in-c-sharp/#:~:text=Weekday%20in%20C%23-,Console%20Class%20in%20C%23,output%20from%20the%20computer%20end.)
    - [.NET Core CLI overview](https://docs.microsoft.com/en-us/dotnet/core/tools/)
    - [10 commands you don't want to be without in .Net Core](https://softchris.github.io/pages/dotnet-10-commands.html#_4-dotnet-run)
    - [Getting Started with xUnit.net](https://xunit.net/docs/getting-started/netcore/cmdline)

    </div>

6.  نام‌گذاری‌ها در #C:

    یکی از گام‌های مهم یادگیری هر زبان برنامه‌نویسی یادگیری اصول نامگذاری در اون زبانه! شاید در وهله اول مورد مهمی در نظر نیاید اما از اون نظر اهمیت داره که کدی می‌نویسید نباید تافته جدا بافته از بقیه جامعه اون زبان باشه. برای همین یه نگاهی به دو لینک زیر بندازید تا با قواعد نام گذاری در این زبان آشنا بشید.

    <div dir="ltr" align='justify'>

    - [C# Coding Standards and Naming Conventions](https://github.com/ktaranov/naming-convention/blob/master/C%23%20Coding%20Standards%20and%20Naming%20Conventions.md)
    - [Naming Guidelines](https://docs.microsoft.com/en-us/dotnet/standard/design-guidelines/naming-guidelines)

    </div>

7.  Lambda Expressions:

    عبارات لامبدا (Lambda expressions) ساده شده دستور زبان متدهای بی نام هستند.
    برای اینکه با این مفهوم بیشتر آشنا بشید می‌تونید لینک‌های زیر را مطالعه کنید.

    <div dir="ltr" align='justify'>

    - [Lambda Expressions in C#](https://www.geeksforgeeks.org/lambda-expressions-in-c-sharp/)
    - [Lambda Expressions in C#](https://www.c-sharpcorner.com/UploadFile/bd6c67/lambda-expressions-in-C-Sharp/)

   </div>

</div>

<div dir="rtl" align='justify'>

8.  LINQ:

    LINQ مخفف عبارت Language-Integrated Query است توجه داشته باشید که آن را لینک (Link) تلفظ کنید. LINQ یک راه یکسان برای اتصال برقرار کردن به هر داده ساختار استاندارد را فراهم می‌کنه.
    برای درک بهتر و تمرین بیشتر می‌تونید لینک‌های زیر را مطالعه کنید:

    <div dir="ltr" align='justify'>

    - [LINQ Operators and Lambda Expressions](https://www.c-sharpcorner.com/UploadFile/babu_2082/linq-operators-and-lambda-expression-syntax-examples/)
    - [LINQ Lambda Expressions](https://www.tutlane.com/tutorial/linq/linq-lambda-expressions)


    </div>
    </div>
    
<div dir="rtl" align='justify'>

9. Functional programming and C#:

   در رویکرد imprative یا procedural کدی نوشته می‌شود که مراحل کار در آن برای رسیدن به هدفی معین مشخص شده است. 
   اکثر زبان‌های برنامه‌نویسی مورد استفاده(شامل زبان‌های شئ‌گرا)برای پشتیبانی از رویکرد imperative(procedural) طراحی شد‌اند.
   در مقابل، رویکرد functional با اجرا کردن تابع‌های مختلف بر روی داده به هدف مشخص شده می‌رسد.
   
   زبان C# امکان استفاده از برنامه نویسی imperative را با به وسیله مفاهیم شئ‌گرایی به ما می‌دهد، اما می‌توانیم از برنامه نویسی declarative هم استفاده کنیم. برای مثال LINQ که در قسمت قبل با آن آشنا شدید، کتاب‌خانه‌ای است که مفاهیم برنامه نویسی functional را پیاده سازی کرده، و امکان استفاده از آن را به ما داده است.
   به کمک لینک زیر می‌توانید بیشتر با این مفهوم آشنا شوید. در آینده نمونه‌های بیشتری از برنامه نویسی functional را در C# خواهید دید.

    <div dir="ltr" align='justify'>

    - [Functional programming in C#](https://dev.to/shimmer/functional-programming-in-c-3h6e)

    </div>

## پروژه

[Visual Studio]("") ،[Rider]("") یا


برنامه‌ای بنویسید که دو فایل [دانشجویان](https://github.com/Star-Academy/codestar-internship/blob/master/Projects/Phase04-CSharp/Students.json) و [نمرات](https://github.com/Star-Academy/codestar-internship/blob/master/Projects/Phase04-CSharp/Scores.json) را بخواند و سپس نام، نام خانوادگی و معدل سه دانشجوی اول را چاپ کند.

</div>
